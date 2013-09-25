using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Dew.Math;
using Dew.Math.Units;
using Dew.Math.Editors;
using Dew.Math.Tee;
using System.IO;

namespace Plig.TimeSeries.Client
{
    public partial class DataForm : Form
    {
        public DataForm()
        {
            InitializeComponent();
        }

        private void vARIABLESBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vARIABLESBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mainDataSet);

        }

        private void DataForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mainDataSet.OBSERVATIONS' table. You can move, or remove it, as needed.
            this.oBSERVATIONSTableAdapter.Fill(this.mainDataSet.OBSERVATIONS);
            // TODO: This line of code loads data into the 'mainDataSet.VARIABLES' table. You can move, or remove it, as needed.
            this.vARIABLESTableAdapter.FillBy(this.mainDataSet.VARIABLES, Program.CurrentProjectID);

        }

        private void vARIABLESBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            DataRowView drv = ((DataView)vARIABLESBindingSource.List).AddNew();
            ((MainDataSet.VARIABLESRow)drv.Row).PROJECT_ID = Program.CurrentProjectID;
            e.NewObject = drv;
        }

        private void oBSERVATIONSBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
//            DataRowView drv = ((DataView)oBSERVATIONSBindingSource.List).AddNew();
//            ((MainDataSet.OBSERVATIONSRow)drv.Row).VARIABLE_ID = (vARIABLESBindingSource.Current as MainDataSet.VARIABLESRow).ID;
//            e.NewObject = drv;
        }

        private void vARIABLESBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                TVec dy = null;
                TVec dx = null;
                variablesChart.Series.Clear();
                variablesChart.Series.Add(new Steema.TeeChart.Styles.FastLine());
                if (!((vARIABLESBindingSource.Current as DataRowView).Row as MainDataSet.VARIABLESRow).IsDESCRIPTIONNull())
                {
                    variablesChart.Header.Text = ((vARIABLESBindingSource.Current as DataRowView).Row as MainDataSet.VARIABLESRow).DESCRIPTION;
                }
                variablesChart.Axes.Left.Title.Text = "Y";
                variablesChart.Axes.Bottom.Title.Text = "";
                variablesChart.Axes.Left.Automatic = true;
                MainDataSet.OBSERVATIONSDataTable tblObservations = oBSERVATIONSTableAdapter.GetDataByVariable(((vARIABLESBindingSource.Current as DataRowView).Row as MainDataSet.VARIABLESRow).ID);

                Vector timeseries = new Vector(tblObservations.Rows.Count);
                Vector abs = new Vector(tblObservations.Rows.Count);
                
                int cnt = 0;
                foreach (DataRow drv in tblObservations.Rows)
                {
                    try
                    {
                        timeseries.Values[cnt] = (drv as MainDataSet.OBSERVATIONSRow).VALUE;
                    }
                    catch
                    {
                        timeseries.Values[cnt] = 0.0;
                    }
                    abs.Values[cnt] = (drv as MainDataSet.OBSERVATIONSRow).COUNTER ;
                    cnt++;
                }

                dy = timeseries;
                dx = abs;
                Dew.Math.Tee.TeeChart.DrawValues(dx, dy, variablesChart.Series[0], false);

                string FmtString = "0.0000";
                double sd = timeseries.StdDev();
                string st = "";
                st = "size:\t" + timeseries.Length.ToString() + "\r\n";
                st += "mean:\t" + Math387.FormatSample(FmtString, timeseries.Mean()) + "\r\n";
                st += "std.dev:\t" + Math387.FormatSample(FmtString, sd) + "\r\n";
                st += "variance:\t" + Math387.FormatSample(FmtString, sd * sd) + "\r\n";
                txtSeriesStats.Text = st;
            }
            catch { };
        }

        private void miDataLoadFromFile_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == dlgOpenData.ShowDialog())
            {
                string filename = dlgOpenData.FileName;
                string[] lines = File.ReadAllLines(filename);
                Dictionary<int, double> observations = new Dictionary<int, double>();

                int count = 1;
                foreach (string line in lines)
                {
                    string[] singleObservation = line.Split(' ');
                    if (singleObservation.Length > 1)
                    {
                        // Имаме и номер на наблюдението
                        int index = Convert.ToInt32(singleObservation[0]);
                        double value = Convert.ToDouble(singleObservation[1]);
                        observations.Add(index, value);
                    }
                    else
                    {
                        // Имаме само данни
                        double value = Convert.ToDouble(singleObservation[0]);
                        observations.Add(count, value);
                        count++;
                    }

                }

                // В observations са се натрупали всички наблюдения
                // Трябва да ги добавим към стойностите за съответната променлива
                int variables_id = ((vARIABLESBindingSource.Current as DataRowView).Row as MainDataSet.VARIABLESRow).ID;

                MainDataSet.OBSERVATIONSDataTable tblObservations = oBSERVATIONSTableAdapter.GetDataByVariable(variables_id);
                foreach (int key in observations.Keys)
                {
                    MainDataSet.OBSERVATIONSRow obsRow = tblObservations.NewOBSERVATIONSRow();
                    obsRow.COUNTER = key;
                    obsRow.VALUE = observations[key];
                    obsRow.VARIABLE_ID = variables_id;
                    tblObservations.AddOBSERVATIONSRow(obsRow);
                }

                oBSERVATIONSTableAdapter.Update(tblObservations);
                this.tableAdapterManager.UpdateAll(this.mainDataSet);

                // Опресняване на данните
                this.oBSERVATIONSTableAdapter.Fill(this.mainDataSet.OBSERVATIONS);
                this.vARIABLESTableAdapter.FillBy(this.mainDataSet.VARIABLES, Program.CurrentProjectID);
                this.vARIABLESBindingSource.Position = this.vARIABLESBindingSource.Find("ID", variables_id);

                
            }
        }

        private void miTransformDifferenciation_Click(object sender, EventArgs e)
        {
            VariableDiff var_diff = new VariableDiff();
            ProcessTransformation(var_diff);
        }

        private void ProcessTransformation(VariableMod var_diff)
        {
            int variables_id = ((vARIABLESBindingSource.Current as DataRowView).Row as MainDataSet.VARIABLESRow).ID;
            int new_variable_id = 0;
            var_diff.VariableName = ((vARIABLESBindingSource.Current as DataRowView).Row as MainDataSet.VARIABLESRow).NAME;

            string var_description;
            try
            {
               var_description = ((vARIABLESBindingSource.Current as DataRowView).Row as MainDataSet.VARIABLESRow).DESCRIPTION;
            }
            catch
            {
                var_description = string.Empty;
            }

            MainDataSet.OBSERVATIONSDataTable tblObservations = oBSERVATIONSTableAdapter.GetDataByVariable(variables_id);
            Dictionary<int, double?> data = new Dictionary<int, double?>();

            foreach (MainDataSet.OBSERVATIONSRow obsRow in tblObservations)
            {
                if (!obsRow.IsVALUENull())
                    data.Add(obsRow.COUNTER, obsRow.VALUE);
                else
                    data.Add(obsRow.COUNTER, null);
            }

            var_diff.VariableData = data;

            if (var_diff.ShowDialog() == DialogResult.OK)
            {
                MainDataSet.VARIABLESDataTable tblVariables = vARIABLESTableAdapter.GetDataBy(Program.CurrentProjectID);
                MainDataSet.VARIABLESRow variables_row = tblVariables.NewVARIABLESRow();
                variables_row.PROJECT_ID = Program.CurrentProjectID;
                variables_row.NAME = var_diff.NewVariableName;
                variables_row.DESCRIPTION = var_diff.TransformationDescription() + " " + var_description;
                tblVariables.AddVARIABLESRow(variables_row);
                vARIABLESTableAdapter.Update(tblVariables);
                new_variable_id = variables_row.ID;

                foreach (int key in var_diff.NewVariableData.Keys)
                {
                    MainDataSet.OBSERVATIONSRow obsRow = tblObservations.NewOBSERVATIONSRow();
                    obsRow.VARIABLE_ID = variables_row.ID;
                    obsRow.COUNTER = key;
                    if (var_diff.NewVariableData[key].HasValue)
                        obsRow.VALUE = var_diff.NewVariableData[key].Value;
                    tblObservations.AddOBSERVATIONSRow(obsRow);
                }

                oBSERVATIONSTableAdapter.Update(tblObservations);
            }

            
            // Опресняване на данните
            this.oBSERVATIONSTableAdapter.Fill(this.mainDataSet.OBSERVATIONS);
            this.vARIABLESTableAdapter.FillBy(this.mainDataSet.VARIABLES, Program.CurrentProjectID);
            this.vARIABLESBindingSource.Position = this.vARIABLESBindingSource.Find("ID", new_variable_id);

        }

        private void miTransformRelativeDiff_Click(object sender, EventArgs e)
        {
            VariableRelativeDiff var_diff = new VariableRelativeDiff();
            ProcessTransformation(var_diff);
        }

        private void miTransformLag_Click(object sender, EventArgs e)
        {
            VariableLag varLag = new VariableLag();
            ProcessTransformation(varLag);
        }
    }
}
