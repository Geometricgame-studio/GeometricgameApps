using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace All_tools_Form_Apps.Custom_class
{
    public class EllipseContorl : Component
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern nint CreateRoundRectRgn
            (int nL, int nT, int nR, int nB, int nWidthEllipse, int nHeightEllipse);

        private Control control;
        private int cornerRadius = 25;
        public Control TargetControl
        {
            get { return control; }
            set
            {
                control = value;
                control.SizeChanged += (sender, eventArgs) => control.Region =
                Region.FromHrgn(CreateRoundRectRgn(0, 0, control.Width, control.Height,
                cornerRadius, cornerRadius));
            }
        }
        public int CornerRadius
        {
            get
            {
                return cornerRadius;
            }
            set
            {
                cornerRadius = value;
                if (control != null)
                {
                    control.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, control.Width, control.Height,
                    cornerRadius, cornerRadius));
                }
            }
        }
    }
}
