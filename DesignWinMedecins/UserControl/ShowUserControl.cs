﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignWinPatients.UserControl
{
    public static class ShowUserControl
    {
        public static void showControl(Control control, Control mainPanel)
        {
            mainPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            mainPanel.BringToFront();
            control.Focus();
            mainPanel.Controls.Add(control);
        }
    }
}
