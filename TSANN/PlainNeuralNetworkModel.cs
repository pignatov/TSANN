using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Alchemi.Core;
using Alchemi.Core.Owner;
using AForge;
using AForge.Neuro;
using AForge.Neuro.Learning;
using AForge.Controls;
using System.Threading;
using System.Reflection;
using Dew.Math;
using Dew.Stats.Units;
using System.IO;
using System.Threading;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using AForge.Genetic;
using AForge.Math.Random;

namespace Plig.TimeSeries.Client
{
    [Serializable]
    public partial class PlainNeuralNetworkModel : Plig.TimeSeries.Client.GenericModel
    {
        private GApplication GA;
        // входни данни използвани за обучение
        private double[][] mInput;
        // изходни данни използвани при обучение
        private double[][] mOutput;
        // входни данни използвани за тестване на модела
        private double[][] mTestInput;
        // изходни данни използвани за тестване на модела
        private double[][] mTestOutput;
        private int mReinitializations = 1;
        private int ReinitsFinished;
        private int mEpochs = 1;
        private List<NNResultSet> results;
        private ActivationNetwork mBestActivationNetwork;
        private ActivationNetwork mBestTestActivationNetwork;
        private ActivationNetwork mBestGeneticActivationNetwork;
        private ActivationNetwork mSelectedActivationNetwork;
        private Stopwatch mStopWatch;
        private DataTable tblIndependent = new DataTable();
        private DataTable tblDependent = new DataTable();
        private double mindep;
        private double factordep;
        private double min;
        private double mintest;
        TVec residuals = new TVec();
        DataTable sensitivityTable = new DataTable();



        protected override IModelStorage ConstructModel()
        {
            NNModelStorage model = new NNModelStorage();
            model.Epochs = Convert.ToInt32(txtEpochs.Text);
            model.Reinitializations = Convert.ToInt32(txtReinitializations.Text);
            model.SelectedNetwork = mSelectedActivationNetwork;
            model.BestNetwork = mBestActivationNetwork;
            model.BestTestNetwork = mBestTestActivationNetwork;
            int[] dep_vars = new int[DependentVariables.Count];
            int[] indep_vars = new int[IndependentVariables.Count];

            int cnt = 0;
            foreach (int var_id in DependentVariables.Keys)
            {
                dep_vars[cnt] = var_id;
                cnt++;
            }
            model.DepVariables = dep_vars;


            cnt = 0;
            foreach (int var_id in IndependentVariables.Keys)
            {
                indep_vars[cnt] = var_id;
                cnt++;
            }
            model.IndepVariables = indep_vars;

            model.TestSamples = this.TestEnd - this.TestBegin;

            return model;
        }

        protected override void ProcessModel(IModelStorage model)
        {
            NNModelStorage nn_model = (NNModelStorage)model;
            this.txtReinitializations.Text = nn_model.Reinitializations.ToString();
            this.Reinitializations = nn_model.Reinitializations;
            this.txtEpochs.Text = nn_model.Epochs.ToString();
            mSelectedActivationNetwork = nn_model.SelectedNetwork;
            mBestActivationNetwork = nn_model.BestNetwork;
            mBestTestActivationNetwork = nn_model.BestTestNetwork;
            this.mEpochs = nn_model.Epochs;

            foreach (int var_id in nn_model.IndepVariables)
            {
                AddVarToInDep(var_id);
            }

            foreach (int var_id in nn_model.DepVariables)
            {
                AddVarToDep(var_id);
            }

            SetTestSamples(nn_model.TestSamples);
            CalculateExtractInformation();
            FillAutomatedFields();        


        }
        
        
        // Този метод се вика при десериализация
        protected PlainNeuralNetworkModel(SerializationInfo info, StreamingContext context):  base(info, context)
        {
            mInput = (double[][])info.GetValue("mInput", typeof(double[][]));
            mOutput = (double[][])info.GetValue("mOutput", typeof(double[][]));
            mTestInput = (double[][])info.GetValue("mTestInput", typeof(double[][]));
            mTestOutput = (double[][])info.GetValue("mTestOutput", typeof(double[][]));
            mReinitializations = (int)info.GetValue("mReinitializations", typeof(int));
            mEpochs = (int)info.GetValue("mEpochs", typeof(int));
            mBestActivationNetwork = (ActivationNetwork)info.GetValue("mBestActivationNetwork", typeof(ActivationNetwork));
            mBestTestActivationNetwork = (ActivationNetwork)info.GetValue("mBestTestActivationNetwork", typeof(ActivationNetwork));
            mSelectedActivationNetwork = (ActivationNetwork)info.GetValue("mSelectedActivationNetwork", typeof(ActivationNetwork));

            txtLearningRate.Text = Convert.ToString((double)info.GetValue("LearningRate", typeof(double)));
            txtMomentum.Text = Convert.ToString((double)info.GetValue("Momentum", typeof(double)));
        }

        // Този метод се използва при сериализиране
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("mInput", mInput);
            info.AddValue("mOutput", mOutput);
            info.AddValue("mTestInput", mTestInput);
            info.AddValue("mTestOutput", mTestOutput);
            info.AddValue("mReinitializations", mReinitializations);
            info.AddValue("mEpochs", mEpochs);
            info.AddValue("mBestActivationNetwork", mBestActivationNetwork);
            info.AddValue("mBestTestActivationNetwork", mBestTestActivationNetwork);
            info.AddValue("mSelectedActivationNetwork", mSelectedActivationNetwork);
            info.AddValue("LearningRate", Convert.ToDouble(txtLearningRate.Text));
            info.AddValue("Momentum", Convert.ToDouble(txtMomentum.Text));
        }

