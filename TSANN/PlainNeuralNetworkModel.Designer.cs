namespace Plig.TimeSeries.Client
{
    partial class PlainNeuralNetworkModel
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
            this.ultraLabel4 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel5 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel6 = new Infragistics.Win.Misc.UltraLabel();
            this.txtEpochs = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtReinitializations = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtHiddenNeurons = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.lbResults = new System.Windows.Forms.ListBox();
            this.pbProgressTraining = new System.Windows.Forms.ProgressBar();
            this.trainingChart = new Steema.TeeChart.TChart();
            this.fittedChart = new Steema.TeeChart.TChart();
            this.button1 = new System.Windows.Forms.Button();
            this.lvVariablesSensitivity = new System.Windows.Forms.ListView();
            this.colName = new System.Windows.Forms.ColumnHeader();
            this.SensitivityChart = new Steema.TeeChart.TChart();
            this.btnSensitivityAnalysisReload = new System.Windows.Forms.Button();
            this.chartResiduals = new Steema.TeeChart.TChart();
            this.bar1 = new Steema.TeeChart.Styles.Bar();
            this.fastLine1 = new Steema.TeeChart.Styles.FastLine();
            this.gbHiddenNeurons = new System.Windows.Forms.GroupBox();
            this.pnlFlexibleHiddenNeurons = new System.Windows.Forms.Panel();
            this.txtMaxHiddenNeurons = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtMinHiddenNeurons = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.pnlFixedHiddenNeurons = new System.Windows.Forms.Panel();
            this.pnlRadioCountNeurons = new System.Windows.Forms.Panel();
            this.rbFlexibleHiddenNeurons = new System.Windows.Forms.RadioButton();
            this.rbFixedHiddenNeurons = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMomentum = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtLearningRate = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraLabel7 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel8 = new Infragistics.Win.Misc.UltraLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbGenetic = new System.Windows.Forms.RadioButton();
            this.rbBestTestNetwork = new System.Windows.Forms.RadioButton();
            this.rbBestNetwork = new System.Windows.Forms.RadioButton();
            this.rchTests = new System.Windows.Forms.RichTextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnForecast = new System.Windows.Forms.Button();
            this.grdForecastDep = new System.Windows.Forms.DataGridView();
            this.grdForecastInDep = new System.Windows.Forms.DataGridView();
            this.pnlSensitivityParams = new System.Windows.Forms.Panel();
            this.btnShowSensVar = new System.Windows.Forms.Button();
            this.grdSensitivityVars = new System.Windows.Forms.DataGridView();
            this.pbGeneticProgress = new System.Windows.Forms.ProgressBar();
            this.gbGeneticParameters = new System.Windows.Forms.GroupBox();
            this.txtPopulationCount = new System.Windows.Forms.TextBox();
            this.txtGeneticEpochs = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlModelSpecificParameters.SuspendLayout();
            this.pnlTrainingMain.SuspendLayout();
            this.pnlResultsClient.SuspendLayout();
            this.tcResults.SuspendLayout();
            this.tabResiudals.SuspendLayout();
            this.tabTests.SuspendLayout();
            this.tabSensitivity.SuspendLayout();
            this.pnlForecastMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEpochs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReinitializations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHiddenNeurons)).BeginInit();
            this.gbHiddenNeurons.SuspendLayout();
            this.pnlFlexibleHiddenNeurons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxHiddenNeurons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinHiddenNeurons)).BeginInit();
            this.pnlFixedHiddenNeurons.SuspendLayout();
            this.pnlRadioCountNeurons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMomentum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLearningRate)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdForecastDep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdForecastInDep)).BeginInit();
            this.pnlSensitivityParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSensitivityVars)).BeginInit();
            this.gbGeneticParameters.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlModelSpecificParameters
            // 
            this.pnlModelSpecificParameters.Controls.Add(this.gbGeneticParameters);
            this.pnlModelSpecificParameters.Controls.Add(this.groupBox1);
            this.pnlModelSpecificParameters.Size = new System.Drawing.Size(773, 462);
            // 
            // pnlTrainingMain
            // 
            this.pnlTrainingMain.Controls.Add(this.pbGeneticProgress);
            this.pnlTrainingMain.Controls.Add(this.trainingChart);
            this.pnlTrainingMain.Controls.Add(this.pbProgressTraining);
            this.pnlTrainingMain.Controls.Add(this.lbResults);
            this.pnlTrainingMain.Size = new System.Drawing.Size(773, 492);
            // 
            // pnlResultsClient
            // 
            this.pnlResultsClient.Controls.Add(this.panel1);
            this.pnlResultsClient.Controls.Add(this.button1);
            this.pnlResultsClient.Controls.Add(this.fittedChart);
            this.pnlResultsClient.Size = new System.Drawing.Size(759, 237);
            // 
            // tabResiudals
            // 
            this.tabResiudals.Controls.Add(this.chartResiduals);
            this.tabResiudals.Size = new System.Drawing.Size(765, 243);
            // 
            // tabTests
            // 
            this.tabTests.Controls.Add(this.rchTests);
            this.tabTests.Size = new System.Drawing.Size(765, 243);
            // 
            // tabSensitivity
            // 
            this.tabSensitivity.Controls.Add(this.SensitivityChart);
            this.tabSensitivity.Controls.Add(this.pnlSensitivityParams);
            this.tabSensitivity.Size = new System.Drawing.Size(765, 243);
            // 
            // pnlForecastMain
            // 
            this.pnlForecastMain.Controls.Add(this.btnForecast);
            this.pnlForecastMain.Controls.Add(this.grdForecastDep);
            this.pnlForecastMain.Controls.Add(this.grdForecastInDep);
            // 
            // ultraLabel4
            // 
            this.ultraLabel4.Location = new System.Drawing.Point(7, 21);
            this.ultraLabel4.Name = "ultraLabel4";
            this.ultraLabel4.Size = new System.Drawing.Size(100, 13);
            this.ultraLabel4.TabIndex = 0;
            this.ultraLabel4.Text = "Брой епохи:";
            // 
            // ultraLabel5
            // 
            this.ultraLabel5.Location = new System.Drawing.Point(7, 51);
            this.ultraLabel5.Name = "ultraLabel5";
            this.ultraLabel5.Size = new System.Drawing.Size(117, 23);
            this.ultraLabel5.TabIndex = 1;
            this.ultraLabel5.Text = "Преинициализация:";
            // 
            // ultraLabel6
            // 
            this.ultraLabel6.Location = new System.Drawing.Point(15, 10);
            this.ultraLabel6.Name = "ultraLabel6";
            this.ultraLabel6.Size = new System.Drawing.Size(100, 17);
            this.ultraLabel6.TabIndex = 2;
            this.ultraLabel6.Text = "Скрити неврони:";
            // 
            // txtEpochs
            // 
            this.txtEpochs.Location = new System.Drawing.Point(130, 17);
            this.txtEpochs.Name = "txtEpochs";
            this.txtEpochs.Size = new System.Drawing.Size(64, 21);
            this.txtEpochs.TabIndex = 3;
            this.txtEpochs.Text = "1";
            // 
            // txtReinitializations
            // 
            this.txtReinitializations.Location = new System.Drawing.Point(130, 47);
            this.txtReinitializations.Name = "txtReinitializations";
            this.txtReinitializations.Size = new System.Drawing.Size(64, 21);
            this.txtReinitializations.TabIndex = 4;
            this.txtReinitializations.Text = "1";
            // 
            // txtHiddenNeurons
            // 
            this.txtHiddenNeurons.Location = new System.Drawing.Point(138, 6);
            this.txtHiddenNeurons.Name = "txtHiddenNeurons";
            this.txtHiddenNeurons.Size = new System.Drawing.Size(61, 21);
            this.txtHiddenNeurons.TabIndex = 5;
            this.txtHiddenNeurons.Text = "1";
            // 
            // lbResults
            // 
            this.lbResults.FormattingEnabled = true;
            this.lbResults.HorizontalScrollbar = true;
            this.lbResults.Location = new System.Drawing.Point(11, 33);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(267, 212);
            this.lbResults.TabIndex = 0;
            // 
            // pbProgressTraining
            // 
            this.pbProgressTraining.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pbProgressTraining.Location = new System.Drawing.Point(12, 4);
            this.pbProgressTraining.Name = "pbProgressTraining";
            this.pbProgressTraining.Size = new System.Drawing.Size(752, 23);
            this.pbProgressTraining.TabIndex = 1;
            // 
            // trainingChart
            // 
            this.trainingChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.trainingChart.Aspect.ElevationFloat = 345;
            this.trainingChart.Aspect.RotationFloat = 345;
            this.trainingChart.Aspect.View3D = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.trainingChart.Axes.Bottom.Automatic = true;
            // 
            // 
            // 
            this.trainingChart.Axes.Bottom.Grid.ZPosition = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.trainingChart.Axes.Bottom.Labels.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.trainingChart.Axes.Bottom.Labels.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.trainingChart.Axes.Bottom.Title.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.trainingChart.Axes.Bottom.Title.Shadow.Visible = false;
            // 
            // 
            // 
            this.trainingChart.Axes.Depth.Automatic = true;
            // 
            // 
            // 
            this.trainingChart.Axes.Depth.Grid.ZPosition = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.trainingChart.Axes.Depth.Labels.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.trainingChart.Axes.Depth.Labels.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.trainingChart.Axes.Depth.Title.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.trainingChart.Axes.Depth.Title.Shadow.Visible = false;
            // 
            // 
            // 
            this.trainingChart.Axes.DepthTop.Automatic = true;
            // 
            // 
            // 
            this.trainingChart.Axes.DepthTop.Grid.ZPosition = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.trainingChart.Axes.DepthTop.Labels.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.trainingChart.Axes.DepthTop.Labels.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.trainingChart.Axes.DepthTop.Title.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.trainingChart.Axes.DepthTop.Title.Shadow.Visible = false;
            // 
            // 
            // 
            this.trainingChart.Axes.Left.Automatic = true;
            // 
            // 
            // 
            this.trainingChart.Axes.Left.Grid.ZPosition = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.trainingChart.Axes.Left.Labels.Font.Shadow.Visible = false;
            this.trainingChart.Axes.Left.Labels.MultiLine = true;
            // 
            // 
            // 
            this.trainingChart.Axes.Left.Labels.Shadow.Visible = false;
            this.trainingChart.Axes.Left.Labels.ValueFormat = "#,####0.######";
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.trainingChart.Axes.Left.Title.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.trainingChart.Axes.Left.Title.Shadow.Visible = false;
            // 
            // 
            // 
            this.trainingChart.Axes.Right.Automatic = true;
            // 
            // 
            // 
            this.trainingChart.Axes.Right.Grid.ZPosition = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.trainingChart.Axes.Right.Labels.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.trainingChart.Axes.Right.Labels.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.trainingChart.Axes.Right.Title.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.trainingChart.Axes.Right.Title.Shadow.Visible = false;
            // 
            // 
            // 
            this.trainingChart.Axes.Top.Automatic = true;
            // 
            // 
            // 
            this.trainingChart.Axes.Top.Grid.ZPosition = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.trainingChart.Axes.Top.Labels.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.trainingChart.Axes.Top.Labels.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.trainingChart.Axes.Top.Title.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.trainingChart.Axes.Top.Title.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.trainingChart.Footer.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.trainingChart.Footer.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.trainingChart.Header.Font.Shadow.Visible = false;
            this.trainingChart.Header.Lines = new string[] {
        "Средно квадратична грешка"};
            // 
            // 
            // 
            this.trainingChart.Header.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.trainingChart.Legend.Font.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.trainingChart.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            this.trainingChart.Legend.Title.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.trainingChart.Legend.Title.Pen.Visible = false;
            // 
            // 
            // 
            this.trainingChart.Legend.Title.Shadow.Visible = false;
            this.trainingChart.Location = new System.Drawing.Point(284, 33);
            this.trainingChart.Name = "trainingChart";
            // 
            // 
            // 
            // 
            // 
            // 
            this.trainingChart.Panel.Shadow.Visible = false;
            this.trainingChart.Size = new System.Drawing.Size(480, 212);
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.trainingChart.SubFooter.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.trainingChart.SubFooter.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.trainingChart.SubHeader.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.trainingChart.SubHeader.Shadow.Visible = false;
            this.trainingChart.TabIndex = 2;
            // 
            // 
            // 
            // 
            // 
            // 
            this.trainingChart.Walls.Back.AutoHide = false;
            // 
            // 
            // 
            this.trainingChart.Walls.Back.Shadow.Visible = false;
            // 
            // 
            // 
            this.trainingChart.Walls.Bottom.AutoHide = false;
            // 
            // 
            // 
            this.trainingChart.Walls.Bottom.Shadow.Visible = false;
            // 
            // 
            // 
            this.trainingChart.Walls.Left.AutoHide = false;
            // 
            // 
            // 
            this.trainingChart.Walls.Left.Shadow.Visible = false;
            // 
            // 
            // 
            this.trainingChart.Walls.Right.AutoHide = false;
            // 
            // 
            // 
            this.trainingChart.Walls.Right.Shadow.Visible = false;
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
            this.fittedChart.TabIndex = 3;
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
            this.fittedChart.AfterDraw += new Steema.TeeChart.PaintChartEventHandler(this.fittedChart_AfterDraw);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Резултат";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lvVariablesSensitivity
            // 
            this.lvVariablesSensitivity.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName});
            this.lvVariablesSensitivity.FullRowSelect = true;
            this.lvVariablesSensitivity.Location = new System.Drawing.Point(14, 43);
            this.lvVariablesSensitivity.Name = "lvVariablesSensitivity";
            this.lvVariablesSensitivity.Size = new System.Drawing.Size(207, 159);
            this.lvVariablesSensitivity.TabIndex = 0;
            this.lvVariablesSensitivity.UseCompatibleStateImageBehavior = false;
            this.lvVariablesSensitivity.View = System.Windows.Forms.View.Details;
            this.lvVariablesSensitivity.SelectedIndexChanged += new System.EventHandler(this.lvVariablesSensitivity_SelectedIndexChanged);
            // 
            // colName
            // 
            this.colName.Text = "Име";
            this.colName.Width = 114;
            // 
            // SensitivityChart
            // 
            // 
            // 
            // 
            this.SensitivityChart.Aspect.ElevationFloat = 345;
            this.SensitivityChart.Aspect.RotationFloat = 345;
            this.SensitivityChart.Aspect.View3D = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SensitivityChart.Axes.Bottom.Automatic = true;
            // 
            // 
            // 
            this.SensitivityChart.Axes.Bottom.Grid.ZPosition = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.SensitivityChart.Axes.Bottom.Labels.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.SensitivityChart.Axes.Bottom.Labels.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.SensitivityChart.Axes.Bottom.Title.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.SensitivityChart.Axes.Bottom.Title.Shadow.Visible = false;
            // 
            // 
            // 
            this.SensitivityChart.Axes.Depth.Automatic = true;
            // 
            // 
            // 
            this.SensitivityChart.Axes.Depth.Grid.ZPosition = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.SensitivityChart.Axes.Depth.Labels.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.SensitivityChart.Axes.Depth.Labels.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.SensitivityChart.Axes.Depth.Title.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.SensitivityChart.Axes.Depth.Title.Shadow.Visible = false;
            // 
            // 
            // 
            this.SensitivityChart.Axes.DepthTop.Automatic = true;
            // 
            // 
            // 
            this.SensitivityChart.Axes.DepthTop.Grid.ZPosition = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.SensitivityChart.Axes.DepthTop.Labels.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.SensitivityChart.Axes.DepthTop.Labels.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.SensitivityChart.Axes.DepthTop.Title.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.SensitivityChart.Axes.DepthTop.Title.Shadow.Visible = false;
            // 
            // 
            // 
            this.SensitivityChart.Axes.Left.Automatic = true;
            // 
            // 
            // 
            this.SensitivityChart.Axes.Left.Grid.ZPosition = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.SensitivityChart.Axes.Left.Labels.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.SensitivityChart.Axes.Left.Labels.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.SensitivityChart.Axes.Left.Title.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.SensitivityChart.Axes.Left.Title.Shadow.Visible = false;
            // 
            // 
            // 
            this.SensitivityChart.Axes.Right.Automatic = true;
            // 
            // 
            // 
            this.SensitivityChart.Axes.Right.Grid.ZPosition = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.SensitivityChart.Axes.Right.Labels.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.SensitivityChart.Axes.Right.Labels.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.SensitivityChart.Axes.Right.Title.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.SensitivityChart.Axes.Right.Title.Shadow.Visible = false;
            // 
            // 
            // 
            this.SensitivityChart.Axes.Top.Automatic = true;
            // 
            // 
            // 
            this.SensitivityChart.Axes.Top.Grid.ZPosition = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.SensitivityChart.Axes.Top.Labels.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.SensitivityChart.Axes.Top.Labels.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.SensitivityChart.Axes.Top.Title.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.SensitivityChart.Axes.Top.Title.Shadow.Visible = false;
            this.SensitivityChart.BackColor = System.Drawing.Color.Transparent;
            this.SensitivityChart.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.SensitivityChart.Footer.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.SensitivityChart.Footer.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.SensitivityChart.Header.Font.Shadow.Visible = false;
            this.SensitivityChart.Header.Lines = new string[] {
        "Чувствителност на параметъра"};
            // 
            // 
            // 
            this.SensitivityChart.Header.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.SensitivityChart.Legend.Font.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SensitivityChart.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            this.SensitivityChart.Legend.Title.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.SensitivityChart.Legend.Title.Pen.Visible = false;
            // 
            // 
            // 
            this.SensitivityChart.Legend.Title.Shadow.Visible = false;
            this.SensitivityChart.Location = new System.Drawing.Point(240, 3);
            this.SensitivityChart.Name = "SensitivityChart";
            // 
            // 
            // 
            // 
            // 
            // 
            this.SensitivityChart.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.SensitivityChart.Panel.Shadow.Visible = false;
            this.SensitivityChart.Size = new System.Drawing.Size(522, 237);
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.SensitivityChart.SubFooter.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.SensitivityChart.SubFooter.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.SensitivityChart.SubHeader.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.SensitivityChart.SubHeader.Shadow.Visible = false;
            this.SensitivityChart.TabIndex = 1;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SensitivityChart.Walls.Back.AutoHide = false;
            // 
            // 
            // 
            this.SensitivityChart.Walls.Back.Shadow.Visible = false;
            // 
            // 
            // 
            this.SensitivityChart.Walls.Bottom.AutoHide = false;
            // 
            // 
            // 
            this.SensitivityChart.Walls.Bottom.Shadow.Visible = false;
            // 
            // 
            // 
            this.SensitivityChart.Walls.Left.AutoHide = false;
            // 
            // 
            // 
            this.SensitivityChart.Walls.Left.Shadow.Visible = false;
            // 
            // 
            // 
            this.SensitivityChart.Walls.Right.AutoHide = false;
            // 
            // 
            // 
            this.SensitivityChart.Walls.Right.Shadow.Visible = false;
            // 
            // btnSensitivityAnalysisReload
            // 
            this.btnSensitivityAnalysisReload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSensitivityAnalysisReload.Location = new System.Drawing.Point(14, 14);
            this.btnSensitivityAnalysisReload.Name = "btnSensitivityAnalysisReload";
            this.btnSensitivityAnalysisReload.Size = new System.Drawing.Size(207, 23);
            this.btnSensitivityAnalysisReload.TabIndex = 2;
            this.btnSensitivityAnalysisReload.Text = "Презареди";
            this.btnSensitivityAnalysisReload.UseVisualStyleBackColor = true;
            this.btnSensitivityAnalysisReload.Click += new System.EventHandler(this.btnSensitivityAnalysisReload_Click);
            // 
            // chartResiduals
            // 
            // 
            // 
            // 
            this.chartResiduals.Aspect.ElevationFloat = 345;
            this.chartResiduals.Aspect.RotationFloat = 345;
            this.chartResiduals.Aspect.View3D = false;
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
            this.chartResiduals.Axes.Right.Title.Caption = "PDF";
            // 
            // 
            // 
            // 
            // 
            // 
            this.chartResiduals.Axes.Right.Title.Font.Shadow.Visible = false;
            this.chartResiduals.Axes.Right.Title.Lines = new string[] {
        "PDF"};
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
            this.chartResiduals.Dock = System.Windows.Forms.DockStyle.Fill;
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
        "Остатъци"};
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
            this.chartResiduals.Location = new System.Drawing.Point(3, 3);
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
            this.chartResiduals.Series.Add(this.fastLine1);
            this.chartResiduals.Size = new System.Drawing.Size(759, 237);
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
            this.chartResiduals.TabIndex = 2;
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
            // fastLine1
            // 
            // 
            // 
            // 
            this.fastLine1.LinePen.Color = System.Drawing.Color.Green;
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.fastLine1.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.fastLine1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.fastLine1.Marks.Callout.Distance = 0;
            this.fastLine1.Marks.Callout.Draw3D = false;
            this.fastLine1.Marks.Callout.Length = 10;
            this.fastLine1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine1.Marks.Font.Shadow.Visible = false;
            this.fastLine1.Title = "fastLine1";
            this.fastLine1.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Right;
            // 
            // 
            // 
            this.fastLine1.XValues.DataMember = "X";
            this.fastLine1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.fastLine1.YValues.DataMember = "Y";
            // 
            // gbHiddenNeurons
            // 
            this.gbHiddenNeurons.Controls.Add(this.pnlFlexibleHiddenNeurons);
            this.gbHiddenNeurons.Controls.Add(this.pnlFixedHiddenNeurons);
            this.gbHiddenNeurons.Controls.Add(this.pnlRadioCountNeurons);
            this.gbHiddenNeurons.Location = new System.Drawing.Point(212, 19);
            this.gbHiddenNeurons.Name = "gbHiddenNeurons";
            this.gbHiddenNeurons.Size = new System.Drawing.Size(248, 159);
            this.gbHiddenNeurons.TabIndex = 7;
            this.gbHiddenNeurons.TabStop = false;
            this.gbHiddenNeurons.Text = "Брой скрити неврони";
            // 
            // pnlFlexibleHiddenNeurons
            // 
            this.pnlFlexibleHiddenNeurons.Controls.Add(this.txtMaxHiddenNeurons);
            this.pnlFlexibleHiddenNeurons.Controls.Add(this.txtMinHiddenNeurons);
            this.pnlFlexibleHiddenNeurons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFlexibleHiddenNeurons.Location = new System.Drawing.Point(3, 95);
            this.pnlFlexibleHiddenNeurons.Name = "pnlFlexibleHiddenNeurons";
            this.pnlFlexibleHiddenNeurons.Size = new System.Drawing.Size(242, 62);
            this.pnlFlexibleHiddenNeurons.TabIndex = 2;
            // 
            // txtMaxHiddenNeurons
            // 
            this.txtMaxHiddenNeurons.Location = new System.Drawing.Point(138, 21);
            this.txtMaxHiddenNeurons.Name = "txtMaxHiddenNeurons";
            this.txtMaxHiddenNeurons.Size = new System.Drawing.Size(66, 21);
            this.txtMaxHiddenNeurons.TabIndex = 7;
            this.txtMaxHiddenNeurons.Text = "1";
            // 
            // txtMinHiddenNeurons
            // 
            this.txtMinHiddenNeurons.Location = new System.Drawing.Point(41, 21);
            this.txtMinHiddenNeurons.Name = "txtMinHiddenNeurons";
            this.txtMinHiddenNeurons.Size = new System.Drawing.Size(56, 21);
            this.txtMinHiddenNeurons.TabIndex = 6;
            this.txtMinHiddenNeurons.Text = "1";
            // 
            // pnlFixedHiddenNeurons
            // 
            this.pnlFixedHiddenNeurons.Controls.Add(this.txtHiddenNeurons);
            this.pnlFixedHiddenNeurons.Controls.Add(this.ultraLabel6);
            this.pnlFixedHiddenNeurons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFixedHiddenNeurons.Location = new System.Drawing.Point(3, 53);
            this.pnlFixedHiddenNeurons.Name = "pnlFixedHiddenNeurons";
            this.pnlFixedHiddenNeurons.Size = new System.Drawing.Size(242, 42);
            this.pnlFixedHiddenNeurons.TabIndex = 1;
            // 
            // pnlRadioCountNeurons
            // 
            this.pnlRadioCountNeurons.Controls.Add(this.rbFlexibleHiddenNeurons);
            this.pnlRadioCountNeurons.Controls.Add(this.rbFixedHiddenNeurons);
            this.pnlRadioCountNeurons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRadioCountNeurons.Location = new System.Drawing.Point(3, 16);
            this.pnlRadioCountNeurons.Name = "pnlRadioCountNeurons";
            this.pnlRadioCountNeurons.Size = new System.Drawing.Size(242, 37);
            this.pnlRadioCountNeurons.TabIndex = 0;
            // 
            // rbFlexibleHiddenNeurons
            // 
            this.rbFlexibleHiddenNeurons.AutoSize = true;
            this.rbFlexibleHiddenNeurons.Location = new System.Drawing.Point(138, 10);
            this.rbFlexibleHiddenNeurons.Name = "rbFlexibleHiddenNeurons";
            this.rbFlexibleHiddenNeurons.Size = new System.Drawing.Size(83, 17);
            this.rbFlexibleHiddenNeurons.TabIndex = 1;
            this.rbFlexibleHiddenNeurons.Text = "Променлив";
            this.rbFlexibleHiddenNeurons.UseVisualStyleBackColor = true;
            this.rbFlexibleHiddenNeurons.CheckedChanged += new System.EventHandler(this.rbFlexibleHiddenNeurons_CheckedChanged);
            // 
            // rbFixedHiddenNeurons
            // 
            this.rbFixedHiddenNeurons.AutoSize = true;
            this.rbFixedHiddenNeurons.Checked = true;
            this.rbFixedHiddenNeurons.Location = new System.Drawing.Point(10, 10);
            this.rbFixedHiddenNeurons.Name = "rbFixedHiddenNeurons";
            this.rbFixedHiddenNeurons.Size = new System.Drawing.Size(78, 17);
            this.rbFixedHiddenNeurons.TabIndex = 0;
            this.rbFixedHiddenNeurons.TabStop = true;
            this.rbFixedHiddenNeurons.Text = "Фиксиран";
            this.rbFixedHiddenNeurons.UseVisualStyleBackColor = true;
            this.rbFixedHiddenNeurons.CheckedChanged += new System.EventHandler(this.rbFixedHiddenNeurons_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "До:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "От:";
            // 
            // txtMomentum
            // 
            this.txtMomentum.Location = new System.Drawing.Point(130, 49);
            this.txtMomentum.Name = "txtMomentum";
            this.txtMomentum.Size = new System.Drawing.Size(64, 21);
            this.txtMomentum.TabIndex = 9;
            this.txtMomentum.Text = "0";
            this.txtMomentum.Validating += new System.ComponentModel.CancelEventHandler(this.txtMomentum_Validating);
            // 
            // txtLearningRate
            // 
            this.txtLearningRate.Location = new System.Drawing.Point(130, 19);
            this.txtLearningRate.Name = "txtLearningRate";
            this.txtLearningRate.Size = new System.Drawing.Size(64, 21);
            this.txtLearningRate.TabIndex = 8;
            this.txtLearningRate.Text = "0.1";
            this.txtLearningRate.Validating += new System.ComponentModel.CancelEventHandler(this.txtLearningRate_Validating);
            // 
            // ultraLabel7
            // 
            this.ultraLabel7.Location = new System.Drawing.Point(15, 53);
            this.ultraLabel7.Name = "ultraLabel7";
            this.ultraLabel7.Size = new System.Drawing.Size(117, 23);
            this.ultraLabel7.TabIndex = 11;
            this.ultraLabel7.Text = "Momentum";
            // 
            // ultraLabel8
            // 
            this.ultraLabel8.Location = new System.Drawing.Point(15, 23);
            this.ultraLabel8.Name = "ultraLabel8";
            this.ultraLabel8.Size = new System.Drawing.Size(100, 13);
            this.ultraLabel8.TabIndex = 10;
            this.ultraLabel8.Text = "Learning rate:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbGenetic);
            this.panel1.Controls.Add(this.rbBestTestNetwork);
            this.panel1.Controls.Add(this.rbBestNetwork);
            this.panel1.Location = new System.Drawing.Point(93, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 72);
            this.panel1.TabIndex = 5;
            // 
            // rbGenetic
            // 
            this.rbGenetic.AutoSize = true;
            this.rbGenetic.Location = new System.Drawing.Point(4, 47);
            this.rbGenetic.Name = "rbGenetic";
            this.rbGenetic.Size = new System.Drawing.Size(134, 17);
            this.rbGenetic.TabIndex = 2;
            this.rbGenetic.Text = "Генетични алгоритми";
            this.rbGenetic.UseVisualStyleBackColor = true;
            // 
            // rbBestTestNetwork
            // 
            this.rbBestTestNetwork.AutoSize = true;
            this.rbBestTestNetwork.Location = new System.Drawing.Point(4, 24);
            this.rbBestTestNetwork.Name = "rbBestTestNetwork";
            this.rbBestTestNetwork.Size = new System.Drawing.Size(158, 17);
            this.rbBestTestNetwork.TabIndex = 1;
            this.rbBestTestNetwork.Text = "Най-добра тестова мрежа";
            this.rbBestTestNetwork.UseVisualStyleBackColor = true;
            // 
            // rbBestNetwork
            // 
            this.rbBestNetwork.AutoSize = true;
            this.rbBestNetwork.Checked = true;
            this.rbBestNetwork.Location = new System.Drawing.Point(4, 4);
            this.rbBestNetwork.Name = "rbBestNetwork";
            this.rbBestNetwork.Size = new System.Drawing.Size(115, 17);
            this.rbBestNetwork.TabIndex = 0;
            this.rbBestNetwork.TabStop = true;
            this.rbBestNetwork.Text = "Най-добра мрежа";
            this.rbBestNetwork.UseVisualStyleBackColor = true;
            // 
            // rchTests
            // 
            this.rchTests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rchTests.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rchTests.Location = new System.Drawing.Point(3, 3);
            this.rchTests.Name = "rchTests";
            this.rchTests.Size = new System.Drawing.Size(759, 237);
            this.rchTests.TabIndex = 0;
            this.rchTests.Text = "";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.gbHiddenNeurons);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(773, 194);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметри на обучението на невронна мрежа";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ultraLabel8);
            this.groupBox3.Controls.Add(this.txtLearningRate);
            this.groupBox3.Controls.Add(this.txtMomentum);
            this.groupBox3.Controls.Add(this.ultraLabel7);
            this.groupBox3.Location = new System.Drawing.Point(6, 107);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 81);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Обучение";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ultraLabel4);
            this.groupBox2.Controls.Add(this.txtReinitializations);
            this.groupBox2.Controls.Add(this.txtEpochs);
            this.groupBox2.Controls.Add(this.ultraLabel5);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 82);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Количествени";
            // 
            // btnForecast
            // 
            this.btnForecast.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnForecast.Location = new System.Drawing.Point(339, 41);
            this.btnForecast.Name = "btnForecast";
            this.btnForecast.Size = new System.Drawing.Size(75, 56);
            this.btnForecast.TabIndex = 8;
            this.btnForecast.Text = "Изчисли";
            this.btnForecast.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnForecast.UseVisualStyleBackColor = true;
            this.btnForecast.Click += new System.EventHandler(this.btnForecast_Click);
            // 
            // grdForecastDep
            // 
            this.grdForecastDep.AllowUserToAddRows = false;
            this.grdForecastDep.AllowUserToDeleteRows = false;
            this.grdForecastDep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdForecastDep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdForecastDep.Location = new System.Drawing.Point(420, 41);
            this.grdForecastDep.Name = "grdForecastDep";
            this.grdForecastDep.Size = new System.Drawing.Size(312, 208);
            this.grdForecastDep.TabIndex = 7;
            // 
            // grdForecastInDep
            // 
            this.grdForecastInDep.AllowUserToAddRows = false;
            this.grdForecastInDep.AllowUserToDeleteRows = false;
            this.grdForecastInDep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdForecastInDep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdForecastInDep.Location = new System.Drawing.Point(38, 41);
            this.grdForecastInDep.Name = "grdForecastInDep";
            this.grdForecastInDep.Size = new System.Drawing.Size(294, 208);
            this.grdForecastInDep.TabIndex = 6;
            // 
            // pnlSensitivityParams
            // 
            this.pnlSensitivityParams.Controls.Add(this.btnShowSensVar);
            this.pnlSensitivityParams.Controls.Add(this.grdSensitivityVars);
            this.pnlSensitivityParams.Controls.Add(this.btnSensitivityAnalysisReload);
            this.pnlSensitivityParams.Controls.Add(this.lvVariablesSensitivity);
            this.pnlSensitivityParams.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSensitivityParams.Location = new System.Drawing.Point(3, 3);
            this.pnlSensitivityParams.Name = "pnlSensitivityParams";
            this.pnlSensitivityParams.Size = new System.Drawing.Size(237, 237);
            this.pnlSensitivityParams.TabIndex = 3;
            // 
            // btnShowSensVar
            // 
            this.btnShowSensVar.Location = new System.Drawing.Point(146, 411);
            this.btnShowSensVar.Name = "btnShowSensVar";
            this.btnShowSensVar.Size = new System.Drawing.Size(75, 23);
            this.btnShowSensVar.TabIndex = 4;
            this.btnShowSensVar.Text = "Опресни";
            this.btnShowSensVar.UseVisualStyleBackColor = true;
            this.btnShowSensVar.Click += new System.EventHandler(this.btnShowSensVar_Click);
            // 
            // grdSensitivityVars
            // 
            this.grdSensitivityVars.AllowUserToAddRows = false;
            this.grdSensitivityVars.AllowUserToDeleteRows = false;
            this.grdSensitivityVars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSensitivityVars.Location = new System.Drawing.Point(14, 222);
            this.grdSensitivityVars.Name = "grdSensitivityVars";
            this.grdSensitivityVars.Size = new System.Drawing.Size(207, 183);
            this.grdSensitivityVars.TabIndex = 3;
            // 
            // pbGeneticProgress
            // 
            this.pbGeneticProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pbGeneticProgress.Location = new System.Drawing.Point(11, 251);
            this.pbGeneticProgress.Name = "pbGeneticProgress";
            this.pbGeneticProgress.Size = new System.Drawing.Size(752, 23);
            this.pbGeneticProgress.TabIndex = 3;
            // 
            // gbGeneticParameters
            // 
            this.gbGeneticParameters.Controls.Add(this.label8);
            this.gbGeneticParameters.Controls.Add(this.label7);
            this.gbGeneticParameters.Controls.Add(this.txtGeneticEpochs);
            this.gbGeneticParameters.Controls.Add(this.txtPopulationCount);
            this.gbGeneticParameters.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbGeneticParameters.Location = new System.Drawing.Point(0, 194);
            this.gbGeneticParameters.Name = "gbGeneticParameters";
            this.gbGeneticParameters.Size = new System.Drawing.Size(773, 100);
            this.gbGeneticParameters.TabIndex = 13;
            this.gbGeneticParameters.TabStop = false;
            this.gbGeneticParameters.Text = "Параметри за обучение на генетични алгоритми";
            // 
            // txtPopulationCount
            // 
            this.txtPopulationCount.Location = new System.Drawing.Point(136, 20);
            this.txtPopulationCount.Name = "txtPopulationCount";
            this.txtPopulationCount.Size = new System.Drawing.Size(64, 20);
            this.txtPopulationCount.TabIndex = 0;
            this.txtPopulationCount.Text = "10";
            // 
            // txtGeneticEpochs
            // 
            this.txtGeneticEpochs.Location = new System.Drawing.Point(136, 47);
            this.txtGeneticEpochs.Name = "txtGeneticEpochs";
            this.txtGeneticEpochs.Size = new System.Drawing.Size(64, 20);
            this.txtGeneticEpochs.TabIndex = 1;
            this.txtGeneticEpochs.Text = "100";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Популация";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Брой епохи";
            // 
            // PlainNeuralNetworkModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(777, 638);
            this.Name = "PlainNeuralNetworkModel";
            this.Text = "Невронна мрежа (опростен модел)";
            this.pnlModelSpecificParameters.ResumeLayout(false);
            this.pnlTrainingMain.ResumeLayout(false);
            this.pnlResultsClient.ResumeLayout(false);
            this.tcResults.ResumeLayout(false);
            this.tabResiudals.ResumeLayout(false);
            this.tabTests.ResumeLayout(false);
            this.tabSensitivity.ResumeLayout(false);
            this.pnlForecastMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtEpochs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReinitializations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHiddenNeurons)).EndInit();
            this.gbHiddenNeurons.ResumeLayout(false);
            this.pnlFlexibleHiddenNeurons.ResumeLayout(false);
            this.pnlFlexibleHiddenNeurons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxHiddenNeurons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinHiddenNeurons)).EndInit();
            this.pnlFixedHiddenNeurons.ResumeLayout(false);
            this.pnlFixedHiddenNeurons.PerformLayout();
            this.pnlRadioCountNeurons.ResumeLayout(false);
            this.pnlRadioCountNeurons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMomentum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLearningRate)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdForecastDep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdForecastInDep)).EndInit();
            this.pnlSensitivityParams.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdSensitivityVars)).EndInit();
            this.gbGeneticParameters.ResumeLayout(false);
            this.gbGeneticParameters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.Misc.UltraLabel ultraLabel4;
        private Infragistics.Win.Misc.UltraLabel ultraLabel5;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtEpochs;
        private Infragistics.Win.Misc.UltraLabel ultraLabel6;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtHiddenNeurons;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtReinitializations;
        private System.Windows.Forms.ListBox lbResults;
        private System.Windows.Forms.ProgressBar pbProgressTraining;
        private Steema.TeeChart.TChart trainingChart;
        private Steema.TeeChart.TChart fittedChart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView lvVariablesSensitivity;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.Button btnSensitivityAnalysisReload;
        private Steema.TeeChart.TChart SensitivityChart;
        private Steema.TeeChart.TChart chartResiduals;
        private Steema.TeeChart.Styles.Bar bar1;
        private Steema.TeeChart.Styles.FastLine fastLine1;
        private System.Windows.Forms.GroupBox gbHiddenNeurons;
        private System.Windows.Forms.Panel pnlRadioCountNeurons;
        private System.Windows.Forms.RadioButton rbFlexibleHiddenNeurons;
        private System.Windows.Forms.RadioButton rbFixedHiddenNeurons;
        private System.Windows.Forms.Panel pnlFlexibleHiddenNeurons;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtMaxHiddenNeurons;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtMinHiddenNeurons;
        private System.Windows.Forms.Panel pnlFixedHiddenNeurons;
        private Infragistics.Win.Misc.UltraLabel ultraLabel7;
        private Infragistics.Win.Misc.UltraLabel ultraLabel8;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtMomentum;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtLearningRate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbBestTestNetwork;
        private System.Windows.Forms.RadioButton rbBestNetwork;
        private System.Windows.Forms.RichTextBox rchTests;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox groupBox1;
        protected System.Windows.Forms.Button btnForecast;
        protected System.Windows.Forms.DataGridView grdForecastDep;
        protected System.Windows.Forms.DataGridView grdForecastInDep;
        private System.Windows.Forms.Panel pnlSensitivityParams;
        private System.Windows.Forms.DataGridView grdSensitivityVars;
        private System.Windows.Forms.Button btnShowSensVar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbGenetic;
        private System.Windows.Forms.ProgressBar pbGeneticProgress;
        private System.Windows.Forms.GroupBox gbGeneticParameters;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGeneticEpochs;
        private System.Windows.Forms.TextBox txtPopulationCount;
    }
}
