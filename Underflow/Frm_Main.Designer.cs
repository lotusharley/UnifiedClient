namespace Underflow
{
    partial class Frm_Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.pnl_Title = new System.Windows.Forms.Panel();
            this.btn_Form_Mini = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pic_Logo = new System.Windows.Forms.PictureBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btn_Form_Close = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.mnu_Main = new System.Windows.Forms.MenuStrip();
            this.mnu_Filegrp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.KpnMng_Main = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kptPlt_Main = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.sts_Main = new System.Windows.Forms.StatusStrip();
            this.sts_LabelMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnl_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).BeginInit();
            this.pnl_Menu.SuspendLayout();
            this.mnu_Main.SuspendLayout();
            this.sts_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Title
            // 
            this.pnl_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pnl_Title.Controls.Add(this.btn_Form_Mini);
            this.pnl_Title.Controls.Add(this.pic_Logo);
            this.pnl_Title.Controls.Add(this.kryptonLabel1);
            this.pnl_Title.Controls.Add(this.btn_Form_Close);
            this.pnl_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Title.Location = new System.Drawing.Point(0, 0);
            this.pnl_Title.Name = "pnl_Title";
            this.pnl_Title.Size = new System.Drawing.Size(1214, 30);
            this.pnl_Title.TabIndex = 0;
            this.pnl_Title.DoubleClick += new System.EventHandler(this.pnl_Title_DoubleClick);
            this.pnl_Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Title_MouseDown);
            // 
            // btn_Form_Mini
            // 
            this.btn_Form_Mini.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Form;
            this.btn_Form_Mini.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Form_Mini.Location = new System.Drawing.Point(1154, 0);
            this.btn_Form_Mini.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.btn_Form_Mini.Name = "btn_Form_Mini";
            this.btn_Form_Mini.Size = new System.Drawing.Size(30, 30);
            this.btn_Form_Mini.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_Form_Mini.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_Form_Mini.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_Form_Mini.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_Form_Mini.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_Form_Mini.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_Form_Mini.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_Form_Mini.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_Form_Mini.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.btn_Form_Mini.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.btn_Form_Mini.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_Form_Mini.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_Form_Mini.StateTracking.Content.ShortText.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Form_Mini.TabIndex = 3;
            this.btn_Form_Mini.TabStop = false;
            this.btn_Form_Mini.Values.Text = "__";
            this.btn_Form_Mini.Click += new System.EventHandler(this.btn_Form_Mini_Click);
            // 
            // pic_Logo
            // 
            this.pic_Logo.BackColor = System.Drawing.Color.Transparent;
            this.pic_Logo.Location = new System.Drawing.Point(21, 5);
            this.pic_Logo.Name = "pic_Logo";
            this.pic_Logo.Size = new System.Drawing.Size(16, 16);
            this.pic_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Logo.TabIndex = 2;
            this.pic_Logo.TabStop = false;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(48, 5);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(67, 20);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.kryptonLabel1.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "Underflow";
            // 
            // btn_Form_Close
            // 
            this.btn_Form_Close.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Form;
            this.btn_Form_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Form_Close.Location = new System.Drawing.Point(1184, 0);
            this.btn_Form_Close.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.btn_Form_Close.Name = "btn_Form_Close";
            this.btn_Form_Close.Size = new System.Drawing.Size(30, 30);
            this.btn_Form_Close.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_Form_Close.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_Form_Close.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_Form_Close.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_Form_Close.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_Form_Close.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_Form_Close.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_Form_Close.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_Form_Close.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.btn_Form_Close.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.btn_Form_Close.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_Form_Close.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_Form_Close.StateTracking.Content.ShortText.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Form_Close.TabIndex = 0;
            this.btn_Form_Close.TabStop = false;
            this.btn_Form_Close.Values.Text = "X";
            this.btn_Form_Close.Click += new System.EventHandler(this.btn_Form_Close_Click);
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pnl_Menu.Controls.Add(this.mnu_Main);
            this.pnl_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Menu.Location = new System.Drawing.Point(0, 30);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(1214, 30);
            this.pnl_Menu.TabIndex = 1;
            // 
            // mnu_Main
            // 
            this.mnu_Main.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mnu_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_Filegrp});
            this.mnu_Main.Location = new System.Drawing.Point(0, 0);
            this.mnu_Main.Name = "mnu_Main";
            this.mnu_Main.Size = new System.Drawing.Size(1214, 25);
            this.mnu_Main.TabIndex = 0;
            this.mnu_Main.Text = "menuStrip1";
            // 
            // mnu_Filegrp
            // 
            this.mnu_Filegrp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_Save,
            this.mnu_SaveAs,
            this.toolStripSeparator1,
            this.mnu_Exit});
            this.mnu_Filegrp.Name = "mnu_Filegrp";
            this.mnu_Filegrp.Size = new System.Drawing.Size(58, 21);
            this.mnu_Filegrp.Text = "文件(&F)";
            // 
            // mnu_Save
            // 
            this.mnu_Save.Name = "mnu_Save";
            this.mnu_Save.Size = new System.Drawing.Size(128, 22);
            this.mnu_Save.Text = "保存(&S)";
            this.mnu_Save.Click += new System.EventHandler(this.mnu_Save_Click);
            // 
            // mnu_SaveAs
            // 
            this.mnu_SaveAs.Name = "mnu_SaveAs";
            this.mnu_SaveAs.Size = new System.Drawing.Size(128, 22);
            this.mnu_SaveAs.Text = "另存为(&A)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(125, 6);
            // 
            // mnu_Exit
            // 
            this.mnu_Exit.Name = "mnu_Exit";
            this.mnu_Exit.Size = new System.Drawing.Size(128, 22);
            this.mnu_Exit.Text = "退出(&X)";
            this.mnu_Exit.Click += new System.EventHandler(this.mnu_Exit_Click);
            // 
            // KpnMng_Main
            // 
            this.KpnMng_Main.GlobalPalette = this.kptPlt_Main;
            this.KpnMng_Main.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Custom;
            // 
            // kptPlt_Main
            // 
            this.kptPlt_Main.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.kptPlt_Main.ToolMenuStatus.Button.ButtonSelectedBorder = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.kptPlt_Main.ToolMenuStatus.Button.ButtonSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.kptPlt_Main.ToolMenuStatus.Button.ButtonSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.kptPlt_Main.ToolMenuStatus.Button.ButtonSelectedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.kptPlt_Main.ToolMenuStatus.Button.ButtonSelectedHighlight = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.kptPlt_Main.ToolMenuStatus.Button.ButtonSelectedHighlightBorder = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.kptPlt_Main.ToolMenuStatus.Button.OverflowButtonGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.kptPlt_Main.ToolMenuStatus.Button.OverflowButtonGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.kptPlt_Main.ToolMenuStatus.Button.OverflowButtonGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.kptPlt_Main.ToolMenuStatus.Menu.MenuBorder = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.kptPlt_Main.ToolMenuStatus.Menu.MenuItemText = System.Drawing.Color.White;
            this.kptPlt_Main.ToolMenuStatus.MenuStrip.MenuStripFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kptPlt_Main.ToolMenuStatus.MenuStrip.MenuStripGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.kptPlt_Main.ToolMenuStatus.MenuStrip.MenuStripGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.kptPlt_Main.ToolMenuStatus.MenuStrip.MenuStripText = System.Drawing.Color.White;
            this.kptPlt_Main.ToolMenuStatus.StatusStrip.StatusStripGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(25)))));
            this.kptPlt_Main.ToolMenuStatus.StatusStrip.StatusStripGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(25)))));
            this.kptPlt_Main.ToolMenuStatus.StatusStrip.StatusStripText = System.Drawing.Color.White;
            this.kptPlt_Main.ToolMenuStatus.ToolStrip.ToolStripBorder = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.kptPlt_Main.ToolMenuStatus.ToolStrip.ToolStripContentPanelGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.kptPlt_Main.ToolMenuStatus.ToolStrip.ToolStripContentPanelGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.kptPlt_Main.ToolMenuStatus.ToolStrip.ToolStripDropDownBackground = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            // 
            // sts_Main
            // 
            this.sts_Main.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sts_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sts_LabelMain});
            this.sts_Main.Location = new System.Drawing.Point(0, 678);
            this.sts_Main.Name = "sts_Main";
            this.sts_Main.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.sts_Main.Size = new System.Drawing.Size(1214, 22);
            this.sts_Main.TabIndex = 2;
            // 
            // sts_LabelMain
            // 
            this.sts_LabelMain.Name = "sts_LabelMain";
            this.sts_LabelMain.Size = new System.Drawing.Size(39, 17);
            this.sts_LabelMain.Text = "Ready";
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1214, 700);
            this.Controls.Add(this.sts_Main);
            this.Controls.Add(this.pnl_Menu);
            this.Controls.Add(this.pnl_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnu_Main;
            this.Name = "Frm_Main";
            this.Text = "Frm_Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Main_FormClosed);
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.pnl_Title.ResumeLayout(false);
            this.pnl_Title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).EndInit();
            this.pnl_Menu.ResumeLayout(false);
            this.pnl_Menu.PerformLayout();
            this.mnu_Main.ResumeLayout(false);
            this.mnu_Main.PerformLayout();
            this.sts_Main.ResumeLayout(false);
            this.sts_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Title;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Form_Close;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.PictureBox pic_Logo;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Form_Mini;
        private System.Windows.Forms.Panel pnl_Menu;
        private System.Windows.Forms.MenuStrip mnu_Main;
        private ComponentFactory.Krypton.Toolkit.KryptonManager KpnMng_Main;
        private System.Windows.Forms.ToolStripMenuItem mnu_Filegrp;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kptPlt_Main;
        private System.Windows.Forms.ToolStripMenuItem mnu_Save;
        private System.Windows.Forms.ToolStripMenuItem mnu_SaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnu_Exit;
        private System.Windows.Forms.StatusStrip sts_Main;
        private System.Windows.Forms.ToolStripStatusLabel sts_LabelMain;
    }
}