        public PlainNeuralNetworkModel()
        {
            mHelpModelUrl = Application.StartupPath + @"\reference\models\SimpleNeuralNetwork.html";
            mTypeOfModel = 1;
            InitializeComponent();
        }


        public int Reinitializations
        {
            get { return mReinitializations; }
            set { mReinitializations = value; }
        }

        private void ShowResults()
        {
            if (rbBestNetwork.Checked)
            {
                mSelectedActivationNetwork = mBestActivationNetwork;
            }
            if (rbBestTestNetwork.Checked)
            {
                mSelectedActivationNetwork = mBestTestActivationNetwork;
            }
            if (rbGenetic.Checked)
            {
                mSelectedActivationNetwork = mBestGeneticActivationNetwork;
            }

            try
            {
                TVec dy = null;
                TVec dx = null;
                fittedChart.Series.Clear();
                fittedChart.Series.Add(new Steema.TeeChart.Styles.FastLine());
                fittedChart.Series.Add(new Steema.TeeChart.Styles.FastLine());
                fittedChart.Series[0].Title = "наблюдения";
                fittedChart.Series[1].Title = "прогнози";

                fittedChart.Axes.Left.Title.Text = "Y";
                fittedChart.Axes.Bottom.Title.Text = "";
                fittedChart.Axes.Left.Automatic = true;

                Vector timeseries = new Vector((TestEnd-ExtractBegin) + 1);
                Vector abs = new Vector((TestEnd - ExtractBegin) + 1);

                int? dependent_variable_id = 0;
                foreach (int? dep in this.DependentVariables.Keys)
                {
                    dependent_variable_id = dep;
                }

                MainDataSetTableAdapters.VARIABLESTableAdapter adptVariables = new Plig.TimeSeries.Client.MainDataSetTableAdapters.VARIABLESTableAdapter();                                
                mindep = adptVariables.MinObservationValue(ExtractBegin, TestEnd, dependent_variable_id.Value).Value;
                factordep = 1.7 / (adptVariables.MaxObservationValue(ExtractBegin, TestEnd, dependent_variable_id.Value).Value - adptVariables.MinObservationValue(ExtractBegin, TestEnd, dependent_variable_id.Value).Value);

                int cnt = ExtractBegin;
                foreach (KeyValuePair<int, double?> d in this.VariableObservations(dependent_variable_id.Value))
                {
                    if (d.Key >= ExtractBegin && d.Key <= TestEnd)
                    {
                        try
                        {
                            timeseries.Values[cnt - ExtractBegin] = d.Value.Value;
                        }
                        catch
                        {
                            timeseries.Values[cnt - ExtractBegin] = 0.0;
                        }
                        abs.Values[cnt - ExtractBegin] = cnt;
                        cnt++;
                    }
                }

                dy = timeseries;
                dx = abs;
                Dew.Math.Tee.TeeChart.DrawValues(dx, dy, fittedChart.Series[0], false);

                // Извличаме стойностите на независимите променливи
                TVec dy1 = null;
                Vector timeseries1 = new Vector(TestEnd - ExtractBegin + 1);

                int independent_vars = this.IndependentVariables.Count;
                double[] tuple = new double[independent_vars];


                for (int i = ExtractBegin; i <= TestEnd; i++)
                {
                    int cnt1 = 0;
                    foreach (int variable_id in this.IndependentVariables.Keys)
                    {
                        double factor = 1.7 / ( (this.SeriesInfo[variable_id]).Max - (this.SeriesInfo[variable_id]).Min);

                        tuple[cnt1] = (this.SeriesInfo[variable_id].Values[i].Value - (this.SeriesInfo[variable_id]).Min) * factor - 0.85;
                        cnt1++;
                    }
                    double value = (mSelectedActivationNetwork.Compute(tuple)[0] + 0.85) / factordep + mindep;
                    timeseries1.Values[i - ExtractBegin] = value;
                }

                dy1 = timeseries1;
                Dew.Math.Tee.TeeChart.DrawValues(dx, dy1, fittedChart.Series[1], false);

                residuals = new TVec();
                residuals.Length = timeseries1.Length;
                for (int i = 0; i < residuals.Length; i++)
                {
                    residuals.Values[i] = timeseries1.Values[i] - timeseries.Values[i];
                }
                Vector Bins = new Vector(0);
                Vector Freq = new Vector(0);
                chartResiduals.Series[0].Title = "остатъци";
                chartResiduals.Series[1].Title = "Нормално разпределение";
                chartResiduals.Axes.Left.Title.Text = "Y";
                chartResiduals.Axes.Bottom.Title.Text = "";
                chartResiduals.Axes.Left.Automatic = true;

                Statistics.Histogram(residuals, 20, Freq, Bins, true);

                Dew.Math.Tee.TeeChart.DrawValues(Bins, Freq, chartResiduals.Series[0], false);

                Vector xdense = new Vector(0);
                Matrix tmpmtx = new Matrix(0, 0);
                Vector x = new Vector(0);
                Vector bell = new Vector(0);
                // get values for Bell curve
                double mean = residuals.Mean();
                double stddev = residuals.StdDev(mean);
                // 500 calc points
                xdense.Length = 500;
                xdense.Ramp(Bins.Min() , (Bins.Max() - Bins.Min()) * 0.005);
                Dew.Math.Units.Probabilities.NormalPDF(xdense, mean, stddev, bell);
                chartResiduals.Series[1].GetHorizAxis.Automatic = false;
                chartResiduals.Series[1].GetHorizAxis.SetMinMax(residuals.Min(), residuals.Max());
                Dew.Math.Tee.TeeChart.DrawValues(xdense, bell, chartResiduals.Series[1], false);

                double R2 = CalculateR2(dy, dy1);

                rchTests.Clear();
                rchTests.SelectionColor = Color.Red;
                rchTests.AppendText("Тестове");
                rchTests.SelectionColor = SystemColors.InfoText; ;

                rchTests.AppendText("\nНевронна мрежа с параметри: ");
                rchTests.AppendText(String.Format("\nВходящ слой: {0} неврона", mSelectedActivationNetwork.InputsCount));
                rchTests.AppendText(String.Format("\nСкрит слой: {0} неврона", mSelectedActivationNetwork[0].NeuronsCount));

                rchTests.SelectionColor = Color.Red;
                rchTests.AppendText("\nСтатистически параметри");
                rchTests.SelectionColor = SystemColors.InfoText; ;

                rchTests.AppendText(String.Format("\nCalculated R2: {0:F6}", R2));

                rchTests.AppendText("\n\nАнализ на независимите променливи");
                rchTests.AppendText("\nЗначимост");

                double max_spread = 0.0;
                foreach (int var_id in IndependentVariables.Keys)
                {
                    Vector vec = IndepVar(var_id);
                    if (max_spread < vec.Max() - vec.Min())
                    {
                        max_spread = vec.Max() - vec.Min();
                    }
                }

                int current = 1;
                foreach (int var_id in IndependentVariables.Keys)
                {
                    Vector vec = IndepVar(var_id);
                    double spread = vec.Max() - vec.Min();
                    String result = String.Format("{0,-3}. {1,25}: {2,10} | {3}", current, IndependentVariables[var_id], spread, Stars( (int)Math.Floor((10*spread)/ max_spread)));
                    rchTests.AppendText("\n" + result);
                    current++;
                }
                
                rchTests.AppendText("\n\nDurbin-Watson тест за наличие на автоколинеарност в остатъците");
                rchTests.AppendText(String.Format("\nDW: {0}", Utils.DurbinWatson((Vector)residuals)));
            }
            catch { };           
        }

