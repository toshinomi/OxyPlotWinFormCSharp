namespace OxyPlotWinFormCSharp
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFileSelect = new System.Windows.Forms.Button();
            this.image = new System.Windows.Forms.PictureBox();
            this.chart = new OxyPlot.WindowsForms.PlotView();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFileSelect
            // 
            this.btnFileSelect.BackColor = System.Drawing.Color.White;
            this.btnFileSelect.Location = new System.Drawing.Point(12, 12);
            this.btnFileSelect.Name = "btnFileSelect";
            this.btnFileSelect.Size = new System.Drawing.Size(106, 47);
            this.btnFileSelect.TabIndex = 0;
            this.btnFileSelect.Text = "File Select...";
            this.btnFileSelect.UseVisualStyleBackColor = false;
            this.btnFileSelect.Click += new System.EventHandler(this.OnClickBtnFileSelect);
            // 
            // image
            // 
            this.image.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.image.Location = new System.Drawing.Point(12, 76);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(359, 362);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image.TabIndex = 1;
            this.image.TabStop = false;
            // 
            // chart
            // 
            this.chart.Location = new System.Drawing.Point(392, 76);
            this.chart.Name = "chart";
            this.chart.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.chart.Size = new System.Drawing.Size(502, 362);
            this.chart.TabIndex = 2;
            this.chart.Text = "chart";
            this.chart.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.chart.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.chart.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(906, 450);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.image);
            this.Controls.Add(this.btnFileSelect);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFileSelect;
        private System.Windows.Forms.PictureBox image;
        private OxyPlot.WindowsForms.PlotView chart;
    }
}

