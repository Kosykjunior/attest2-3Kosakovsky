namespace _7._19
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
            this.LastOutput = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FirstOutput = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ChangeArrBtn = new System.Windows.Forms.Button();
            this.ArrInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AllOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LastOutput
            // 
            this.LastOutput.AutoSize = true;
            this.LastOutput.Location = new System.Drawing.Point(15, 133);
            this.LastOutput.Name = "LastOutput";
            this.LastOutput.Size = new System.Drawing.Size(10, 13);
            this.LastOutput.TabIndex = 16;
            this.LastOutput.Text = " ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "последняя серия";
            // 
            // FirstOutput
            // 
            this.FirstOutput.AutoSize = true;
            this.FirstOutput.Location = new System.Drawing.Point(18, 99);
            this.FirstOutput.Name = "FirstOutput";
            this.FirstOutput.Size = new System.Drawing.Size(10, 13);
            this.FirstOutput.TabIndex = 14;
            this.FirstOutput.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "первая серия";
            // 
            // ChangeArrBtn
            // 
            this.ChangeArrBtn.Location = new System.Drawing.Point(15, 52);
            this.ChangeArrBtn.Name = "ChangeArrBtn";
            this.ChangeArrBtn.Size = new System.Drawing.Size(117, 23);
            this.ChangeArrBtn.TabIndex = 12;
            this.ChangeArrBtn.Text = "изменить массив";
            this.ChangeArrBtn.UseVisualStyleBackColor = true;
            this.ChangeArrBtn.Click += new System.EventHandler(this.ChangeArrBtn_Click);
            // 
            // ArrInput
            // 
            this.ArrInput.Location = new System.Drawing.Point(15, 26);
            this.ArrInput.Name = "ArrInput";
            this.ArrInput.Size = new System.Drawing.Size(256, 20);
            this.ArrInput.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "введите массив";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "все серии";
            // 
            // AllOutput
            // 
            this.AllOutput.AutoSize = true;
            this.AllOutput.Location = new System.Drawing.Point(21, 181);
            this.AllOutput.Name = "AllOutput";
            this.AllOutput.Size = new System.Drawing.Size(10, 13);
            this.AllOutput.TabIndex = 18;
            this.AllOutput.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 288);
            this.Controls.Add(this.AllOutput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LastOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FirstOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ChangeArrBtn);
            this.Controls.Add(this.ArrInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "7.19";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LastOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label FirstOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ChangeArrBtn;
        private System.Windows.Forms.TextBox ArrInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label AllOutput;
    }
}

