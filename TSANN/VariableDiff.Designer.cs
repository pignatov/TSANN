namespace Plig.TimeSeries.Client
{
    partial class VariableDiff
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
            this.udDiff = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.udDiff)).BeginInit();
            this.SuspendLayout();
            // 
            // udDiff
            // 
            this.udDiff.Location = new System.Drawing.Point(103, 107);
            this.udDiff.Name = "udDiff";
            this.udDiff.Size = new System.Drawing.Size(56, 20);
            this.udDiff.TabIndex = 1;
            this.udDiff.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udDiff.ValueChanged += new System.EventHandler(this.udDiff_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Разлика между членове с индекс равен на:";
            // 
            // VariableDiff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(266, 233);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.udDiff);
            this.Name = "VariableDiff";
            this.Text = "Разлики";
            this.Load += new System.EventHandler(this.VariableDiff_Load);
            this.Controls.SetChildIndex(this.udDiff, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.udDiff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown udDiff;
        private System.Windows.Forms.Label label1;
    }
}