        private string Stars(int aCount)
        {
            string res = string.Empty;
            for (int i = 0; i < aCount; i++)
            {
                res += '*';
            }

            return res;
        }

        protected override void OnLoad()
        {
            if (!this.DesignMode)
            {
                this.webBrowser.Navigate(Application.StartupPath + @"\reference\models\SimpleNeuralNetwork.html");
            }
        }

        protected override void StartTraining(bool aIsRunning)
        {
            if (aIsRunning)
            {
                mStopWatch = new Stopwatch();
                mStopWatch.Start();

                Stopwatch st = new Stopwatch();
                st.Start();

                min = Double.MaxValue;
                mintest = Double.MaxValue;

                // create grid application
                Settings settings = Settings.LoadSettings();
                GA = new GApplication(new GConnection(settings.AlchemiURL, settings.AlchemiPort, settings.AlchemiUser, settings.AlchemiPassword));
                GA.ApplicationName = "Plain Neural Network model";

                // add GridThread module (this executable) as a dependency
                GA.Manifest.Add(new ModuleDependency(typeof(AForge.PolishExpression).Module));
                GA.Manifest.Add(new ModuleDependency(typeof(AForge.Neuro.ActivationNetwork).Module));
                GA.Manifest.Add(new ModuleDependency(typeof(SingleNNTraining).Module));

                // subscribe to events
                GA.ThreadFinish += new GThreadFinish(ThreadFinished);
                GA.ThreadFailed += new GThreadFailed(ThreadFailed);
                GA.ApplicationFinish += new GApplicationFinish(ApplicationFinished);

                // Набор от данни използван за обучение
                mInput = new double[ExtractEnd - ExtractBegin + 1][];
                mOutput = new double[ExtractEnd - ExtractBegin + 1][];
                // Тестов набор от данни
                mTestInput = new double[TestEnd - TestBegin + 1][];
                mTestOutput = new double[TestEnd - TestBegin + 1][];
                for (int i = 0; i < ExtractEnd - ExtractBegin + 1; i++)
                {
                    mInput[i] = new double[IndependentVariables.Count];
                    mOutput[i] = new double[DependentVariables.Count];
                }

                for (int i = 0; i < TestEnd - TestBegin + 1; i++)
                {
                    mTestInput[i] = new double[IndependentVariables.Count];
                    mTestOutput[i] = new double[DependentVariables.Count];
                }


                MainDataSetTableAdapters.VARIABLESTableAdapter adptVariables = new Plig.TimeSeries.Client.MainDataSetTableAdapters.VARIABLESTableAdapter();

                mReinitializations = Convert.ToInt32(txtReinitializations.Text);
                results = new List<NNResultSet>(mReinitializations);

                mEpochs = Convert.ToInt32(txtEpochs.Text);
                ReinitsFinished = 0;

                int index_of_variable = 0;
                foreach (int variable_id in IndependentVariables.Keys)
                {
                    double minObsValue = adptVariables.MinObservationValue(ExtractBegin, ExtractEnd, variable_id).Value;
                    double factor = 1.7 / (adptVariables.MaxObservationValue(ExtractBegin, ExtractEnd, variable_id).Value - adptVariables.MinObservationValue(ExtractBegin, ExtractEnd, variable_id).Value);
                    Dictionary<int, double?> observations = VariableObservations(variable_id);
                    foreach (int counter in observations.Keys)
                    {
                        if ((counter >= ExtractBegin) && (counter <= ExtractEnd))
                        {
                            mInput[counter - ExtractBegin][index_of_variable] = (observations[counter].Value - minObsValue) * factor - 0.85;
                        }

                        if ((counter >= TestBegin) && (counter <= TestEnd))
                        {
                            mTestInput[counter - TestBegin][index_of_variable] = (observations[counter].Value - minObsValue) * factor - 0.85;
                        }

                    }
                    index_of_variable++;
                }

                index_of_variable = 0;
                foreach (int variable_id in DependentVariables.Keys)
                {
                    double minObsValue = adptVariables.MinObservationValue(ExtractBegin, ExtractEnd, variable_id).Value;
                    double factor = 1.7 / (adptVariables.MaxObservationValue(ExtractBegin, ExtractEnd, variable_id).Value - adptVariables.MinObservationValue(ExtractBegin, ExtractEnd, variable_id).Value);
                    Dictionary<int, double?> observations = VariableObservations(variable_id);
                    foreach (int counter in observations.Keys)
                    {
                        if ((counter >= ExtractBegin) && (counter <= ExtractEnd))
                        {
                            mOutput[counter - ExtractBegin][index_of_variable] = (observations[counter].Value - minObsValue) * factor - 0.85;
                        }

                        if ((counter >= TestBegin) && (counter <= TestEnd))
                        {
                            mTestOutput[counter - TestBegin][index_of_variable] = (observations[counter].Value - minObsValue) * factor - 0.85;
                        }
                    }
                    index_of_variable++;
                }

                double momentum = 0.0;
                double learning_rate = 0.1;

                learning_rate = Convert.ToDouble(txtLearningRate.Text);
                momentum = Convert.ToDouble(txtMomentum.Text);

                int min_neurons = 1;
                int max_neurons = 1;
                if (rbFixedHiddenNeurons.Checked)
                {
                    min_neurons = Convert.ToInt32(txtHiddenNeurons.Text);
                    max_neurons = min_neurons;
                }

                if (rbFlexibleHiddenNeurons.Checked)
                {
                    min_neurons = Convert.ToInt32(txtMinHiddenNeurons.Text);
                    max_neurons = Convert.ToInt32(txtMaxHiddenNeurons.Text);
                }

                int TotalNNCalculations = 0;
                for (int hidden_neurons = min_neurons; hidden_neurons <= max_neurons; hidden_neurons++)
                {

                    for (int i = 0; i < mReinitializations; i++)
                    //              Parallel.For(0, mReinitializations - 1, i =>
                    {
                        // create thread
                        SingleNNTraining single_nn = new SingleNNTraining(mInput, mOutput, mEpochs);
                        single_nn.HiddenNeurons = hidden_neurons;
                        single_nn.Iterations = mEpochs;
                        single_nn.Momentum = momentum;
                        single_nn.LearningRate = learning_rate;


                        // добавяне на набора от данни за тестване
                        single_nn.TestInput = mTestInput;
                        single_nn.TestOutput = mTestOutput;

                        // add thread to application
                        GA.Threads.Add(single_nn);
                        TotalNNCalculations++;
                    }
                    //                );
                }

                pbProgressTraining.Minimum = 0;
                pbProgressTraining.Maximum = TotalNNCalculations - 1;

                GA.Start();

                st.Stop();
                lbResults.Items.Add("Време необходимо за конструиране на данните: " + st.Elapsed.ToString());

                int populationCount = Convert.ToInt32(txtPopulationCount.Text);
                Population population = new Population(populationCount,
                    new DoubleArrayChromosome(new AForge.Math.Random.UniformOneGenerator(),
                        new AForge.Math.Random.GaussianGenerator(0, 1),new AForge.Math.Random.GaussianGenerator(0, 1),
                        (mOutput.Length + mInput.Length + 1) * 10 + mOutput.Length),
                    new NeuralNetworkFitness(mInput, mOutput, new int[] { IndependentVariables.Count, 10, DependentVariables.Count }),
                    new EliteSelection());
                

                int geneticEpochs = Convert.ToInt32(txtGeneticEpochs.Text);
                pbGeneticProgress.Maximum = geneticEpochs;

                for (int i = 0; i < geneticEpochs; i++)
                {
                    population.RunEpoch();
                    pbGeneticProgress.Value = i + 1;
                    Application.DoEvents();
                }


                NeuralNetworkFitness nnf = new NeuralNetworkFitness(mInput, mOutput, new int[] { IndependentVariables.Count, 5, DependentVariables.Count });
                mBestGeneticActivationNetwork = (ActivationNetwork)nnf.Translate(population.BestChromosome);

            }
            else
            {
                if (GA.Running)
                {
                    foreach (GThread thread in GA.Threads)
                    {
                        thread.Abort();
                    }
//                     GA.Stop();
                    lbResults.Items.Add("Обучението е прекъснато.");
                }
            }
            

            

        }
        delegate void ResultsAddItemsCaller(string aItem);
        delegate void RefreshVisualStatus();

