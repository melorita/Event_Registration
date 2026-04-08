using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace EventRegistrationDesktop.Services
{
    public static class UIHelper
    {
        public static void ApplyRoundedCorners(Control ctrl, int radius)
        {
            if (ctrl == null) return;
            GraphicsPath gp = new GraphicsPath();
            gp.AddArc(0, 0, radius, radius, 180, 90);
            gp.AddArc(ctrl.Width - radius, 0, radius, radius, 270, 90);
            gp.AddArc(ctrl.Width - radius, ctrl.Height - radius, radius, radius, 0, 90);
            gp.AddArc(0, ctrl.Height - radius, radius, radius, 90, 90);
            gp.CloseAllFigures();
            ctrl.Region = new Region(gp);
        }

        public static void BeautifyButton(Button btn, Color backColor)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = backColor;
            btn.ForeColor = Color.White;
            btn.Cursor = Cursors.Hand;
            btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btn.MouseEnter += (s, e) => btn.BackColor = ControlPaint.Light(backColor);
            btn.MouseLeave += (s, e) => btn.BackColor = backColor;
        }

        public static void StyleTextBox(TextBox txt)
        {
            txt.BorderStyle = BorderStyle.FixedSingle;
            txt.Font = new Font("Segoe UI", 11);
        }
    }
}
