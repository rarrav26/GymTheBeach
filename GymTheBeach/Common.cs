using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymTheBeach
{
    public static class Common
    {
        public static bool ShowHint(TextBox textBox, string title, string text, ToolTipIcon icon, int duration = 2000)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                var hint = new ToolTip
                {
                    IsBalloon = true,
                    ToolTipTitle = title,
                    ToolTipIcon = icon
                };
                hint.Show(text, textBox, 150, -75, duration);
                textBox.Focus();
                return true;
            }

            return false;
        }
    }
}
