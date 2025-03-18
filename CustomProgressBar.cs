using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Icr_Treasury_Control
{
    public partial class CustomProgressBar : UserControl
    {
        private double _value;

        public CustomProgressBar()
        {
            SetStyle(ControlStyles.UserPaint |
                    ControlStyles.OptimizedDoubleBuffer |
                    ControlStyles.ResizeRedraw |
                    ControlStyles.SupportsTransparentBackColor, true);

            DoubleBuffered = true;
            BackColor = Color.Transparent;
            Size = new Size(200, 40);
        }

        // Propriedades personalizadas
        public Color BorderColor { get; set; } = Color.Black;
        public Color ProgressColor { get; set; } = Color.Blue;
        public Color ProgressBorderColor { get; set; } = Color.WhiteSmoke;
        public Color BackgroundColor { get; set; } = Color.LightGray;
        public Color TextColor { get; set; } = Color.WhiteSmoke;
        public Font TextFont { get; set; } = new Font("Arial", 10);
        public string DisplayText { get; set; } = string.Empty;
        public int BorderRadius { get; set; } = 10;

        // Propriedade Value corrigida
        public double Value
        {
            get => _value;
            set
            {
                _value = Math.Clamp(value, 0, 100);
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Área de desenho (limite da borda externa)
            Rectangle outerRect = new Rectangle(0, 0, Width - 1, Height - 1);

            // Criar o clipping para que nada ultrapasse as bordas externas
            using (var clipPath = CreateRoundedRectanglePath(outerRect, BorderRadius))
            {
                g.SetClip(clipPath);

                // Fundo
                using (var bgBrush = new SolidBrush(BackgroundColor))
                {
                    g.FillPath(bgBrush, clipPath);
                }

                // Definição do retângulo de progresso
                int progressWidth = (int)((Width - 4) * (Value / 100));
                progressWidth = Math.Clamp(progressWidth, 0, Width - 4);
                Rectangle progressRect = new Rectangle(2, 2, progressWidth, Height - 4);

                // Preenchimento do progresso
                if (Value > 0)
                {
                    using (var progressBrush = new SolidBrush(ProgressColor))
                    {
                        g.FillRectangle(progressBrush, progressRect);
                    }

                    // Borda do progresso
                    using (var progressPen = new Pen(ProgressBorderColor, 2))
                    {
                        g.DrawRectangle(progressPen, progressRect);
                    }
                }
            }

            // Remover o clipping para desenhar a borda externa
            g.ResetClip();

            // Borda externa
            using (var borderPen = new Pen(BorderColor, 2))
            using (var path = CreateRoundedRectanglePath(outerRect, BorderRadius))
            {
                g.DrawPath(borderPen, path);
            }

            // Texto
            if (!string.IsNullOrEmpty(DisplayText))
            {
                SizeF textSize = g.MeasureString(DisplayText, TextFont);
                float x = (Width - textSize.Width) / 2;
                float y = (Height - textSize.Height) / 2;

                using (Brush textBrush = new SolidBrush(TextColor))
                {
                    g.DrawString(DisplayText, TextFont, textBrush, x, y);
                }
            }
        }

        // Método das bordas arredondadas
        private GraphicsPath CreateRoundedRectanglePath(Rectangle rect, int radius)
        {
            var path = new GraphicsPath();
            int diameter = radius * 2;

            if (radius > 0)
            {
                path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
                path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
                path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
                path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
                path.CloseFigure();
            }
            else
            {
                path.AddRectangle(rect);
            }

            return path;
        }
    }
}
