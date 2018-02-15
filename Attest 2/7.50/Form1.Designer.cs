namespace _7._50
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
            this.CalcBtn = new System.Windows.Forms.Button();
            this.ArrInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Location = new System.Drawing.Point(13, 91);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(10, 13);
            this.output.TabIndex = 14;
            this.output.Text = " ";
            // 
            // CalcBtn
            // 
            this.CalcBtn.Location = new System.Drawing.Point(49, 52);
            this.CalcBtn.Name = "CalcBtn";
            this.CalcBtn.Size = new System.Drawing.Size(180, 31);
            this.CalcBtn.TabIndex = 13;
            this.CalcBtn.Text = "найти последовательность";
            this.CalcBtn.UseVisualStyleBackColor = true;
            this.CalcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // ArrInput
            // 
            this.ArrInput.Location = new System.Drawing.Point(15, 26);
            this.ArrInput.Name = "ArrInput";
            this.ArrInput.Size = new System.Drawing.Size(252, 20);
            this.ArrInput.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "введите массив";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 222);
            this.Controls.Add(this.output);
            this.Controls.Add(this.CalcBtn);
            this.Controls.Add(this.ArrInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "7.50";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label output;
        private System.Windows.Forms.Button CalcBtn;
        private System.Windows.Forms.TextBox ArrInput;
        private System.Windows.Forms.Label label1;
    }
}