        private void ThreadFinished(GThread th)
        {
//            double min = Double.MaxValue;
//            double mintest = Double.MaxValue;
            double min_local = Double.MaxValue;
            double mintest_local = Double.MaxValue;
            lock (this)
            {
                foreach (double d in (th as SingleNNTraining).Errors)
                {
                    if (d < min_local)
                    {
                        min_local = d;
                    }
                }

                if (min_local < min)
                {
                    min = min_local;
                    mBestActivationNetwork = (th as SingleNNTraining).Network;
                }

                if (mintest > (th as SingleNNTraining).MinTestError)
                {
                    mintest = (th as SingleNNTraining).MinTestError;
                    mBestTestActivationNetwork = (th as SingleNNTraining).TestBestNetwork;
                }
            }

            NNResultSet single_result = new NNResultSet();
            single_result.Error = min_local;
            results.Add(single_result);

            ResultsAddItemsCaller res = new ResultsAddItemsCaller(ResultsAddItems);
            lbResults.Invoke(res, String.Format("{0} {1}", min_local, (th as SingleNNTraining).MinTestError));

            RefreshVisualStatus refresh_status = new RefreshVisualStatus(DoRefreshVisualStatus);
            this.Invoke(refresh_status);
            ReinitsFinished++;            
        }

        private void ResultsAddItems(string aItem)
        {
            lbResults.Items.Add(aItem);
        }

