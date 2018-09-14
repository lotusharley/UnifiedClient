using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Underflow.Common
{
    public partial class Frm_Base : Form
    {
        public Frm_Base()
        {
            
            InitializeComponent();
            string ImportResult = Paltte_Manager.Import(AppDomain.CurrentDomain.BaseDirectory + "DLL\\DarkTheme.xml");
            Paltte_Manager.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
        }

        private void Frm_Base_Load(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("本周主要对人客合一新版进行开发，主要开发内容包括");
            sb.AppendLine("1、人客合一 美容院版本 新版本的开发");
            sb.AppendLine("2、人客合一 易宝支付的开发 APP版本易宝支付的接入开发工作");
            sb.AppendLine("3、人客合一 美容院版本 平台接口的开发及更新，主要包括 首面、用户管理、员工管理、返款等。");
            sb.AppendLine("1、人客合一 美容院版本 新版本的开发");
            sb.AppendLine("2、人客合一 易宝支付的开发 APP版本易宝支付的接入开发工作");
            sb.AppendLine("3、人客合一 美容院版本 平台接口的开发及更新，主要包括 首面、用户管理、员工管理、返款等。");

            var dlg = Frm_DialogOkOnly.CreateDialog(sb.ToString(),"测试","OK", ENUM_DIALOG_IMAGE.DIALOG_IMAGE_ANGRY);
            dlg.ShowDialog();
        }
    }
}
