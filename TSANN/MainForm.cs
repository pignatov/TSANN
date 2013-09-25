using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Plig.TimeSeries.Client
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void miFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void miHelpAbout_Click(object sender, EventArgs e)
        {
            AboutBox about_box = new AboutBox();
            about_box.ShowDialog();
        }

        private void miFileNewProject_Click(object sender, EventArgs e)
        {
            ProjectForm new_project_form = new ProjectForm();
            new_project_form.ShowDialog();
        }

        private void miFileLoadProject_Click(object sender, EventArgs e)
        {
            ChooseProject choose_project = new ChooseProject();
            if (DialogResult.OK == choose_project.ShowDialog())
            {
                MainDataSetTableAdapters.PROJECTTableAdapter adptProject = new Plig.TimeSeries.Client.MainDataSetTableAdapters.PROJECTTableAdapter();
                statusProjectName.Text = adptProject.GetName(Program.CurrentProjectID);
            }
        }

        private void miNeuralNetworkPlain_Click(object sender, EventArgs e)
        {
            PlainNeuralNetworkModel plain_model = new PlainNeuralNetworkModel();
            plain_model.PROJECT_ID = Program.CurrentProjectID;
            plain_model.MdiParent = this;
            plain_model.Show();
        }

        private void miRegressionLinear_Click(object sender, EventArgs e)
        {
            LinearRegressionModel linear_regression_model = new LinearRegressionModel();
            linear_regression_model.MdiParent = this;
            linear_regression_model.Show();
        }

        private void miWindowCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void miTileHorizontally_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void miTileVertically_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void miProjectData_Click(object sender, EventArgs e)
        {
            DataForm data_form = new DataForm();
            data_form.MdiParent = this;
            data_form.Show();
        }

        private void miSettings_Click(object sender, EventArgs e)
        {
            SettingsForm settings = new SettingsForm();
            settings.ShowDialog();
        }
    }
}
