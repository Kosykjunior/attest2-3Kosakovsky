namespace _8._19
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
            this.Output = new System.Windows.Forms.Label();
            this.CalcBtn = new System.Windows.Forms.Button();
            this.ListInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InputN = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.InputN)).BeginInit();
            this.SuspendLayout();
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Location = new System.Drawing.Point(15, 107);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(10, 13);
            this.Output.TabIndex = 9;
            this.Output.Text = " ";
            // 
            // CalcBtn
            // 
            this.CalcBtn.Location = new System.Drawing.Point(15, 77);
            this.CalcBtn.Name = "CalcBtn";
            this.CalcBtn.Size = new System.Drawing.Size(256, 23);
            this.CalcBtn.TabIndex = 8;
            this.CalcBtn.Text = "выполнить перестановку";
            this.CalcBtn.UseVisualStyleBackColor = true;
            this.CalcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // ListInput
            // 
            this.ListInput.Location = new System.Drawing.Point(15, 25);
            this.ListInput.Name = "ListInput";
            this.ListInput.Size = new System.Drawing.Size(256, 20);
            this.ListInput.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "введите список ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "n = ";
            // 
            // InputN
            // 
            this.InputN.Location = new System.Drawing.Point(47, 52);
            this.InputN.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.InputN.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.InputN.Name = "InputN";
            this.InputN.Size = new System.Drawing.Size(55, 20);
            this.InputN.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 201);
            this.Controls.Add(this.InputN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.CalcBtn);
            this.Controls.Add(this.ListInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "8.19";
            ((System.ComponentModel.ISupportInitialize)(this.InputN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.Button CalcBtn;
        private System.Windows.Forms.TextBox ListInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown InputN;
    }
}

