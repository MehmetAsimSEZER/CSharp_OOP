using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstraction_Example.Business.Repositories
{
    public class Utilities
    {
        public static void Eraser(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = string.Empty;
                }
                else if (control is ComboBox)
                {
                    control.Text = string.Empty;
                }
            }
        }
    }
}
