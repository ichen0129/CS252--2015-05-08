namespace Example06
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.setSalaryButton1 = new System.Windows.Forms.Button();
            this.setSalaryButton2 = new System.Windows.Forms.Button();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.benefitTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.baseSalaryTextBox = new System.Windows.Forms.TextBox();
            this.setSalarySbutton3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // setSalaryButton1
            // 
            this.setSalaryButton1.Location = new System.Drawing.Point(213, 104);
            this.setSalaryButton1.Name = "setSalaryButton1";
            this.setSalaryButton1.Size = new System.Drawing.Size(111, 23);
            this.setSalaryButton1.TabIndex = 0;
            this.setSalaryButton1.Text = "設定薪水方法1";
            this.setSalaryButton1.UseVisualStyleBackColor = true;
            this.setSalaryButton1.Click += new System.EventHandler(this.setSalaryButton1_Click);
            // 
            // setSalaryButton2
            // 
            this.setSalaryButton2.Location = new System.Drawing.Point(213, 133);
            this.setSalaryButton2.Name = "setSalaryButton2";
            this.setSalaryButton2.Size = new System.Drawing.Size(111, 23);
            this.setSalaryButton2.TabIndex = 1;
            this.setSalaryButton2.Text = "設定薪水方法2";
            this.setSalaryButton2.UseVisualStyleBackColor = true;
            this.setSalaryButton2.Click += new System.EventHandler(this.setSalaryButton2_Click);
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Location = new System.Drawing.Point(69, 104);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(128, 22);
            this.salaryTextBox.TabIndex = 2;
            // 
            // benefitTextBox
            // 
            this.benefitTextBox.Location = new System.Drawing.Point(69, 63);
            this.benefitTextBox.Name = "benefitTextBox";
            this.benefitTextBox.Size = new System.Drawing.Size(128, 22);
            this.benefitTextBox.TabIndex = 3;
            this.benefitTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "底薪";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "獎金";
            // 
            // baseSalaryTextBox
            // 
            this.baseSalaryTextBox.Location = new System.Drawing.Point(69, 29);
            this.baseSalaryTextBox.Name = "baseSalaryTextBox";
            this.baseSalaryTextBox.Size = new System.Drawing.Size(128, 22);
            this.baseSalaryTextBox.TabIndex = 6;
            // 
            // setSalarySbutton3
            // 
            this.setSalarySbutton3.Location = new System.Drawing.Point(213, 29);
            this.setSalarySbutton3.Name = "setSalarySbutton3";
            this.setSalarySbutton3.Size = new System.Drawing.Size(111, 23);
            this.setSalarySbutton3.TabIndex = 7;
            this.setSalarySbutton3.Text = "設定薪水方法3";
            this.setSalarySbutton3.UseVisualStyleBackColor = true;
            this.setSalarySbutton3.Click += new System.EventHandler(this.setSalarySbutton3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 185);
            this.Controls.Add(this.setSalarySbutton3);
            this.Controls.Add(this.baseSalaryTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.benefitTextBox);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(this.setSalaryButton2);
            this.Controls.Add(this.setSalaryButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button setSalaryButton1;
        private System.Windows.Forms.Button setSalaryButton2;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.TextBox benefitTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox baseSalaryTextBox;
        private System.Windows.Forms.Button setSalarySbutton3;
    }
}

