using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.Composition;

namespace ExtensionDBCheck
{
    [Export("UnifiedClientExtension", typeof(IExtension.IContextExtension))]
    public class ExtensionDB : IExtension.IContextExtension
    {
        public void CreateContext()
        {
            throw new NotImplementedException();
        }

        public ToolStripMenuItem GetExtensionItem()
        {
            ToolStripMenuItem menuItem = new ToolStripMenuItem()
            {
                Text="数据库校验",
                Name="mnu_ExtensionDBCheck"
            };
            menuItem.DropDownItems.Add("111");
            menuItem.DropDownItems.Add("122");
            menuItem.DropDownItems.Add("133");
            menuItem.Click += MenuItem_Click;

            return menuItem;
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            IExtension.DialogOKOnly dlgOK = new IExtension.DialogOKOnly();
            dlgOK.ShowDialog();
        }

        public string GetExtensionName()
        {
            return "LD.Model与数据库模型对比";
        }
    }
}
