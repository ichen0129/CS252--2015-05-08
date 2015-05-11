namespace Example07
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
            this.speedTextBox = new System.Windows.Forms.TextBox();
            this.setSpeedbutton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // speedTextBox
            // 
            this.speedTextBox.Location = new System.Drawing.Point(12, 36);
            this.speedTextBox.Name = "speedTextBox";
            this.speedTextBox.Size = new System.Drawing.Size(100, 22);
            this.speedTextBox.TabIndex = 0;
            // 
            // setSpeedbutton1
            // 
            this.setSpeedbutton1.Location = new System.Drawing.Point(142, 36);
            this.setSpeedbutton1.Name = "setSpeedbutton1";
            this.setSpeedbutton1.Size = new System.Drawing.Size(75, 23);
            this.setSpeedbutton1.TabIndex = 1;
            this.setSpeedbutton1.Text = "設定速度";
            this.setSpeedbutton1.UseVisualStyleBackColor = true;
            this.setSpeedbutton1.Click += new System.EventHandler(this.setSpeedbutton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 88);
            this.Controls.Add(this.setSpeedbutton1);
            this.Controls.Add(this.speedTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox speedTextBox;
        private System.Windows.Forms.Button setSpeedbutton1;
    }
}

