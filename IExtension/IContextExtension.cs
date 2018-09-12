using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IExtension
{
    public interface IContextExtension
    {
        /// <summary>
        /// 获取Extension的菜单项
        /// </summary>
        /// <returns>System.Windows.Form.ToolStripMenuItem</returns>
        System.Windows.Forms.ToolStripMenuItem GetExtensionItem();
        void CreateContext();
        string GetExtensionName();
    }
}
