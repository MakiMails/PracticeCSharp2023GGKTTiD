namespace z4
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
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.labelXY = new System.Windows.Forms.Label();
            this.labelLit = new System.Windows.Forms.Label();
            this.textBoxLit = new System.Windows.Forms.TextBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(28, 82);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(123, 23);
            this.textBoxX.TabIndex = 1;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(28, 111);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(123, 23);
            this.textBoxY.TabIndex = 2;
            // 
            // labelXY
            // 
            this.labelXY.AutoSize = true;
            this.labelXY.Location = new System.Drawing.Point(28, 64);
            this.labelXY.Name = "labelXY";
            this.labelXY.Size = new System.Drawing.Size(123, 15);
            this.labelXY.TabIndex = 3;
            this.labelXY.Text = "Кординаты элемента";
            // 
            // labelLit
            // 
            this.labelLit.AutoSize = true;
            this.labelLit.Location = new System.Drawing.Point(67, 20);
            this.labelLit.Name = "labelLit";
            this.labelLit.Size = new System.Drawing.Size(43, 15);
            this.labelLit.TabIndex = 5;
            this.labelLit.Text = "БУКВА";
            // 
            // textBoxLit
            // 
            this.textBoxLit.Location = new System.Drawing.Point(28, 38);
            this.textBoxLit.Name = "textBoxLit";
            this.textBoxLit.Size = new System.Drawing.Size(123, 23);
            this.textBoxLit.TabIndex = 4;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(28, 140);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(123, 23);
            this.buttonCreate.TabIndex = 6;
            this.buttonCreate.Text = "Создать";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.labelLit);
            this.Controls.Add(this.textBoxLit);
            this.Controls.Add(this.labelXY);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxX;
        private TextBox textBoxY;
        private Label labelXY;
        private Label labelLit;
        private TextBox textBoxLit;
        private Button buttonCreate;
    }
}