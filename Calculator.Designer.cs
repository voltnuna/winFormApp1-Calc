
namespace WindowsFormsApp1
{
    partial class Calculator
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.HelloLabel = new System.Windows.Forms.Label();
            this.sum1 = new System.Windows.Forms.TextBox();
            this.sum2 = new System.Windows.Forms.TextBox();
            this.sumBtn = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.result2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // HelloLabel
            // 
            this.HelloLabel.AutoSize = true;
            this.HelloLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HelloLabel.Location = new System.Drawing.Point(23, 26);
            this.HelloLabel.Name = "HelloLabel";
            this.HelloLabel.Size = new System.Drawing.Size(109, 12);
            this.HelloLabel.TabIndex = 0;
            this.HelloLabel.Text = "여기를 클릭하세요.";
            this.HelloLabel.Click += new System.EventHandler(this.HelloLabel_Click);
            // 
            // sum1
            // 
            this.sum1.Location = new System.Drawing.Point(32, 90);
            this.sum1.Name = "sum1";
            this.sum1.Size = new System.Drawing.Size(100, 21);
            this.sum1.TabIndex = 1;
            this.sum1.Text = "1";
            this.sum1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // sum2
            // 
            this.sum2.Location = new System.Drawing.Point(138, 90);
            this.sum2.Name = "sum2";
            this.sum2.Size = new System.Drawing.Size(100, 21);
            this.sum2.TabIndex = 2;
            // 
            // sumBtn
            // 
            this.sumBtn.Location = new System.Drawing.Point(244, 90);
            this.sumBtn.Name = "sumBtn";
            this.sumBtn.Size = new System.Drawing.Size(75, 23);
            this.sumBtn.TabIndex = 3;
            this.sumBtn.Text = "=";
            this.sumBtn.UseVisualStyleBackColor = true;
            this.sumBtn.Click += new System.EventHandler(this.sumBtn_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(32, 135);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(100, 21);
            this.result.TabIndex = 4;
            // 
            // result2
            // 
            this.result2.Location = new System.Drawing.Point(32, 162);
            this.result2.Name = "result2";
            this.result2.Size = new System.Drawing.Size(100, 21);
            this.result2.TabIndex = 5;
            this.result2.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 265);
            this.Controls.Add(this.result2);
            this.Controls.Add(this.result);
            this.Controls.Add(this.sumBtn);
            this.Controls.Add(this.sum2);
            this.Controls.Add(this.sum1);
            this.Controls.Add(this.HelloLabel);
            this.Name = "Calculator";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HelloLabel;
        private System.Windows.Forms.TextBox sum1;
        private System.Windows.Forms.TextBox sum2;
        private System.Windows.Forms.Button sumBtn;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.TextBox result2;
    }
}

