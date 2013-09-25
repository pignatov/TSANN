using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Plig.TimeSeries.Client
{
    [Serializable]
    public partial class GenericModel : Form, ISerializable
    {
        protected int ExtractBegin;
        protected int ExtractEnd = Int32.MaxValue;
        protected int TestBegin;
        protected int TestEnd;
        protected int ExtractCount;
        protected Dictionary<int, SeriaInformation> SeriesInfo = new Dictionary<int,SeriaInformation>();
        protected string mHelpModelUrl;
        bool mIsRunning = false;
        protected int mTypeOfModel = -1;
        protected int mPROJECT_ID;

        
        public GenericModel()
        {
            InitializeComponent();
        }

        public int TypeOfModel 
        {
            get { return mTypeOfModel; }
        }

        public int PROJECT_ID
        {
            get { return mPROJECT_ID; }
            set { mPROJECT_ID = value; }
        }

        public string HelpModelUrl
        {
            get { return mHelpModelUrl; }
            set { mHelpModelUrl = value; }
        }

        public delegate void SetText(Control aControl, string aText);


        private void SetControlText(Control aControl, string aText)
        {
            aControl.Text = aText;
        }

        protected bool IsRunning
        {
            get { return mIsRunning; }
            set { mIsRunning = value;
                if (mIsRunning)
                {
                    btnStart.ImageIndex = 1;
                    SetText mydelegate = new SetText(SetControlText);
                    btnStart.Invoke(mydelegate, new object[] { btnStart, "Спри" });
                }
                else
                {
                    btnStart.ImageIndex = 0;

                    SetText mydelegate = new SetText(SetControlText);
                    btnStart.Invoke(mydelegate, new object[]{btnStart, "Старт"  });
                }
            }
        }

        // Конструктор за десериализация
        protected GenericModel(SerializationInfo info, StreamingContext context)
        {
            ExtractBegin = info.GetInt32("ExtractBegin");
            ExtractEnd = info.GetInt32("ExtractEnd");
            TestBegin = info.GetInt32("TestBegin");
            TestEnd = info.GetInt32("TestEnd");
            ExtractCount = info.GetInt32("ExtractCount");
            SeriesInfo = (Dictionary<int, SeriaInformation>)info.GetValue("SeriesInfo", typeof(Dictionary<int, SeriaInformation>));
        }

        // Сериализация на обектите, които се съхраняват в базовия Generic Model клас
        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("ExtractBegin", ExtractBegin);
            info.AddValue("ExtractEnd", ExtractEnd);
            info.AddValue("TestBegin", TestBegin);
            info.AddValue("TestEnd", TestEnd);
            info.AddValue("ExtractCount", ExtractCount);
            info.AddValue("SeriesInfo", SeriesInfo);
        }

        public Dictionary<int, string> DependentVariables
        {
            get
            {
                Dictionary<int, string> depVars = new Dictionary<int, string>();
                foreach (ListViewItem lvi in lvDependentVar.Items)
                {
                    depVars.Add(Convert.ToInt32(lvi.SubItems[2].Text), lvi.SubItems[0].Text);
                }

                return depVars;
            }
        }

        private int CalculateVariableInformation(int aVariableID, out int oBegin, out int oEnd)
        {
            MainDataSetTableAdapters.OBSERVATIONSTableAdapter adptObservations = new Plig.TimeSeries.Client.MainDataSetTableAdapters.OBSERVATIONSTableAdapter();

            oBegin = adptObservations.MinObservation(aVariableID).Value; ;
            oEnd = adptObservations.MaxObservations(aVariableID).Value;
            int count = adptObservations.CountObservations(aVariableID).Value;

            return count;
        }

        protected Dictionary<int, double?> VariableObservations(int aVariableID)
        {
            MainDataSetTableAdapters.OBSERVATIONSTableAdapter adptObservations = new Plig.TimeSeries.Client.MainDataSetTableAdapters.OBSERVATIONSTableAdapter();
            MainDataSet.OBSERVATIONSDataTable tblObservations = new MainDataSet.OBSERVATIONSDataTable();
            tblObservations = adptObservations.GetDataByVariable(aVariableID);

            Dictionary<int, double?> observations = new Dictionary<int,double?>();

            foreach (MainDataSet.OBSERVATIONSRow obsRow in tblObservations)
            {
                if (!obsRow.IsVALUENull())
                    observations.Add(obsRow.COUNTER, obsRow.VALUE);
                else
                    observations.Add(obsRow.COUNTER, null);
            }

            return observations;

        }

        protected void SetTestSamples(int aSamples)
        {
            udModelValidation.Value = (decimal)aSamples;
        }

        protected TimeSpan ElapsedTime(Action aAction)
        {
            Stopwatch st = new Stopwatch();
            st.Start();
            aAction.Invoke();
            st.Stop();
            return st.Elapsed;
        }

        protected void CalculateExtractInformation()
        {
            ExtractBegin = Int32.MinValue;
            ExtractEnd = Int32.MaxValue;
            int begin, end;
            foreach (int aVarId in DependentVariables.Keys)
            {
                CalculateVariableInformation(aVarId,  out begin, out end);
                if (ExtractBegin < begin) ExtractBegin = begin;
                if (ExtractEnd > end) ExtractEnd = end;
            }

            foreach (int aVarId in IndependentVariables.Keys)
            {
                CalculateVariableInformation(aVarId, out begin, out end);
                if (ExtractBegin < begin) ExtractBegin = begin;
                if (ExtractEnd > end) ExtractEnd = end;
            }
            TestEnd = ExtractEnd;
            udModelValidation.Maximum = ExtractEnd - ExtractBegin;

            TestBegin = ExtractEnd - (int)udModelValidation.Value + 1;
            ExtractEnd = ExtractEnd - (int)udModelValidation.Value;

            lblExtractBegin.Text = ExtractBegin.ToString();
            lblExtractEnd.Text = ExtractEnd.ToString();

            SeriesInfo.Clear();
            MainDataSetTableAdapters.OBSERVATIONSTableAdapter obsAdapter = new Plig.TimeSeries.Client.MainDataSetTableAdapters.OBSERVATIONSTableAdapter();

            foreach (int key in IndependentVariables.Keys)
            {
                MainDataSet.OBSERVATIONSDataTable tblObservations = new MainDataSet.OBSERVATIONSDataTable();
                tblObservations = obsAdapter.GetDataByVariable(key);
                double?[] varObservations = new double?[tblObservations.Rows.Count];

                int count = 0;
                foreach (MainDataSet.OBSERVATIONSRow obsRow in tblObservations)
                {
                    if (obsRow.IsVALUENull())
                        varObservations[count] = null;
                    else
                        varObservations[count] = obsRow.VALUE;
                    count++;
                }

                SeriaInformation seria_info = new SeriaInformation(varObservations);
                seria_info.Values = this.VariableObservations(key);
                SeriesInfo.Add(key, seria_info);
            }

            foreach (int key in DependentVariables.Keys)
            {
                MainDataSet.OBSERVATIONSDataTable tblObservations = new MainDataSet.OBSERVATIONSDataTable();
                tblObservations = obsAdapter.GetDataByVariable(key);
                double?[] varObservations = new double?[tblObservations.Rows.Count];

                int count = 0;
                foreach (MainDataSet.OBSERVATIONSRow obsRow in tblObservations)
                {
                    if (obsRow.IsVALUENull())
                        varObservations[count] = null;
                    else
                        varObservations[count] = obsRow.VALUE;
                    count++;
                }

                SeriaInformation seria_info = new SeriaInformation(varObservations);
                SeriesInfo.Add(key, seria_info);
            }

        }

        public Dictionary<int, string> IndependentVariables
        {
            get
            {
                Dictionary<int, string> indepVars = new Dictionary<int, string>();
                foreach (ListViewItem lvi in lvIndependentVar.Items)
                {
                    indepVars.Add(Convert.ToInt32(lvi.SubItems[2].Text), lvi.SubItems[0].Text);
                }

                return indepVars;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected virtual void OnLoad()
        {

        }

        private void GenericModel_Load(object sender, EventArgs e)
        {
            MainDataSetTableAdapters.VARIABLESTableAdapter adptVariables = new Plig.TimeSeries.Client.MainDataSetTableAdapters.VARIABLESTableAdapter();
            MainDataSet.VARIABLESDataTable tblVariables = adptVariables.GetDataBy(Program.CurrentProjectID);

            foreach (MainDataSet.VARIABLESRow var_row in tblVariables)
            {
                string name = var_row.NAME;
                int id = var_row.ID;
                string description = string.Empty;
                // Може да няма текст на описание, затова е нужно да обезопасим блока
                if (!var_row.IsDESCRIPTIONNull()) description = var_row.DESCRIPTION;
                ListViewItem lvi = new ListViewItem(new string[] {name, description, id.ToString()});
                lvVariables.Items.Add(lvi);
            }

            OnLoad();
        }

        private void btnAddDependent_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lvVariables.SelectedItems)
            {
                lvVariables.Items.Remove(lvi);
                lvDependentVar.Items.Add(lvi);
            }
        }

        protected void ResetSelection()
        {
            foreach (ListViewItem lvi in lvDependentVar.Items)
            {
                lvDependentVar.Items.Remove(lvi);
                lvVariables.Items.Add(lvi);
            }

            foreach (ListViewItem lvi in lvIndependentVar.Items)
            {
                lvIndependentVar.Items.Remove(lvi);
                lvVariables.Items.Add(lvi);
            }               

        }

        protected void AddVarToDep(int aVariableID)
        {
            foreach (ListViewItem lvi in lvVariables.Items)
            {
                if (aVariableID == Convert.ToInt32(lvi.SubItems[2].Text))
                {
                    lvVariables.Items.Remove(lvi);
                    lvDependentVar.Items.Add(lvi);
                    return;
                }
            }
        }

        protected void AddVarToInDep(int aVariableID)
        {
            foreach (ListViewItem lvi in lvVariables.Items)
            {
                if (aVariableID == Convert.ToInt32(lvi.SubItems[2].Text))
                {
                    lvVariables.Items.Remove(lvi);
                    lvIndependentVar.Items.Add(lvi);
                    return;
                }
            }
        }


        private void btnAddIndependent_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lvVariables.SelectedItems)
            {
                lvVariables.Items.Remove(lvi);
                lvIndependentVar.Items.Add(lvi);
            }
        }

        private void btnRemoveDependent_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lvDependentVar.SelectedItems)
            {
                lvDependentVar.Items.Remove(lvi);
                lvVariables.Items.Add(lvi);
            }

        }

        private void btnRemoveIndependent_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lvIndependentVar.SelectedItems)
            {
                lvIndependentVar.Items.Remove(lvi);
                lvVariables.Items.Add(lvi);
            }

        }

        private void tabParameters_Paint(object sender, PaintEventArgs e)
        {

        }

        protected virtual void FillAutomatedFields()
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            CalculateExtractInformation();
            FillAutomatedFields();
        }

        protected virtual void StartTraining(bool aIsRunning)
        {
            throw new NotImplementedException();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            mIsRunning = !mIsRunning;
            if (mIsRunning)
            {
                btnStart.ImageIndex = 1;
                btnStart.Text = "Спри";
            }
            else
            {
                btnStart.ImageIndex = 0;
                btnStart.Text = "Старт";
            }
            StartTraining(mIsRunning);
        }

        private void tabParameters_Enter(object sender, EventArgs e)
        {
            CalculateExtractInformation();
        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            tcResults.SelectedTab = tabGraph;
        }

        private void btnResiduals_Click(object sender, EventArgs e)
        {
            tcResults.SelectedTab = tabResiudals;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            tcResults.SelectedTab = tabTests;
        }

        private void btnSensitivity_Click(object sender, EventArgs e)
        {
            tcResults.SelectedTab = tabSensitivity;
        }

        protected virtual void TabChanged(int aTab)
        {
            // Този метод трябва да се наследи, ако наследената форма иска да използва това поведение
        }

        private void tabModel_SelectedTabChanged(object sender, Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs e)
        {
            TabChanged(e.Tab.Index);
        }

        protected virtual IModelStorage ConstructModel()
        {
            throw new NotImplementedException();
//            return (IModelStorage)(new Object());
        }
    
        protected virtual void SaveModel(string aDescription)
        {

            IModelStorage model = ConstructModel();
            // Трябва да извлечем сериализирания обект
            // Запазване в базата данни към текущия проект и за текущия модел
            System.IO.MemoryStream ms = new System.IO.MemoryStream();

            BinaryFormatter bformatter = new BinaryFormatter();

            bformatter.Serialize(ms, model);
            byte[] serialized_model = ms.GetBuffer();

            MainDataSetTableAdapters.MODELTableAdapter adptModel = new Plig.TimeSeries.Client.MainDataSetTableAdapters.MODELTableAdapter();
            adptModel.Insert(mPROJECT_ID, serialized_model, aDescription, mTypeOfModel);
        }

        protected virtual void LoadModel(int aModelID)
        {
            MainDataSetTableAdapters.MODELTableAdapter adptModel = new Plig.TimeSeries.Client.MainDataSetTableAdapters.MODELTableAdapter();
            MainDataSet.MODELDataTable tblModel = adptModel.GetDataByID(aModelID);
            MainDataSet.MODELRow model_row = (MainDataSet.MODELRow)tblModel.Rows[0];

            System.IO.MemoryStream ms = new System.IO.MemoryStream(model_row.DATA);
            BinaryFormatter bformatter = new BinaryFormatter();
            IModelStorage model = (IModelStorage)bformatter.Deserialize(ms);
            ProcessModel(model);
        }

        protected virtual void ProcessModel(IModelStorage model)
        {
            throw new NotImplementedException();
        }

        private void miModelSave_Click(object sender, EventArgs e)
        {
            SaveModelDialog dlgSaveModel = new SaveModelDialog();
            if (DialogResult.OK == dlgSaveModel.ShowDialog())
            {
                SaveModel(dlgSaveModel.Description);
            }
        }

        private void miModelLoad_Click(object sender, EventArgs e)
        {
            LoadModelForm dlgLoadModel = new LoadModelForm(mPROJECT_ID, mTypeOfModel);
            if (DialogResult.OK == dlgLoadModel.ShowDialog())
            {
                LoadModel(dlgLoadModel.SelectedModel);
            }
        }
    }

    [Serializable]
    public class SeriaInformation
    {
        private double mMean;
        private double mMin;
        private double mMax;
        private double mVariance;
        Dictionary<int, double?> mValues;

        public Dictionary<int, double?> Values
        {
            get { return mValues; }
            set { mValues = value; }
        }

        public double?[] SortedValues()
        {
            double?[] sorted_array = new double?[mValues.Count];
            int cnt = 0;
            foreach (double? d in mValues.Values)
            {
                sorted_array[cnt] = d;
                cnt++;
            }

            Array.Sort(sorted_array);

            return sorted_array;
        }

        public double Mean
        {
            get { return mMean; }
            set { mMean = value; }
        }

        public double Min
        {
            get { return mMin; }
            set { mMin = value; }
        }

        public double Max
        {
            get { return mMax; }
            set { mMax = value; }
        }

        public double Variance
        {
            get { return mVariance; }
            set { mVariance = value; }
        }

        public SeriaInformation(double?[] aData)
        {
            mMin = Double.MaxValue;
            mMax = Double.MinValue;

            double Sum = 0.0;
            int cnt = 0;
            
            for (int i = 0; i < aData.Length; i++)
            {
                if (aData[i].HasValue)
                {
                    if (mMin > aData[i]) mMin = aData[i].Value;
                    if (mMax < aData[i]) mMax = aData[i].Value;
                    Sum += aData[i].Value;
                    cnt++;
                }
            }
            Mean = Sum / cnt;
        }

    }
}
