namespace Underflow
{
    partial class frm_Loading
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label lab_Title;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Loading));
            this.pnl_Status = new System.Windows.Forms.Panel();
            this.lab_Status = new System.Windows.Forms.Label();
            this.pic_Logo = new System.Windows.Forms.PictureBox();
            lab_Title = new System.Windows.Forms.Label();
            this.pnl_Status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_Title
            // 
            lab_Title.AutoSize = true;
            lab_Title.Font = new System.Drawing.Font("Microsoft YaHei UI", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            lab_Title.ForeColor = System.Drawing.Color.White;
            lab_Title.Location = new System.Drawing.Point(98, 105);
            lab_Title.Name = "lab_Title";
            lab_Title.Size = new System.Drawing.Size(386, 60);
            lab_Title.TabIndex = 0;
            lab_Title.Text = "Underflow 2017";
            // 
            // pnl_Status
            // 
            this.pnl_Status.Controls.Add(this.lab_Status);
            this.pnl_Status.Location = new System.Drawing.Point(0, 241);
            this.pnl_Status.Name = "pnl_Status";
            this.pnl_Status.Size = new System.Drawing.Size(520, 20);
            this.pnl_Status.TabIndex = 1;
            // 
            // lab_Status
            // 
            this.lab_Status.AutoSize = true;
            this.lab_Status.ForeColor = System.Drawing.Color.White;
            this.lab_Status.Location = new System.Drawing.Point(13, 4);
            this.lab_Status.Name = "lab_Status";
            this.lab_Status.Size = new System.Drawing.Size(0, 12);
            this.lab_Status.TabIndex = 0;
            // 
            // pic_Logo
            // 
            this.pic_Logo.Location = new System.Drawing.Point(52, 112);
            this.pic_Logo.Name = "pic_Logo";
            this.pic_Logo.Size = new System.Drawing.Size(45, 45);
            this.pic_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Logo.TabIndex = 2;
            this.pic_Logo.TabStop = false;
            // 
            // frm_Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(520, 260);
            this.Controls.Add(this.pic_Logo);
            this.Controls.Add(this.pnl_Status);
            this.Controls.Add(lab_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Loading";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_loading";
            this.Load += new System.EventHandler(this.frm_Loading_Load);
            this.pnl_Status.ResumeLayout(false);
            this.pnl_Status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Status;
        private System.Windows.Forms.Label lab_Status;
        private System.Windows.Forms.PictureBox pic_Logo;
    }
}