        private void DoRefreshVisualStatus()
        {
            pbProgressTraining.Value = ReinitsFinished;
            DoRefreshTrainingChart();
        }

        private void DoRefreshTrainingChart()
        {
            Vector abs = new Vector(ReinitsFinished);
            Vector res = new Vector(ReinitsFinished);

            trainingChart.Series.Clear();
            trainingChart.Series.Add(new Steema.TeeChart.Styles.FastLine());

            trainingChart.Axes.Left.Title.Text = "Грешка";
            trainingChart.Axes.Bottom.Title.Text = "";
            trainingChart.Axes.Left.Automatic = true;

            for (int i = 0; i < ReinitsFinished; i++)
            {
                abs.Values[i] = i;
                res.Values[i] = results[i].Error;
            }

            Dew.Math.Tee.TeeChart.DrawValues(abs, res, trainingChart.Series[0], false);

        }

        private void ThreadFailed(GThread th, Exception e)
        {
            MessageBox.Show(String.Format("thread # {0} finished with error '{1}'",
                th.Id,
                e.Message));
        }

        private void ApplicationFinished()
        {
            mStopWatch.Stop();
            ResultsAddItemsCaller res = new ResultsAddItemsCaller(ResultsAddItems);
            lbResults.Invoke(res, "Application finished");
            lbResults.Invoke(res, "Време за изпълнение: " + mStopWatch.Elapsed.ToString());
            lbResults.Invoke(res, String.Format("Най-добрата мрежа е с {0} неврона в скрития слой", mBestActivationNetwork[0].NeuronsCount)); 
            lbResults.Invoke(res, String.Format("Най-добрата тестова мрежа е с {0} неврона в скрития слой", mBestTestActivationNetwork[0].NeuronsCount));
            this.IsRunning = false;

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            ShowResults();
        }

        private double CalculateR2(TVec observedValues, TVec predictedValues)
        {
            double ssTot = 0.0;
            double ssErr = 0.0;

            for(int i = 0; i < observedValues.Length - 1; i++)
            {
                ssTot += (observedValues[i] - observedValues.Mean()) * (observedValues[i] - observedValues.Mean());
                ssErr += (predictedValues[i] - observedValues[i]) * (predictedValues[i] - observedValues[i]);
            }

            return 1 - (ssErr / ssTot);
        }

        private void LoadSensitivityVariables()
        {
            sensitivityTable.Rows.Clear();
            sensitivityTable.Columns.Clear();
            sensitivityTable.Columns.Add("NAME");
            sensitivityTable.Columns.Add("ID");
            sensitivityTable.Columns.Add("Value");

            lvVariablesSensitivity.Items.Clear();
            foreach (int id in IndependentVariables.Keys)
            {
                ListViewItem lvi = new ListViewItem(new string[] {IndependentVariables[id], id.ToString() });
                lvVariablesSensitivity.Items.Add(lvi);
                sensitivityTable.Rows.Add(IndependentVariables[id], id.ToString(), this.SeriesInfo[id].Mean); 
            }

            grdSensitivityVars.DataSource = sensitivityTable;
        }

        public static DataRow CurrentRow(DataGridView aGrid)
        {
            CurrencyManager xCM =
              (CurrencyManager)aGrid.BindingContext[aGrid.DataSource, aGrid.DataMember];
            DataRowView xDRV = (DataRowView)xCM.Current;
            return xDRV.Row;
        }

        private void btnSensitivityAnalysisReload_Click(object sender, EventArgs e)
        {
            LoadSensitivityVariables();
        }

        /// <summary>
        /// Попълва полетата, които се генерират автоматично - като минимален и максимален брой неврони и learning rate/ momentum
        /// </summary>
        protected override void FillAutomatedFields()
        {
            txtLearningRate.Text = Convert.ToString(0.1);

            txtMinHiddenNeurons.Text = Convert.ToString(IndependentVariables.Count / 2);
            txtMaxHiddenNeurons.Text = Convert.ToString(IndependentVariables.Count * 3);
        }

