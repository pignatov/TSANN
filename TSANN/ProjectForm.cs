using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Plig.TimeSeries.Client
{
    public partial class ProjectForm : Form
    {
        public ProjectForm()
        {
            InitializeComponent();
        }

        private void ProjectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mainDataSet.FREQUENCY' table. You can move, or remove it, as needed.
            this.fREQUENCYTableAdapter.Fill(this.mainDataSet.FREQUENCY);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MainDataSetTableAdapters.PROJECTTableAdapter adptProject = new Plig.TimeSeries.Client.MainDataSetTableAdapters.PROJECTTableAdapter();
            MainDataSet.PROJECTDataTable tblProject = adptProject.GetData();
            MainDataSet.PROJECTRow project_row = tblProject.NewPROJECTRow();
            project_row.FREQUENCY_ID = (int)cmbFrequency.SelectedValue;
            project_row.NAME = txtName.Text;
            project_row.DESCRIPTION = txtDescription.Text;
            tblProject.AddPROJECTRow(project_row);

            adptProject.Update(tblProject);
            Program.CurrentProjectID = project_row.ID;
            this.Close();
        }
    }
}
