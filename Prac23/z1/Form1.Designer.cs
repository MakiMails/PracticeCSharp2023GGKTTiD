namespace z1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxNumX = new System.Windows.Forms.TextBox();
            this.textBoxNumZ = new System.Windows.Forms.TextBox();
            this.buttonСalculate = new System.Windows.Forms.Button();
            this.textBoxNumY = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNumX
            // 
            this.textBoxNumX.Location = new System.Drawing.Point(29, 9);
            this.textBoxNumX.Name = "textBoxNumX";
            this.textBoxNumX.Size = new System.Drawing.Size(82, 23);
            this.textBoxNumX.TabIndex = 0;
            // 
            // textBoxNumZ
            // 
            this.textBoxNumZ.Location = new System.Drawing.Point(29, 67);
            this.textBoxNumZ.Name = "textBoxNumZ";
            this.textBoxNumZ.Size = new System.Drawing.Size(82, 23);
            this.textBoxNumZ.TabIndex = 1;
            // 
            // buttonСalculate
            // 
            this.buttonСalculate.Location = new System.Drawing.Point(29, 96);
            this.buttonСalculate.Name = "buttonСalculate";
            this.buttonСalculate.Size = new System.Drawing.Size(82, 23);
            this.buttonСalculate.TabIndex = 2;
            this.buttonСalculate.Text = "Calculate";
            this.buttonСalculate.UseVisualStyleBackColor = true;
            this.buttonСalculate.Click += new System.EventHandler(this.buttonСalculate_Click);
            // 
            // textBoxNumY
            // 
            this.textBoxNumY.Location = new System.Drawing.Point(29, 38);
            this.textBoxNumY.Name = "textBoxNumY";
            this.textBoxNumY.Size = new System.Drawing.Size(82, 23);
            this.textBoxNumY.TabIndex = 3;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(117, 100);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(42, 15);
            this.labelResult.TabIndex = 4;
            this.labelResult.Text = "Result:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "x:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "z:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 145);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textBoxNumY);
            this.Controls.Add(this.buttonСalculate);
            this.Controls.Add(this.textBoxNumZ);
            this.Controls.Add(this.textBoxNumX);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxNumX;
        private TextBox textBoxNumZ;
        private Button buttonСalculate;
        private TextBox textBoxNumY;
        private Label labelResult;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}