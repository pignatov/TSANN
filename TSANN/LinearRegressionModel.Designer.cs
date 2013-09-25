namespace Plig.TimeSeries.Client
{
    partial class LinearRegressionModel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LinearRegressionModel));
            this.MulLinReg = new Dew.Stats.TMtxMulLinReg(this.components);
            this.chartResiduals = new Steema.TeeChart.TChart();
            this.bar1 = new Steema.TeeChart.Styles.Bar();
            this.fittedChart = new Steema.TeeChart.TChart();
            this.btnResult = new System.Windows.Forms.Button();
            this.txtResults = new System.Windows.Forms.RichTextBox();
            this.pnlResultsClient.SuspendLayout();
            this.tcResults.SuspendLayout();
            this.tabResiudals.SuspendLayout();
            this.tabTests.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlModelSpecificParameters
            // 
            this.pnlModelSpecificParameters.Size = new System.Drawing.Size(773, 238);
            // 
            // pnlTrainingMain
            // 
            this.pnlTrainingMain.Size = new System.Drawing.Size(773, 268);
            // 
            // pnlResultsClient
            // 
            this.pnlResultsClient.Controls.Add(this.btnResult);
            this.pnlResultsClient.Controls.Add(this.fittedChart);
            this.pnlResultsClient.Size = new System.Drawing.Size(759, 237);
            // 
            // tcResults
            // 
            this.tcResults.Size = new System.Drawing.Size(773, 269);
            // 
            // tabResiudals
            // 
            this.tabResiudals.Controls.Add(this.chartResiduals);
            this.tabResiudals.Size = new System.Drawing.Size(765, 243);
            // 
            // tabTests
            // 
            this.tabTests.Controls.Add(this.txtResults);
            this.tabTests.Size = new System.Drawing.Size(765, 243);
            // 
            // tabSensitivity
            // 
            this.tabSensitivity.Size = new System.Drawing.Size(765, 243);
            // 
            // pnlForecastMain
            // 
            this.pnlForecastMain.Size = new System.Drawing.Size(771, 267);
            // 
            // MulLinReg
            // 
            this.MulLinReg.AutoUpdate = false;
            this.MulLinReg.BlockAssign = false;
            this.MulLinReg.Dirty = false;
            this.MulLinReg.Name = null;
            // 
            // chartResiduals
            // 
            // 
            // 
            // 
            this.chartResiduals.Aspect.ElevationFloat = 345;
            this.chartResiduals.Aspect.RotationFloat = 345;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chartResiduals.Axes.Bottom.Automatic = true;
            // 
            // 
            // 
            this.chartResiduals.Axes.Bottom.Grid.ZPosition = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.chartResiduals.Axes.Bottom.Labels.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.chartResiduals.Axes.Bottom.Labels.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.chartResiduals.Axes.Bottom.Title.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.chartResiduals.Axes.Bottom.Title.Shadow.Visible = false;
            // 
            // 
            // 
            this.chartResiduals.Axes.Depth.Automatic = true;
            // 
            // 
            // 
            this.chartResiduals.Axes.Depth.Grid.ZPosition = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.chartResiduals.Axes.Depth.Labels.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.chartResiduals.Axes.Depth.Labels.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.chartResiduals.Axes.Depth.Title.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.chartResiduals.Axes.Depth.Title.Shadow.Visible = false;
            // 
            // 
            // 
            this.chartResiduals.Axes.DepthTop.Automatic = true;
            // 
            // 
            // 
            this.chartResiduals.Axes.DepthTop.Grid.ZPosition = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.chartResiduals.Axes.DepthTop.Labels.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.chartResiduals.Axes.DepthTop.Labels.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.chartResiduals.Axes.DepthTop.Title.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.chartResiduals.Axes.DepthTop.Title.Shadow.Visible = false;
            // 
            // 
            // 
            this.chartResiduals.Axes.Left.Automatic = true;
            // 
            // 
            // 
            this.chartResiduals.Axes.Left.Grid.ZPosition = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.chartResiduals.Axes.Left.Labels.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.chartResiduals.Axes.Left.Labels.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.chartResiduals.Axes.Left.Title.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.chartResiduals.Axes.Left.Title.Shadow.Visible = false;
            // 
            // 
            // 
            this.chartResiduals.Axes.Right.Automatic = true;
            // 
            // 
            // 
            this.chartResiduals.Axes.Right.Grid.ZPosition = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.chartResiduals.Axes.Right.Labels.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.chartResiduals.Axes.Right.Labels.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.chartResiduals.Axes.Right.Title.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.chartResiduals.Axes.Right.Title.Shadow.Visible = false;
            // 
            // 
            // 
            this.chartResiduals.Axes.Top.Automatic = true;
            // 
            // 
            // 
            this.chartResiduals.Axes.Top.Grid.ZPosition = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.chartResiduals.Axes.Top.Labels.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.chartResiduals.Axes.Top.Labels.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.chartResiduals.Axes.Top.Title.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.chartResiduals.Axes.Top.Title.Shadow.Visible = false;
            this.chartResiduals.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.chartResiduals.Footer.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.chartResiduals.Footer.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.chartResiduals.Header.Font.Shadow.Visible = false;
            this.chartResiduals.Header.Lines = new string[] {
        "TeeChart"};
            // 
            // 
            // 
            this.chartResiduals.Header.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.chartResiduals.Legend.Font.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chartResiduals.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            this.chartResiduals.Legend.Title.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.chartResiduals.Legend.Title.Pen.Visible = false;
            // 
            // 
            // 
            this.chartResiduals.Legend.Title.Shadow.Visible = false;
            this.chartResiduals.Location = new System.Drawing.Point(19, 18);
            this.chartResiduals.Name = "chartResiduals";
            // 
            // 
            // 
            // 
            // 
            // 
            this.chartResiduals.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.chartResiduals.Panel.Shadow.Visible = false;
            this.chartResiduals.Series.Add(this.bar1);
            this.chartResiduals.Size = new System.Drawing.Size(400, 250);
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.chartResiduals.SubFooter.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.chartResiduals.SubFooter.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.chartResiduals.SubHeader.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.chartResiduals.SubHeader.Shadow.Visible = false;
            this.chartResiduals.TabIndex = 1;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chartResiduals.Walls.Back.AutoHide = false;
            // 
            // 
            // 
            this.chartResiduals.Walls.Back.Shadow.Visible = false;
            // 
            // 
            // 
            this.chartResiduals.Walls.Bottom.AutoHide = false;
            // 
            // 
            // 
            this.chartResiduals.Walls.Bottom.Shadow.Visible = false;
            // 
            // 
            // 
            this.chartResiduals.Walls.Left.AutoHide = false;
            // 
            // 
            // 
            this.chartResiduals.Walls.Left.Shadow.Visible = false;
            // 
            // 
            // 
            this.chartResiduals.Walls.Right.AutoHide = false;
            // 
            // 
            // 
            this.chartResiduals.Walls.Right.Shadow.Visible = false;
            // 
            // bar1
            // 
            this.bar1.BarWidthPercent = 100;
            // 
            // 
            // 
            this.bar1.Brush.Color = System.Drawing.Color.Red;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bar1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.bar1.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.bar1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.bar1.Marks.Callout.Distance = 0;
            this.bar1.Marks.Callout.Draw3D = false;
            this.bar1.Marks.Callout.Length = 20;
            this.bar1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bar1.Marks.Font.Shadow.Visible = false;
            this.bar1.Marks.Visible = false;
            // 
            // 
            // 
            this.bar1.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bar1.Title = "bar1";
            // 
            // 
            // 
            this.bar1.XValues.DataMember = "X";
            this.bar1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.bar1.YValues.DataMember = "Bar";
            // 
            // fittedChart
            // 
            // 
            // 
            // 
            this.fittedChart.Aspect.ElevationFloat = 345;
            this.fittedChart.Aspect.RotationFloat = 345;
            this.fittedChart.Aspect.View3D = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.fittedChart.Axes.Bottom.Automatic = true;
            // 
            // 
            // 
            this.fittedChart.Axes.Bottom.Grid.ZPosition = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.fittedChart.Axes.Bottom.Labels.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.fittedChart.Axes.Bottom.Labels.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.fittedChart.Axes.Bottom.Title.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.fittedChart.Axes.Bottom.Title.Shadow.Visible = false;
            // 
            // 
            // 
            this.fittedChart.Axes.Depth.Automatic = true;
            // 
            // 
            // 
            this.fittedChart.Axes.Depth.Grid.ZPosition = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.fittedChart.Axes.Depth.Labels.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.fittedChart.Axes.Depth.Labels.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.fittedChart.Axes.Depth.Title.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.fittedChart.Axes.Depth.Title.Shadow.Visible = false;
            // 
            // 
            // 
            this.fittedChart.Axes.DepthTop.Automatic = true;
            // 
            // 
            // 
            this.fittedChart.Axes.DepthTop.Grid.ZPosition = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.fittedChart.Axes.DepthTop.Labels.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.fittedChart.Axes.DepthTop.Labels.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.fittedChart.Axes.DepthTop.Title.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.fittedChart.Axes.DepthTop.Title.Shadow.Visible = false;
            // 
            // 
            // 
            this.fittedChart.Axes.Left.Automatic = true;
            // 
            // 
            // 
            this.fittedChart.Axes.Left.Grid.ZPosition = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.fittedChart.Axes.Left.Labels.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.fittedChart.Axes.Left.Labels.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.fittedChart.Axes.Left.Title.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.fittedChart.Axes.Left.Title.Shadow.Visible = false;
            // 
            // 
            // 
            this.fittedChart.Axes.Right.Automatic = true;
            // 
            // 
            // 
            this.fittedChart.Axes.Right.Grid.ZPosition = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.fittedChart.Axes.Right.Labels.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.fittedChart.Axes.Right.Labels.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.fittedChart.Axes.Right.Title.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.fittedChart.Axes.Right.Title.Shadow.Visible = false;
            // 
            // 
            // 
            this.fittedChart.Axes.Top.Automatic = true;
            // 
            // 
            // 
            this.fittedChart.Axes.Top.Grid.ZPosition = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.fittedChart.Axes.Top.Labels.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.fittedChart.Axes.Top.Labels.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.fittedChart.Axes.Top.Title.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.fittedChart.Axes.Top.Title.Shadow.Visible = false;
            this.fittedChart.BackColor = System.Drawing.Color.Transparent;
            this.fittedChart.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.fittedChart.Footer.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.fittedChart.Footer.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.fittedChart.Header.Font.Shadow.Visible = false;
            this.fittedChart.Header.Lines = new string[] {
        "Прогнозирани и реални стойности"};
            // 
            // 
            // 
            this.fittedChart.Header.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.fittedChart.Legend.Font.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.fittedChart.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            this.fittedChart.Legend.Title.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.fittedChart.Legend.Title.Pen.Visible = false;
            // 
            // 
            // 
            this.fittedChart.Legend.Title.Shadow.Visible = false;
            this.fittedChart.Location = new System.Drawing.Point(0, 0);
            this.fittedChart.Name = "fittedChart";
            // 
            // 
            // 
            // 
            // 
            // 
            this.fittedChart.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.fittedChart.Panel.Shadow.Visible = false;
            this.fittedChart.Size = new System.Drawing.Size(759, 237);
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.fittedChart.SubFooter.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.fittedChart.SubFooter.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.fittedChart.SubHeader.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.fittedChart.SubHeader.Shadow.Visible = false;
            this.fittedChart.TabIndex = 4;
            // 
            // 
            // 
            // 
            // 
            // 
            this.fittedChart.Walls.Back.AutoHide = false;
            // 
            // 
            // 
            this.fittedChart.Walls.Back.Shadow.Visible = false;
            // 
            // 
            // 
            this.fittedChart.Walls.Bottom.AutoHide = false;
            // 
            // 
            // 
            this.fittedChart.Walls.Bottom.Shadow.Visible = false;
            // 
            // 
            // 
            this.fittedChart.Walls.Left.AutoHide = false;
            // 
            // 
            // 
            this.fittedChart.Walls.Left.Shadow.Visible = false;
            // 
            // 
            // 
            this.fittedChart.Walls.Right.AutoHide = false;
            // 
            // 
            // 
            this.fittedChart.Walls.Right.Shadow.Visible = false;
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(29, 3);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(75, 23);
            this.btnResult.TabIndex = 5;
            this.btnResult.Text = "Резултат";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // txtResults
            // 
            this.txtResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResults.Location = new System.Drawing.Point(3, 3);
            this.txtResults.Name = "txtResults";
            this.txtResults.Size = new System.Drawing.Size(759, 237);
            this.txtResults.TabIndex = 0;
            this.txtResults.Text = "";
            // 
            // LinearRegressionModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(777, 414);
            this.Name = "LinearRegressionModel";
            this.Text = "Линейна регресия";
            this.pnlResultsClient.ResumeLayout(false);
            this.tcResults.ResumeLayout(false);
            this.tabResiudals.ResumeLayout(false);
            this.tabTests.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Dew.Stats.TMtxMulLinReg MulLinReg;
        private Steema.TeeChart.TChart chartResiduals;
        private Steema.TeeChart.Styles.Bar bar1;
        private Steema.TeeChart.TChart fittedChart;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.RichTextBox txtResults;
    }
}
