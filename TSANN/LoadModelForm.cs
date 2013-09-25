using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Plig.TimeSeries.Client
{
    public partial class LoadModelForm : Form
    {
        public LoadModelForm(int aProjectID, int aTypeOfModel)
        {
            InitializeComponent();
            MainDataSetTableAdapters.MODELTableAdapter adptModel = new Plig.TimeSeries.Client.MainDataSetTableAdapters.MODELTableAdapter();
            MainDataSet.MODELDataTable tblModel = adptModel.GetDataBy(aProjectID, aTypeOfModel);
            grdMain.DataSource = tblModel.DefaultView.ToTable(false, "ID", "DESCRIPTION");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public static DataRow CurrentRow(DataGridView aGrid)
        {
            CurrencyManager xCM =
              (CurrencyManager)aGrid.BindingContext[aGrid.DataSource, aGrid.DataMember];
            DataRowView xDRV = (DataRowView)xCM.Current;
            return xDRV.Row;
        }

        public int SelectedModel
        {
            get { return (int)(CurrentRow(grdMain))["ID"]; }
        }  
    }
}
