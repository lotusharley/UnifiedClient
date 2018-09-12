using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Underflow
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            this.MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            InitializeComponent();
            this.pic_Logo.Image = Image.FromFile(ClientConfig.GetInstance().GetConfig("working_folder") + "\\Resource\\Logo.png");
            
        }

        private void border_Main_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Frm_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            var extensions = ExtensionHelper.GetInstance().Extensions;

            foreach(var key in extensions.Keys)
            {
                if(extensions[key]!=null)
                {
                    ToolStripMenuItem mnuItem = extensions[key].GetExtensionItem();
                    mnu_Main.Items.Add(mnuItem);
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }


        private void btn_Form_Close_Click(object sender, EventArgs e)
        {
            ExitingApplication();
        }

        private void ExitingApplication()
        {
            Application.Exit();
        }

        private void btn_Form_Mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnl_Title_DoubleClick(object sender, EventArgs e)
        {
            if(this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void pnl_Title_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pnl_Title_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Clicks>1)
            {
                pnl_Title_DoubleClick(sender, e);
                return;
            }
            IWin32Api.ReleaseCapture();
            IWin32Api.SendMessage(this.Handle, Win32Const.WM_SYSCOMMAND, Win32Const.SC_MOVE + Win32Const.HTCAPTION, 0);
        }

        private void mnu_Exit_Click(object sender, EventArgs e)
        {
            ExitingApplication();
        }

        private void mnu_Save_Click(object sender, EventArgs e)
        {

        }
    }
}
