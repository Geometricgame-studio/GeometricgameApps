using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace All_tools_Form_Apps.Custom_class
{
    public enum TextPosition
    {
        Left,
        Right,
        Center,
        Sliding,
        None
    }
    public class Custom_ProgessBar : ProgressBar
    {
        private Color channelColor = Color.LightSteelBlue;
        private Color sliderColor = Color.RoyalBlue;
        private Color foreBackColor = Color.RoyalBlue;
        private int channelHeight = 6;
        private int sliderHeight = 6;
        private TextPosition showValue = TextPosition.Right;
        private string symbolBefore = "";
        private string symbolAfter = "";
        private bool showMaximun = false;

        private bool paintedBack = false;
        private bool stopPainting = false;

        public Custom_ProgessBar()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.ForeColor = Color.White;
        }
        [Category("Custom_class")]
        public Color ChannelColor {

            get { return channelColor; }
            set {
                channelColor = value;
                this.Invalidate();
            }
        }
        [Category("Custom_class")]
        public Color SliderColor {
            get { return sliderColor;  }
            set {
                sliderColor = value;
                this.Invalidate();
            }
        }
        [Category("Custom_class")]
        public Color ForeBackColor {
            get { return foreBackColor; }
            set
            {
                foreBackColor = value;
                this.Invalidate();
            }
        }
        [Category("Custom_class")]
        public int ChannelHeight { 
            get { return channelHeight; }
            set
            {
                channelHeight = value;
                this.Invalidate();
            }
        }
        [Category("Custom_class")]
        public int SliderHeight {
            get { return sliderHeight; }
            set
            {
                sliderHeight = value;
                this.Invalidate();
            }
        }
        [Category("Custom_class")]
        public TextPosition ShowValue {
            get { return showValue; }
            set
            {
                showValue = value;
                this.Invalidate();
            }
        }

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Category("Custom_class")]
        public override Font Font
        { get => base.Font; set => base.Font = value; }

        [Category("Custom_class")]
        public override Color ForeColor
        { get => base.ForeColor; set => base.ForeColor = value; }

        //Paint Background & channel
        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            if (stopPainting == false) {
                if (paintedBack == false) {
                    Graphics graph = pevent.Graphics;
                    Rectangle rectChannel =
                        new Rectangle(0, 0, this.Width, channelHeight);
                    using (var brushChannel = new SolidBrush(channelColor))
                    {
                        if (channelHeight >= sliderHeight)
                        {
                            rectChannel.Y =
                                this.Height - channelHeight;
                        }
                        else {
                            rectChannel.Y =
                                this.Height - ((channelHeight + sliderHeight) / 2);
                        }
                        //Painting
                        graph.Clear(this.Parent.BackColor);
                        graph.FillRectangle(brushChannel, rectChannel);
                        //Stop
                        if (this.DesignMode == false)
                        {
                            paintedBack = true;
                        }
                    }
                }
                //Reset
                if (this.Value == this.Maximum || this.Value == this.Minimum)
                {
                    paintedBack = false;
                }
            }
        }

        //Paint slider
        protected override void OnPaint(PaintEventArgs e)
        {
            if (stopPainting == false) {
                Graphics graph = e.Graphics;
                double scaleFactor =(((double)this.Value - this.Minimum) /
                    ((double)this.Maximum - this.Minimum));
                int sliderWidth = (int)(this.Width * scaleFactor);
                Rectangle rectSlider =
                    new Rectangle(0, 0, sliderWidth, sliderHeight);
                using (var brushSlider = new SolidBrush(sliderColor))
                {
                    if (SliderHeight >= channelHeight)
                    {
                        rectSlider.Y =
                            this.Height - sliderHeight;
                    }
                    else {
                        rectSlider.Y =
                            this.Height - ((sliderHeight - channelHeight) / 2);
                    }
                    //Painting
                    if (sliderWidth > 1) {
                        graph.FillRectangle(brushSlider, rectSlider);
                    }
                    if (showValue != TextPosition.None) {
                        DrawValueText(graph, sliderWidth, rectSlider);
                    }
                }
            }
        }

        private void DrawValueText(Graphics graph, int sliderWidth, Rectangle rectSlider)
        {
            string text = symbolBefore + this.Value.ToString() + symbolAfter;
            if (showMaximun) text = text + "/" + symbolBefore + this.Maximum.ToString() + symbolAfter;
            var textSize = TextRenderer.MeasureText(text, this.Font);
            var rectText = new Rectangle(0, 0, textSize.Width, textSize.Height + 2);
            using (var brushText = new SolidBrush(this.ForeColor))
            using (var brushTextBack = new SolidBrush(foreBackColor))
            using (var textFormat = new StringFormat())
            {
                switch (showValue) {
                    case TextPosition.Left:
                        rectText.X = 0;
                        textFormat.Alignment = StringAlignment.Near;
                        break;
                    case TextPosition.Right:
                        rectText.X = this.Width - textSize.Width;
                        textFormat.Alignment = StringAlignment.Far;
                        break;
                    case TextPosition.Center:
                        rectText.X = (this.Width - textSize.Width) / 2;
                        textFormat.Alignment = StringAlignment.Center;
                        break;
                    case TextPosition.Sliding:
                        rectText.X = sliderWidth - textSize.Width;
                        textFormat.Alignment = StringAlignment.Center;
                        using (var brushClear = new SolidBrush(this.Parent.BackColor))
                        {
                            var rect = rectSlider;
                            rect.Y = rectText.Y;
                            rect.Height = rectText.Height;
                            graph.FillRectangle(brushClear, rect);
                        }
                            break;
                }
                //Painting
                graph.FillRectangle(brushTextBack, rectText);
                graph.DrawString(text, this.Font, brushText, rectText, textFormat);
            }
        }
    }
}
