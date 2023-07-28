using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace VeganFit.Buttons
{
    public class DesignButton : Button
    {
        private int borderSize = 0;
        private int borderRadius = 20;
        private Color borderColor = Color.PaleVioletRed;

        //proplarını açarız manuel de ayarlamak için
        [Category("Desing Buttons")]
        public int BorderSize
        {
            get
            {
                return borderSize;
            }
            set
            {
                borderSize = value;
                Invalidate();
            }
        }

        [Category("Desing Buttons")]

        public int BorderRadius
        {
            get
            {
                return borderRadius;
            }
            set
            {
                borderRadius = value;
                Invalidate();
            }
        }

        [Category("Desing Buttons")]

        public Color BorderColor
        {
            get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;
                Invalidate();
            }
        }

        [Category("Desing Buttons")]

        public Color BackgroundColor
        {
            get
            {
                return BackColor;
            }
            set
            {
                BackColor = value;
            }
        }

        [Category("Desing Buttons")]

        public Color TextColor
        {
            get
            {
                return ForeColor;
            }
            set
            {
                ForeColor = value;
            }
        }

        public DesignButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Size = new Size(150, 40);
            BackColor = Color.MediumSlateBlue;
            ForeColor = Color.White;
            Resize += new EventHandler(Button_Resize);

        }

        private void Button_Resize(object sender, EventArgs e)
        {
            if (borderRadius > Height)
            {
                borderRadius = Height;
            }
        }

        private GraphicsPath GetFigurePath(Rectangle rect, float radius)//ŞEKİL OLUŞTURMA METODU
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)//düğme görümünü değiştiren metot
        {
            base.OnPaint(pevent);

            Rectangle rectSurface = ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
            int smoothSize = 2;
            if (borderSize > 0)
                smoothSize = borderSize;
            if (borderRadius > 2) //Yuvarlak düğme
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penSurface = new Pen(Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                    Region = new Region(pathSurface);//Button yüzeyi

                    pevent.Graphics.DrawPath(penSurface, pathSurface); //Yüksek Çözünürlük için kernar sınırları 

                    if (borderSize >= 1)//Button sınırları  

                        pevent.Graphics.DrawPath(penBorder, pathBorder);//Çizilen sınırları kontrol 
                }
            }
            else //Normal butonsa
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.None;

                Region = new Region(rectSurface);  //Button yüzeyi

                if (borderSize >= 1)//Button sınırları
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, Width - 1, Height - 1);
                    }
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)//butonları büyütürken yanda diğer butonları göstermesin sadece 1 buton göstermesi için yaparız.
        {
            base.OnHandleCreated(e);
            Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            Invalidate();
        }
    }

}
