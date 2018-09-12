namespace IExtension
{
    partial class DialogOKOnly
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmt_OK = new System.Windows.Forms.Button();
            this.lab_Content = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lab_Content);
            this.panel1.Location = new System.Drawing.Point(78, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 149);
            this.panel1.TabIndex = 0;
            // 
            // cmt_OK
            // 
            this.cmt_OK.Location = new System.Drawing.Point(151, 226);
            this.cmt_OK.Name = "cmt_OK";
            this.cmt_OK.Size = new System.Drawing.Size(75, 23);
            this.cmt_OK.TabIndex = 1;
            this.cmt_OK.Text = "OK";
            this.cmt_OK.UseVisualStyleBackColor = true;
            this.cmt_OK.Click += new System.EventHandler(this.cmt_OK_Click);
            // 
            // lab_Content
            // 
            this.lab_Content.AutoSize = true;
            this.lab_Content.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Content.Location = new System.Drawing.Point(15, 16);
            this.lab_Content.Name = "lab_Content";
            this.lab_Content.Size = new System.Drawing.Size(0, 17);
            this.lab_Content.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(9, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // DialogOKOnly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 261);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmt_OK);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DialogOKOnly";
            this.Text = "DialogOKOnly";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmt_OK;
        private System.Windows.Forms.Label lab_Content;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}