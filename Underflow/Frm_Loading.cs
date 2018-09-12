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
    public partial class frm_Loading : Form
    {
        Timer _timer = new Timer();
        public frm_Loading()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(45, 45, 48);
            this.pnl_Status.BackColor = Color.FromArgb(76, 76, 79);
            this.pic_Logo.Image = Image.FromFile(ClientConfig.GetInstance().GetConfig("working_folder") + "\\Resource\\Logo.png");
        }

        private void frm_Loading_Load(object sender, EventArgs e)
        {
            ExtensionHelper.GetInstance();
            _timer.Tick += _timer_Tick;
            _timer.Interval = 3000;
            _timer.Enabled = true;
            _timer.Start();

        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            _timer.Enabled = false;
            _timer.Stop();
            Frm_Main frm_Main = new Frm_Main();
            frm_Main.Show();
            this.Hide();
        }
    }
}
