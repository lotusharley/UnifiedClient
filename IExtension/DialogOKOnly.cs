using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IExtension
{
    public partial class DialogOKOnly : Form
    {
        const string CONST_DEFAULT_TITLE = "UnifiedClient Dialog";

        public DialogOKOnly()
        {
            InitializeComponent();
        }

        private void cmt_OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
