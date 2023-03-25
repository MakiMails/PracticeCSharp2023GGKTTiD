namespace z2
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
            this.labelNumX = new System.Windows.Forms.Label();
            this.textBoxNumX = new System.Windows.Forms.TextBox();
            this.textBoxNumI = new System.Windows.Forms.TextBox();
            this.labelNumI = new System.Windows.Forms.Label();
            this.radioButtonShX = new System.Windows.Forms.RadioButton();
            this.radioButtonSquareX = new System.Windows.Forms.RadioButton();
            this.radioButtonExpSquareX = new System.Windows.Forms.RadioButton();
            this.groupBoxRBFc = new System.Windows.Forms.GroupBox();
            this.buttonFunc = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.groupBoxRBFc.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNumX
            // 
            this.labelNumX.AutoSize = true;
            this.labelNumX.Location = new System.Drawing.Point(22, 28);
            this.labelNumX.Name = "labelNumX";
            this.labelNumX.Size = new System.Drawing.Size(17, 15);
            this.labelNumX.TabIndex = 0;
            this.labelNumX.Text = "X:";
            // 
            // textBoxNumX
            // 
            this.textBoxNumX.Location = new System.Drawing.Point(45, 25);
            this.textBoxNumX.Name = "textBoxNumX";
            this.textBoxNumX.Size = new System.Drawing.Size(100, 23);
            this.textBoxNumX.TabIndex = 1;
            // 
            // textBoxNumI
            // 
            this.textBoxNumI.Location = new System.Drawing.Point(45, 54);
            this.textBoxNumI.Name = "textBoxNumI";
            this.textBoxNumI.Size = new System.Drawing.Size(100, 23);
            this.textBoxNumI.TabIndex = 3;
            // 
            // labelNumI
            // 
            this.labelNumI.AutoSize = true;
            this.labelNumI.Location = new System.Drawing.Point(22, 57);
            this.labelNumI.Name = "labelNumI";
            this.labelNumI.Size = new System.Drawing.Size(13, 15);
            this.labelNumI.TabIndex = 2;
            this.labelNumI.Text = "I:";
            // 
            // radioButtonShX
            // 
            this.radioButtonShX.AutoSize = true;
            this.radioButtonShX.Checked = true;
            this.radioButtonShX.Location = new System.Drawing.Point(6, 21);
            this.radioButtonShX.Name = "radioButtonShX";
            this.radioButtonShX.Size = new System.Drawing.Size(52, 19);
            this.radioButtonShX.TabIndex = 4;
            this.radioButtonShX.TabStop = true;
            this.radioButtonShX.Text = "Sh(x)";
            this.radioButtonShX.UseVisualStyleBackColor = true;
            this.radioButtonShX.CheckedChanged += new System.EventHandler(this.radioButtonFunc_Click);
            // 
            // radioButtonSquareX
            // 
            this.radioButtonSquareX.AutoSize = true;
            this.radioButtonSquareX.Location = new System.Drawing.Point(6, 45);
            this.radioButtonSquareX.Name = "radioButtonSquareX";
            this.radioButtonSquareX.Size = new System.Drawing.Size(45, 19);
            this.radioButtonSquareX.TabIndex = 5;
            this.radioButtonSquareX.Text = "x^2";
            this.radioButtonSquareX.UseVisualStyleBackColor = true;
            this.radioButtonSquareX.CheckedChanged += new System.EventHandler(this.radioButtonFunc_Click);
            // 
            // radioButtonExpSquareX
            // 
            this.radioButtonExpSquareX.AutoSize = true;
            this.radioButtonExpSquareX.Location = new System.Drawing.Point(6, 70);
            this.radioButtonExpSquareX.Name = "radioButtonExpSquareX";
            this.radioButtonExpSquareX.Size = new System.Drawing.Size(45, 19);
            this.radioButtonExpSquareX.TabIndex = 6;
            this.radioButtonExpSquareX.Text = "e^2";
            this.radioButtonExpSquareX.UseVisualStyleBackColor = true;
            this.radioButtonExpSquareX.CheckedChanged += new System.EventHandler(this.radioButtonFunc_Click);
            // 
            // groupBoxRBFc
            // 
            this.groupBoxRBFc.Controls.Add(this.radioButtonSquareX);
            this.groupBoxRBFc.Controls.Add(this.radioButtonExpSquareX);
            this.groupBoxRBFc.Controls.Add(this.radioButtonShX);
            this.groupBoxRBFc.Location = new System.Drawing.Point(22, 83);
            this.groupBoxRBFc.Name = "groupBoxRBFc";
            this.groupBoxRBFc.Size = new System.Drawing.Size(123, 100);
            this.groupBoxRBFc.TabIndex = 7;
            this.groupBoxRBFc.TabStop = false;
            this.groupBoxRBFc.Text = "Func x";
            // 
            // buttonFunc
            // 
            this.buttonFunc.Location = new System.Drawing.Point(151, 160);
            this.buttonFunc.Name = "buttonFunc";
            this.buttonFunc.Size = new System.Drawing.Size(325, 23);
            this.buttonFunc.TabIndex = 8;
            this.buttonFunc.Text = "To perform";
            this.buttonFunc.UseVisualStyleBackColor = true;
            this.buttonFunc.Click += new System.EventHandler(this.buttonFunc_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(151, 25);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(325, 129);
            this.textBoxResult.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 206);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonFunc);
            this.Controls.Add(this.groupBoxRBFc);
            this.Controls.Add(this.textBoxNumI);
            this.Controls.Add(this.labelNumI);
            this.Controls.Add(this.textBoxNumX);
            this.Controls.Add(this.labelNumX);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxRBFc.ResumeLayout(false);
            this.groupBoxRBFc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelNumX;
        private TextBox textBoxNumX;
        private TextBox textBoxNumI;
        private Label labelNumI;
        private RadioButton radioButtonShX;
        private RadioButton radioButtonSquareX;
        private RadioButton radioButtonExpSquareX;
        private GroupBox groupBoxRBFc;
        private Button buttonFunc;
        private TextBox textBoxResult;
    }
}