        /// <summary>
        /// Вектор от всички стойности от невронна мрежа при фиксирани всички променливи (освен aVariableID) в mean стойност
        /// </summary>
        /// <param name="aVariableID"></param>
        /// <returns></returns>
        private Vector IndepVar(int aVariableID)
        {
                // ID на променливата, коят искаме да изследваме
                int var_id = aVariableID;

                SeriaInformation seria_info = SeriesInfo[var_id];
                double?[] sorted_values = seria_info.SortedValues();

                try
                {
                    TVec dy = null;
                    TVec dx = null;

                    Vector timeseries = new Vector(ExtractEnd - ExtractBegin + 1);
                    Vector abs = new Vector(sorted_values.Length);
                    for (int i = 0; i < sorted_values.Length; i++)
                    {
                        if (sorted_values[i].HasValue)
                            abs.Values[i] = sorted_values[i].Value;
                        else
                            abs.Values[i] = seria_info.Min;
                    }

                    dx = abs;

                    // Извличаме стойностите на независимите променливи
                    TVec dy1 = null;
                    Vector timeseries1 = new Vector(sorted_values.Length);

                    int independent_vars = this.IndependentVariables.Count;
                    double[] tuple = new double[independent_vars];

                    int dependent_variable_id = 0;
                    foreach (int? dep in this.DependentVariables.Keys)
                    {
                        dependent_variable_id = dep.Value;
                    }
                    double mindep = this.SeriesInfo[dependent_variable_id].Min;
                    double factordep = 1.7 / (this.SeriesInfo[dependent_variable_id].Max - this.SeriesInfo[dependent_variable_id].Min);

                    for (int i = 0; i < sorted_values.Length; i++)
                    {
                        int cnt1 = 0;
                        foreach (int variable_id in this.IndependentVariables.Keys)
                        {

                            double factor = 1.7 / ((this.SeriesInfo[variable_id]).Max - (this.SeriesInfo[variable_id]).Min);

                            if (variable_id == var_id)
                            {
                                if (sorted_values[i].HasValue)
                                    tuple[cnt1] = sorted_values[i].Value * factor - 0.85;
                            }
                            else
                            {
                                tuple[cnt1] = (this.SeriesInfo[variable_id].Mean) * factor - 0.85;
                            }
                            cnt1++;
                        }
                        double value = (mSelectedActivationNetwork.Compute(tuple)[0] + 0.85) / factordep + mindep;
                        timeseries1.Values[i] = value;
                    }

                    dy1 = timeseries1;
                    return timeseries1;
                }
                catch 
                {
                    return new Vector();
                };


        }

