namespace WindowsFormsApplication1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.qrTextBox = new System.Windows.Forms.TextBox();
            this.generateBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.logoPath = new System.Windows.Forms.TextBox();
            this.selectLogoBtn = new System.Windows.Forms.Button();
            this.qrPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qrPictureBox)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // qrTextBox
            // 
            this.qrTextBox.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.qrTextBox.Location = new System.Drawing.Point(6, 20);
            this.qrTextBox.Multiline = true;
            this.qrTextBox.Name = "qrTextBox";
            this.qrTextBox.Size = new System.Drawing.Size(222, 51);
            this.qrTextBox.TabIndex = 1;
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(237, 20);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(58, 51);
            this.generateBtn.TabIndex = 2;
            this.generateBtn.Text = "生成";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.qrTextBox);
            this.groupBox1.Controls.Add(this.generateBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 82);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "输入内容";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.selectLogoBtn);
            this.groupBox2.Controls.Add(this.logoPath);
            this.groupBox2.Location = new System.Drawing.Point(12, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 56);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "选择Logo图片(可不填)";
            // 
            // logoPath
            // 
            this.logoPath.BackColor = System.Drawing.SystemColors.Window;
            this.logoPath.Location = new System.Drawing.Point(6, 21);
            this.logoPath.Name = "logoPath";
            this.logoPath.Size = new System.Drawing.Size(222, 21);
            this.logoPath.TabIndex = 0;
            // 
            // selectLogoBtn
            // 
            this.selectLogoBtn.Location = new System.Drawing.Point(237, 20);
            this.selectLogoBtn.Name = "selectLogoBtn";
            this.selectLogoBtn.Size = new System.Drawing.Size(58, 23);
            this.selectLogoBtn.TabIndex = 1;
            this.selectLogoBtn.Text = "...";
            this.selectLogoBtn.UseVisualStyleBackColor = true;
            this.selectLogoBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // qrPictureBox
            // 
            this.qrPictureBox.Location = new System.Drawing.Point(6, 21);
            this.qrPictureBox.Name = "qrPictureBox";
            this.qrPictureBox.Size = new System.Drawing.Size(289, 280);
            this.qrPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.qrPictureBox.TabIndex = 5;
            this.qrPictureBox.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.qrPictureBox);
            this.groupBox3.Location = new System.Drawing.Point(12, 173);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(298, 307);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "二维码预览(双击图片可保存)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 492);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "二维码(QR Code)生成器";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qrPictureBox)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox qrTextBox;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button selectLogoBtn;
        private System.Windows.Forms.TextBox logoPath;
        private System.Windows.Forms.PictureBox qrPictureBox;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

