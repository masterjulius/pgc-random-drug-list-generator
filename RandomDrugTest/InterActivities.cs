using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RandomDrugTest
{
    public static class InterActivities
    {

        public static int check_empty_fields(Control.ControlCollection control)
        {
            int emptyCount = 0;
            foreach (Control item in control)
            {
                if (item is TextBox)
                {
                    if (string.IsNullOrEmpty(item.Text))
                    {
                        emptyCount += 1;
                    }
                }
                else if (item is ComboBox)
                {
                    if (item.Text == "-Select Department/Division-")
                    {
                        emptyCount += 1;
                    }
                }
            }
            return emptyCount;
        }

    }
}
