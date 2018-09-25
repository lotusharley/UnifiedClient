using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtensionMath
{
    [Export("UnifiedClientExtension", typeof(IExtension.IContextExtension))]
    public class ExtensionMath : IExtension.IContextExtension
    {
        public void CreateContext()
        {
            throw new NotImplementedException();
        }

        public ToolStripMenuItem GetExtensionItem()
        {
            ToolStripMenuItem mnuItem = new ToolStripMenuItem()
            {
                Text="小学数学",
                Name="Mnu_ExtensionMath",
            };

            ToolStripMenuItem mnuItem_SampleMath = new ToolStripMenuItem()
            {
                Text = "单一运算",
                Name = "Mnu_MathSample",
            };
            mnuItem_SampleMath.Click += MnuItem_SampleMath_Click;

            mnuItem.DropDownItems.Add(mnuItem_SampleMath);

            return mnuItem;
        }

        private void MnuItem_SampleMath_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem mnu = (ToolStripMenuItem)sender;
            var frmSample = new Frm_SampleMath();
            frmSample.Show();
            frmSample.WindowState = FormWindowState.Maximized;
            var parentFrm = Underflow.Common.ParentForm.GetInstance().GetParnetForm();
            frmSample.MdiParent = parentFrm;
        }

        public string GetExtensionName()
        {
            return "小学数据测试卷生成";
        }
    }
}
