namespace Section20_21
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMybtn2 = new System.Windows.Forms.Button();
            this.btnMybtn1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMsg
            // 
            this.txtMsg.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMsg.Location = new System.Drawing.Point(3, 4);
            this.txtMsg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(403, 29);
            this.txtMsg.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMybtn2);
            this.panel1.Controls.Add(this.btnMybtn1);
            this.panel1.Controls.Add(this.txtMsg);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 434);
            this.panel1.TabIndex = 1;
            // 
            // btnMybtn2
            // 
            this.btnMybtn2.Location = new System.Drawing.Point(3, 92);
            this.btnMybtn2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMybtn2.Name = "btnMybtn2";
            this.btnMybtn2.Size = new System.Drawing.Size(403, 48);
            this.btnMybtn2.TabIndex = 2;
            this.btnMybtn2.Text = "button2";
            this.btnMybtn2.UseVisualStyleBackColor = true;
            // 
            // btnMybtn1
            // 
            this.btnMybtn1.Location = new System.Drawing.Point(3, 41);
            this.btnMybtn1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMybtn1.Name = "btnMybtn1";
            this.btnMybtn1.Size = new System.Drawing.Size(403, 48);
            this.btnMybtn1.TabIndex = 1;
            this.btnMybtn1.Text = "button1";
            this.btnMybtn1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 434);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "TestForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMybtn2;
        private System.Windows.Forms.Button btnMybtn1;
    }
}