        private void lvVariablesSensitivity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvVariablesSensitivity.SelectedItems.Count != 0)
            {
                ListViewItem selected_item = lvVariablesSensitivity.SelectedItems[0];
                // ID на променливата, коят искаме да изследваме
                int var_id = Convert.ToInt32(selected_item.SubItems[1].Text);

                SeriaInformation seria_info = SeriesInfo[var_id];
                double?[] sorted_values = seria_info.SortedValues();

                try
                {
                    TVec dy = null;
                    TVec dx = null;
                    SensitivityChart.Series.Clear();
                    SensitivityChart.Series.Add(new Steema.TeeChart.Styles.FastLine());
                    SensitivityChart.Series[0].Title = "наблюдения";

                    SensitivityChart.Axes.Left.Title.Text = "Y";
                    SensitivityChart.Axes.Bottom.Title.Text = "";
                    SensitivityChart.Axes.Left.Automatic = true;

                    Vector timeseries = new Vector(ExtractEnd - ExtractBegin + 1);
                    Vector abs = new Vector(sorted_values.Length);
                    for (int i = 0; i < sorted_values.Length; i++)
                    {
                        if (sorted_values[i].HasValue)
                            abs.Values[i] = sorted_values[i].Value;
                        else
                            abs.Values[i] = seria_info.Min;
                    }

                    dx = abs;

                    // Извличаме стойностите на независимите променливи
                    TVec dy1 = null;
                    Vector timeseries1 = new Vector(sorted_values.Length);

                    int independent_vars = this.IndependentVariables.Count;
                    double[] tuple = new double[independent_vars];

                 int dependent_variable_id = 0;
                foreach (int? dep in this.DependentVariables.Keys)
                {
                    dependent_variable_id = dep.Value;
                }
                    double mindep = this.SeriesInfo[dependent_variable_id].Min;
                    double factordep = 1.7 / (this.SeriesInfo[dependent_variable_id].Max - this.SeriesInfo[dependent_variable_id].Min);

                    for (int i = 0; i < sorted_values.Length; i++)
                    {
                        int cnt1 = 0;
                        foreach (int variable_id in this.IndependentVariables.Keys)
                        {
                            
                            double factor = 1.7 / ((this.SeriesInfo[variable_id]).Max - (this.SeriesInfo[variable_id]).Min);

                            if (variable_id == var_id)
                            {
                                if (sorted_values[i].HasValue)
                                    tuple[cnt1] = sorted_values[i].Value * factor - 0.85;
                            }
                            else
                            {
                                tuple[cnt1] = (this.SeriesInfo[variable_id].Mean) * factor - 0.85;
                            }
                            cnt1++;
                        }
                        double value = (mSelectedActivationNetwork.Compute(tuple)[0] + 0.85) / factordep + mindep;
                        timeseries1.Values[i] = value;
                    }

                    dy1 = timeseries1;
                    Dew.Math.Tee.TeeChart.DrawValues(dx, dy1, SensitivityChart.Series[0], false);
                }
                catch { };
            }
        }

        protected override void TabChanged(int aTabChanged)
        {
            switch (aTabChanged)
            {
                case 0: break;
                case 1: break;
                case 2: CalculateExtractInformation();
                    FillAutomatedFields();
                    rbFlexibleHiddenNeurons.Checked = true;
                    break;
                case 3: break;
                case 4: break;
                case 5:
                    FillForecastFields();
                    break;
            }
        }

        private void FillForecastFields()
        {
            tblIndependent.Clear();
            tblIndependent.Columns.Clear();
            tblIndependent.Columns.Add("Name", typeof(string));
            tblIndependent.Columns.Add("Value", typeof(Double));
            tblIndependent.Columns.Add("ID", typeof(int));
            tblDependent.Clear();
            tblDependent.Columns.Clear();
            tblDependent.Columns.Add("Name", typeof(string));
            tblDependent.Columns.Add("Value", typeof(Double));

            foreach(KeyValuePair<int, string> kvp in IndependentVariables)
            {
                tblIndependent.Rows.Add(new object[]{kvp.Value, 0, kvp.Key});
            }

            foreach (string dep_var in DependentVariables.Values)
            {
                tblDependent.Rows.Add(new object[] { dep_var, 0 });
            }

            grdForecastInDep.DataSource = tblIndependent;
            grdForecastDep.DataSource = tblDependent;

            // Скриваме колоната с ID на променливата
            grdForecastInDep.Columns["ID"].Visible = false;
        }

        private void fittedChart_AfterDraw(object sender, Steema.TeeChart.Drawing.Graphics3D g)
        {
            int xpos;
            xpos = fittedChart.Axes.Bottom.CalcXPosValue(ExtractBegin);
            Rectangle r = fittedChart.Chart.ChartRect;
            g.ClipRectangle(r);
            g.Pen.Color = Color.Blue;
            g.Pen.Width = 2;
            g.Pen.Style = System.Drawing.Drawing2D.DashStyle.DashDot;
            g.VerticalLine(xpos, r.Top, r.Bottom);
            xpos = fittedChart.Axes.Bottom.CalcXPosValue(TestBegin);
            g.VerticalLine(xpos, r.Top, r.Bottom);
            g.UnClip();
        }

        private void rbFixedHiddenNeurons_CheckedChanged(object sender, EventArgs e)
        {
            pnlFixedHiddenNeurons.Visible = true;
            pnlFlexibleHiddenNeurons.Visible = false;
        }

        private void rbFlexibleHiddenNeurons_CheckedChanged(object sender, EventArgs e)
        {
            pnlFixedHiddenNeurons.Visible = false;
            pnlFlexibleHiddenNeurons.Visible = true;
        }

        private void txtLearningRate_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                Convert.ToDouble(txtLearningRate.Text);
                errorProvider.SetError(txtLearningRate, "");
            }
            catch
            {
                errorProvider.SetError(txtLearningRate, "Невалидна стойност за параметър Learning rate!\nВалидни стойности са между 0 и 1. ");
            }
        }

        private void txtMomentum_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                Convert.ToDouble(txtMomentum.Text);
                errorProvider.SetError(txtMomentum, "");
            }
            catch
            {
                errorProvider.SetError(txtMomentum, "Невалидна стойност за параметър Momentum!\nВалидни стойности са между 0 и 1. ");
            }

        }

        private void btnForecast_Click(object sender, EventArgs e)
        {
            double[] input = new double[IndependentVariables.Count];
            
            int index = 0;
            foreach(DataRow row in tblIndependent.Rows)
            {
                double factor = 1.7 / ((this.SeriesInfo[Convert.ToInt32(row["ID"])]).Max - (this.SeriesInfo[Convert.ToInt32(row["ID"])]).Min);

                input[index] = (Convert.ToDouble(row["Value"]) - (this.SeriesInfo[Convert.ToInt32(row["ID"])]).Min) * factor - 0.85;
                index++;
            }

            double[] output = mSelectedActivationNetwork.Compute(input);
            for (int i = 0; i < output.Length; i++)
            {
                tblDependent.Rows[i]["Value"] = 
                                        (output[i] + 0.85) / factordep + mindep;
            }

            grdForecastDep.DataSource = tblDependent;
        }

        private void btnShowSensVar_Click(object sender, EventArgs e)
        {
            {
                // ID на променливата, коят искаме да изследваме
                int var_id = Convert.ToInt32(CurrentRow(grdSensitivityVars)["ID"]);

                SeriaInformation seria_info = SeriesInfo[var_id];
                double?[] sorted_values = seria_info.SortedValues();

                try
                {
                    TVec dy = null;
                    TVec dx = null;
                    SensitivityChart.Series.Clear();
                    SensitivityChart.Series.Add(new Steema.TeeChart.Styles.FastLine());
                    SensitivityChart.Series[0].Title = "наблюдения";

                    SensitivityChart.Axes.Left.Title.Text = "Y";
                    SensitivityChart.Axes.Bottom.Title.Text = "";
                    SensitivityChart.Axes.Left.Automatic = true;

                    Vector timeseries = new Vector(ExtractEnd - ExtractBegin + 1);
                    Vector abs = new Vector(sorted_values.Length);
                    for (int i = 0; i < sorted_values.Length; i++)
                    {
                        if (sorted_values[i].HasValue)
                            abs.Values[i] = sorted_values[i].Value;
                        else
                            abs.Values[i] = seria_info.Min;
                    }

                    dx = abs;

                    // Извличаме стойностите на независимите променливи
                    TVec dy1 = null;
                    Vector timeseries1 = new Vector(sorted_values.Length);

                    int independent_vars = this.IndependentVariables.Count;
                    double[] tuple = new double[independent_vars];

                    int dependent_variable_id = 0;
                    foreach (int? dep in this.DependentVariables.Keys)
                    {
                        dependent_variable_id = dep.Value;
                    }
                    double mindep = this.SeriesInfo[dependent_variable_id].Min;
                    double factordep = 1.7 / (this.SeriesInfo[dependent_variable_id].Max - this.SeriesInfo[dependent_variable_id].Min);

                    for (int i = 0; i < sorted_values.Length; i++)
                    {
                        int cnt1 = 0;
                        foreach (int variable_id in this.IndependentVariables.Keys)
                        {

                            double factor = 1.7 / ((this.SeriesInfo[variable_id]).Max - (this.SeriesInfo[variable_id]).Min);

                            if (variable_id == var_id)
                            {
                                if (sorted_values[i].HasValue)
                                    tuple[cnt1] = sorted_values[i].Value * factor - 0.85;
                            }
                            else
                            {
                                tuple[cnt1] = (Convert.ToDouble(CurrentRow(grdSensitivityVars)["Value"])) * factor - 0.85;
                            }
                            cnt1++;
                        }
                        double value = (mSelectedActivationNetwork.Compute(tuple)[0] + 0.85) / factordep + mindep;
                        timeseries1.Values[i] = value;
                    }

                    dy1 = timeseries1;
                    Dew.Math.Tee.TeeChart.DrawValues(dx, dy1, SensitivityChart.Series[0], false);
                }
                catch { };
            }

        }
    }

    public class NNResultSet
    {
        public double Error;
    }

    
    
    [Serializable]
    public class SingleNNTraining : GThread
    {
        double[][] mInput;
        double[][] mOutput;
        // Данни използвани за тестване на модела
        double[][] mTestInput;
        double[][] mTestOutput;
        double min_test_error = double.MaxValue;

        private double sigmoidAlphaValue = 2.0;
        // Брой скрити неврони
        private int mHiddenNeurons = 1;
        private int mIterations = 100;
        private double mLearningRate = 0.1;
        private double mMomentum = 0.0;
        private double[] mErrors;
        private double[] mTestErrors;
        private ActivationNetwork mNetwork;
        private ActivationNetwork mTestBestNetwork;

        public int Iterations
        {
            get { return mIterations; }
            set {
                if (mIterations != value)
                {
                    // Преинициализираме масива, само ако имаме промяна в стойността
                    mIterations = value;
                    mErrors = new double[this.mIterations];
                }
            }
        }

        public double MinTestError
        {
            get { return min_test_error; }
        }

        public double[] Errors
        {
            get { return mErrors; }
        }

        public double[] TestErrors
        {
            get { return mTestErrors; }
        }

        public double LearningRate
        {
            get { return mLearningRate; }
            set { mLearningRate = value; }
        }

        public double Momentum
        {
            get { return mMomentum; }
            set { mMomentum = value; }
        }

        public int HiddenNeurons
        {
            get { return mHiddenNeurons; }
            set { mHiddenNeurons = value; }
        }

        public ActivationNetwork Network
        {
            get { return mNetwork; }
        }

        public ActivationNetwork TestBestNetwork
        {
            get { return mTestBestNetwork; }
            set { mTestBestNetwork = value; }
        }

        public double[][] TestOutput
        {
            get { return mTestOutput; }
            set { mTestOutput = value; }
        }

        public double[][] TestInput
        {
            get { return mTestInput; }
            set { mTestInput = value; }
        }

        public SingleNNTraining(double[][] aInput, double[][] aOutput, int aMaxIterations)
        {
            this.mInput = aInput;
            this.mOutput = aOutput;
            this.mIterations = aMaxIterations;
            mErrors = new double[this.mIterations];
            // Без значение дали ще използваме тестови данни е добре да инициализираме масива
            mTestErrors = new double[this.mIterations];
        }


        public override void Start()
        {
            SearchSolution();
        }

        private void SearchSolution()
        {
            MemoryStream ms = new MemoryStream();

            mNetwork = new ActivationNetwork(
                new BipolarSigmoidFunction(sigmoidAlphaValue),
                mInput[0].Length, mHiddenNeurons, mOutput[0].Length);

            // create teacher
            BackPropagationLearning teacher = new BackPropagationLearning(mNetwork);
            // set learning rate and momentum
            teacher.LearningRate = mLearningRate;
            teacher.Momentum = mMomentum;

            bool needToStop = false;
            int iteration = 0;

            while (!needToStop)
            {
                double error = teacher.RunEpoch(mInput, mOutput) / mInput.Length;
                mErrors[iteration] = error;                

                double test_error = 0.0;
                for (int i = 0; i < mTestInput.Length; i++)
                {
                    double[] test_result = mNetwork.Compute(mTestInput[i]);
                    test_error += ( mTestOutput[i][0] - test_result[0])*( mTestOutput[i][0] - test_result[0]); 
                }
                mTestErrors[iteration] = Math.Sqrt(test_error);
                if (min_test_error > mTestErrors[iteration])
                {
                    min_test_error = mTestErrors[iteration];
                    // mTestBestNetwork = mNetwork;
                    ms = new MemoryStream();
                    mNetwork.Save(this.Id + ".txt");
                }

                iteration++;
                if (iteration >= mIterations) needToStop = true;

            }
            mTestBestNetwork = (ActivationNetwork)ActivationNetwork.Load(this.Id + ".txt");
        }
    }
}
