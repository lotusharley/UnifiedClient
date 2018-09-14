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
    public partial class Frm_DialogOkOnly : Form
    {
        private static Frm_DialogOkOnly m_Instance = null;

        private Frm_DialogOkOnly()
        {
            InitializeComponent();
        }

        public static Frm_DialogOkOnly CreateDialog(string DialogMessage, string DialogCaption = "提示", string ButtonText = "确定", ENUM_DIALOG_IMAGE DialogImage = ENUM_DIALOG_IMAGE.DIALOG_IMAGE_NONE)
        {
            if (m_Instance == null)
                m_Instance = new Frm_DialogOkOnly();

            m_Instance.txt_Message.Text = DialogMessage;
            m_Instance.Text = DialogCaption;
            m_Instance.btn_OK.Text = ButtonText;

            if(DialogImage == ENUM_DIALOG_IMAGE.DIALOG_IMAGE_NONE)
            {
                m_Instance.pic_DlgImg.Visible = false;
            }
            else
            {
                m_Instance.pic_DlgImg.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "Resource\\" + DialogImage.ToString().Replace("DIALOG_IMAGE_", "") + ".png";
            }

            return m_Instance;
        }

        public new void Show()
        {
            {
                string a;
                string b;
            };
            this.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
