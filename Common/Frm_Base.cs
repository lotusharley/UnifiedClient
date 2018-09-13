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
            Frm_DialogOkOnly.CreateDialog("Hello World").ShowDialog();
            
        }
    }
}
