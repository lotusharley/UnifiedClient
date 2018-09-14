using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtensionMath
{
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
                Text="小学数据",
                Name="Mnu_ExtensionMath"
            };

            return mnuItem;
        }





        public string GetExtensionName()
        {
            return "小学数据测试卷生成";
        }
    }
}
