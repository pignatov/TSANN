using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Dew.Stats.Units;
using Dew.Math;

namespace Plig.TimeSeries.Client
{
    public partial class LinearRegressionModel : Plig.TimeSeries.Client.GenericModel
    {
        Dew.Stats.TMtxMulLinReg multiLinReg = new Dew.Stats.TMtxMulLinReg();
        public LinearRegressionModel()
        {
            mHelpModelUrl = Application.StartupPath + @"\reference\models\linear_regression.html";
            InitializeComponent();
        }

        protected override void StartTraining(bool aIsRunning)
        {
            if (aIsRunning)
            {
                TMtx indepVars = new TMtx();
                TVec depVars = new TVec();
                string[] var_names = new string[IndependentVariables.Count];

                indepVars.Cols = IndependentVariables.Count;
                indepVars.Rows = ExtractEnd - ExtractBegin + 1;
                depVars.Length = ExtractEnd - ExtractBegin + 1;


                double[][] mInput = new double[ExtractEnd - ExtractBegin + 1][];
                double[][] mOutput = new double[ExtractEnd - ExtractBegin + 1][];
                for (int i = 0; i < ExtractEnd - ExtractBegin + 1; i++)
                {
                    mInput[i] = new double[IndependentVariables.Count];
                    mOutput[i] = new double[DependentVariables.Count];
                }

                MainDataSetTableAdapters.VARIABLESTableAdapter adptVariables = new Plig.TimeSeries.Client.MainDataSetTableAdapters.VARIABLESTableAdapter();

                int index_of_variable = 0;
                foreach (int variable_id in IndependentVariables.Keys)
                {
                    var_names[index_of_variable] = IndependentVariables[variable_id];
                    Dictionary<int, double?> observations = VariableObservations(variable_id);
                    TVec vec = new TVec();
                    foreach (int counter in observations.Keys)
                    {
                        if ((counter >= ExtractBegin) && (counter <= ExtractEnd))
                        {
                            mInput[counter - ExtractBegin][index_of_variable] = observations[counter].Value;
                            indepVars[counter - ExtractBegin, index_of_variable] = observations[counter].Value;
                        }
                    }

                    index_of_variable++;
                }

                index_of_variable = 0;
                foreach (int variable_id in DependentVariables.Keys)
                {
                    Dictionary<int, double?> observations = VariableObservations(variable_id);
                    foreach (int counter in observations.Keys)
                    {
                        if ((counter >= ExtractBegin) && (counter <= ExtractEnd))
                        {

                            mOutput[counter - ExtractBegin][index_of_variable] = observations[counter].Value;
                            depVars[counter - ExtractBegin] = observations[counter].Value;
                        }
                    }
                    index_of_variable++;
                }


                multiLinReg.A = indepVars;
                multiLinReg.Y = depVars;

                multiLinReg.Recalc();

                txtResults.Clear();
                txtResults.SelectionColor = Color.Red;
                txtResults.AppendText("Тестове");
                txtResults.SelectionColor = SystemColors.InfoText; ;

                txtResults.SelectionColor = Color.Red;
                txtResults.AppendText("Статистически параметри");
                txtResults.SelectionColor = SystemColors.InfoText; ;
                txtResults.AppendText("\nRSS: " + (multiLinReg.RegressStatistics.AdjustedR2.ToString() + "\n"));

                string regression_formula = string.Empty;
                for (int i = 0; i < multiLinReg.RegressResult.B.Length - 1; i++)
                {
                    regression_formula += String.Format("+{0:F6}.{1}", multiLinReg.RegressResult.B[i], var_names[i]);
                }
                regression_formula += String.Format("+{0:F6}", multiLinReg.RegressResult.B[multiLinReg.RegressResult.B.Length - 1]);

                txtResults.AppendText("\nY = " + regression_formula);

                txtResults.AppendText("\n\nDurbin-Watson тест за наличие на автоколинеарност в остатъците");
                txtResults.AppendText(String.Format("\nDW: {0}", Utils.DurbinWatson((Vector)multiLinReg.RegressResult.Residuals)));


                Vector Bins = new Vector(0);
                Vector Freq = new Vector(0);
                chartResiduals.Series[0].Title = "остатъци";
                chartResiduals.Axes.Left.Title.Text = "Y";
                chartResiduals.Axes.Bottom.Title.Text = "";
                chartResiduals.Axes.Left.Automatic = true;

                Statistics.Histogram(multiLinReg.RegressResult.Residuals, 15, Freq, Bins, true);

                TVec dy = Freq;
                TVec dx = Bins;
                Dew.Math.Tee.TeeChart.DrawValues(dx, dy, chartResiduals.Series[0], false);

                this.IsRunning = false;
            }
        }

        protected override void OnLoad()
        {
            if (!this.DesignMode)
            {
                this.webBrowser.Navigate(Application.StartupPath + @"\reference\models\LinearRegression.html");
            }
        }

        
        private void btnResult_Click(object sender, EventArgs e)
        {
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

                Vector timeseries = new Vector((TestEnd - ExtractBegin) + 1);
                Vector abs = new Vector((TestEnd - ExtractBegin) + 1);

                int? dependent_variable_id = 0;
                foreach (int? dep in this.DependentVariables.Keys)
                {
                    dependent_variable_id = dep;
                }

                MainDataSetTableAdapters.VARIABLESTableAdapter adptVariables = new Plig.TimeSeries.Client.MainDataSetTableAdapters.VARIABLESTableAdapter();
                double mindep = adptVariables.MinObservationValue(ExtractBegin, TestEnd, dependent_variable_id.Value).Value;
                double factordep = 1.7 / (adptVariables.MaxObservationValue(ExtractBegin, TestEnd, dependent_variable_id.Value).Value - adptVariables.MinObservationValue(ExtractBegin, TestEnd, dependent_variable_id.Value).Value);

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

                Dew.Math.Tee.TeeChart.DrawValues(dx, multiLinReg.RegressResult.YCalc, fittedChart.Series[1], false);
            }
            catch (Exception ex)
            {
            }
        }
    }
}
