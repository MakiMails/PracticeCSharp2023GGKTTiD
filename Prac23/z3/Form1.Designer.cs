namespace z3
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
            this.labelX0 = new System.Windows.Forms.Label();
            this.textBoxX0 = new System.Windows.Forms.TextBox();
            this.textBoxXk = new System.Windows.Forms.TextBox();
            this.labeXk = new System.Windows.Forms.Label();
            this.textBoxDx = new System.Windows.Forms.TextBox();
            this.labelDx = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.labelA = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelX0
            // 
            this.labelX0.AutoSize = true;
            this.labelX0.Location = new System.Drawing.Point(13, 20);
            this.labelX0.Name = "labelX0";
            this.labelX0.Size = new System.Drawing.Size(23, 15);
            this.labelX0.TabIndex = 0;
            this.labelX0.Text = "X0:";
            // 
            // textBoxX0
            // 
            this.textBoxX0.Location = new System.Drawing.Point(57, 12);
            this.textBoxX0.Name = "textBoxX0";
            this.textBoxX0.Size = new System.Drawing.Size(100, 23);
            this.textBoxX0.TabIndex = 1;
            // 
            // textBoxXk
            // 
            this.textBoxXk.Location = new System.Drawing.Point(57, 41);
            this.textBoxXk.Name = "textBoxXk";
            this.textBoxXk.Size = new System.Drawing.Size(100, 23);
            this.textBoxXk.TabIndex = 3;
            // 
            // labeXk
            // 
            this.labeXk.AutoSize = true;
            this.labeXk.Location = new System.Drawing.Point(13, 49);
            this.labeXk.Name = "labeXk";
            this.labeXk.Size = new System.Drawing.Size(23, 15);
            this.labeXk.TabIndex = 2;
            this.labeXk.Text = "Xk:";
            // 
            // textBoxDx
            // 
            this.textBoxDx.Location = new System.Drawing.Point(57, 70);
            this.textBoxDx.Name = "textBoxDx";
            this.textBoxDx.Size = new System.Drawing.Size(100, 23);
            this.textBoxDx.TabIndex = 5;
            // 
            // labelDx
            // 
            this.labelDx.AutoSize = true;
            this.labelDx.Location = new System.Drawing.Point(13, 78);
            this.labelDx.Name = "labelDx";
            this.labelDx.Size = new System.Drawing.Size(24, 15);
            this.labelDx.TabIndex = 4;
            this.labelDx.Text = "Dx:";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(57, 99);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 23);
            this.textBoxA.TabIndex = 7;
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(13, 107);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(18, 15);
            this.labelA.TabIndex = 6;
            this.labelA.Text = "A:";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(13, 128);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(271, 208);
            this.textBoxResult.TabIndex = 8;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(13, 342);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(271, 23);
            this.buttonCalculate.TabIndex = 9;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 389);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.textBoxDx);
            this.Controls.Add(this.labelDx);
            this.Controls.Add(this.textBoxXk);
            this.Controls.Add(this.labeXk);
            this.Controls.Add(this.textBoxX0);
            this.Controls.Add(this.labelX0);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelX0;
        private TextBox textBoxX0;
        private TextBox textBoxXk;
        private Label labeXk;
        private TextBox textBoxDx;
        private Label labelDx;
        private TextBox textBoxA;
        private Label labelA;
        private TextBox textBoxResult;
        private Button buttonCalculate;
    }
}