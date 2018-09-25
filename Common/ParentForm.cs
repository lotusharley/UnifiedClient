using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Underflow.Common
{
    public class ParentForm
    {
        private static ParentForm m_Instance;
        private static System.Windows.Forms.Form m_ParentForm;

        private ParentForm(System.Windows.Forms.Form parentFrm)
        {
            m_ParentForm = parentFrm;
        }

        public static void SetParentForm(System.Windows.Forms.Form parentFrm)
        {
            m_Instance = new ParentForm(parentFrm);
        }

        public static ParentForm GetInstance()
        {
            if(m_Instance==null)
            {
                throw new Exception("中间件未初始化");
            }

            return m_Instance;
        }

        public System.Windows.Forms.Form GetParnetForm()
        {
            return m_ParentForm;
        }
    }
}
