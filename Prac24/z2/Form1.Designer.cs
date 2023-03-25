namespace z2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartMain = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxMinX = new System.Windows.Forms.TextBox();
            this.labelMinX = new System.Windows.Forms.Label();
            this.labelH = new System.Windows.Forms.Label();
            this.textBoxH = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelMaxX = new System.Windows.Forms.Label();
            this.textBoxMaxX = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).BeginInit();
            this.SuspendLayout();
            // 
            // chartMain
            // 
            this.chartMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            chartArea1.Name = "ChartArea1";
            this.chartMain.ChartAreas.Add(chartArea1);
            this.chartMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.chartMain.ImeMode = System.Windows.Forms.ImeMode.Off;
            legend1.Name = "Legend1";
            this.chartMain.Legends.Add(legend1);
            this.chartMain.Location = new System.Drawing.Point(12, 12);
            this.chartMain.Name = "chartMain";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartMain.Series.Add(series1);
            this.chartMain.Size = new System.Drawing.Size(776, 300);
            this.chartMain.TabIndex = 0;
            this.chartMain.Text = "chart1";
            // 
            // textBoxMinX
            // 
            this.textBoxMinX.Location = new System.Drawing.Point(60, 335);
            this.textBoxMinX.Name = "textBoxMinX";
            this.textBoxMinX.Size = new System.Drawing.Size(100, 20);
            this.textBoxMinX.TabIndex = 1;
            // 
            // labelMinX
            // 
            this.labelMinX.AutoSize = true;
            this.labelMinX.Location = new System.Drawing.Point(13, 338);
            this.labelMinX.Name = "labelMinX";
            this.labelMinX.Size = new System.Drawing.Size(35, 13);
            this.labelMinX.TabIndex = 2;
            this.labelMinX.Text = "Min x:";
            // 
            // labelH
            // 
            this.labelH.AutoSize = true;
            this.labelH.Location = new System.Drawing.Point(13, 392);
            this.labelH.Name = "labelH";
            this.labelH.Size = new System.Drawing.Size(19, 13);
            this.labelH.TabIndex = 4;
            this.labelH.Text = "h: ";
            // 
            // textBoxH
            // 
            this.textBoxH.Location = new System.Drawing.Point(60, 389);
            this.textBoxH.Name = "textBoxH";
            this.textBoxH.Size = new System.Drawing.Size(100, 20);
            this.textBoxH.TabIndex = 3;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 415);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(148, 23);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Выполнить";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelMaxX
            // 
            this.labelMaxX.AutoSize = true;
            this.labelMaxX.Location = new System.Drawing.Point(13, 364);
            this.labelMaxX.Name = "labelMaxX";
            this.labelMaxX.Size = new System.Drawing.Size(41, 13);
            this.labelMaxX.TabIndex = 7;
            this.labelMaxX.Text = "Max x: ";
            // 
            // textBoxMaxX
            // 
            this.textBoxMaxX.Location = new System.Drawing.Point(60, 361);
            this.textBoxMaxX.Name = "textBoxMaxX";
            this.textBoxMaxX.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaxX.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelMaxX);
            this.Controls.Add(this.textBoxMaxX);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelH);
            this.Controls.Add(this.textBoxH);
            this.Controls.Add(this.labelMinX);
            this.Controls.Add(this.textBoxMinX);
            this.Controls.Add(this.chartMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartMain;
        private System.Windows.Forms.TextBox textBoxMinX;
        private System.Windows.Forms.Label labelMinX;
        private System.Windows.Forms.Label labelH;
        private System.Windows.Forms.TextBox textBoxH;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelMaxX;
        private System.Windows.Forms.TextBox textBoxMaxX;
    }
}

