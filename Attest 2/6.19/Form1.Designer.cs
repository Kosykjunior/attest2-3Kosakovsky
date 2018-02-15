namespace _6._19
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
            this.output = new System.Windows.Forms.Label();
            this.CheckBtn = new System.Windows.Forms.Button();
            this.Input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Location = new System.Drawing.Point(12, 91);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(10, 13);
            this.output.TabIndex = 11;
            this.output.Text = " ";
            // 
            // CheckBtn
            // 
            this.CheckBtn.Location = new System.Drawing.Point(15, 52);
            this.CheckBtn.Name = "CheckBtn";
            this.CheckBtn.Size = new System.Drawing.Size(256, 36);
            this.CheckBtn.TabIndex = 10;
            this.CheckBtn.Text = "проверить строку";
            this.CheckBtn.UseVisualStyleBackColor = true;
            this.CheckBtn.Click += new System.EventHandler(this.CheckBtn_Click);
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(15, 26);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(256, 20);
            this.Input.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "введите строку";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.output);
            this.Controls.Add(this.CheckBtn);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "6.19";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label output;
        private System.Windows.Forms.Button CheckBtn;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Label label1;
    }
}

