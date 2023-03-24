namespace z1
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
            this.listBoxStrNums = new System.Windows.Forms.ListBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxStrNums
            // 
            this.listBoxStrNums.FormattingEnabled = true;
            this.listBoxStrNums.Items.AddRange(new object[] {
            "12 234 3423 124 4 45 12 4",
            "235 3 12 5 70 4 3 67 74",
            "2 4 7 34 56 23"});
            this.listBoxStrNums.Location = new System.Drawing.Point(12, 12);
            this.listBoxStrNums.Name = "listBoxStrNums";
            this.listBoxStrNums.Size = new System.Drawing.Size(278, 134);
            this.listBoxStrNums.TabIndex = 0;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(12, 178);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(65, 13);
            this.labelResult.TabIndex = 1;
            this.labelResult.Text = "Результат: ";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 152);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(278, 23);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Выполнить";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 228);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.listBoxStrNums);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxStrNums;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonStart;
    }
}

