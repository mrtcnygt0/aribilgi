using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WinFormsADO
{
    // Basit, daha büyük bir CheckBox kutusu çizen özel kontrol.
    public class BigCheckBox : CheckBox
    {
        private int boxSize = 24;

        [DefaultValue(24)]
        public int BoxSize
        {
            get => boxSize;
            set
            {
                if (value < 8) value = 8;
                boxSize = value;
                Invalidate();
                Update();
            }
        }

        public BigCheckBox()
        {
            // owner draw ile kendi çizimimizi yapacağız
            SetStyle(ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            this.AutoSize = false;
            this.Height = Math.Max(boxSize, Font.Height + 8);
        }

        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            this.Height = Math.Max(boxSize, Font.Height + 8);
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            Graphics g = e.Graphics;
            g.Clear(this.BackColor);

            // checkbox kare konumu
            int y = (this.Height - boxSize) / 2;
            Rectangle boxRect = new Rectangle(0, y, boxSize, boxSize);

            // VisualStyle varsa onu kullan, yoksa basit çiz
            if (Application.RenderWithVisualStyles && VisualStyleRenderer.IsSupported)
            {
                CheckBoxState state = this.Checked ? CheckBoxState.CheckedNormal : CheckBoxState.UncheckedNormal;
                CheckBoxRenderer.DrawCheckBox(g, new Point(boxRect.Left, boxRect.Top), state);
            }
            else
            {
                ControlPaint.DrawBorder3D(g, boxRect);
                if (this.Checked)
                {
                    // içini doldur
                    Rectangle inner = new Rectangle(boxRect.Left + 4, boxRect.Top + 4, boxRect.Width - 8, boxRect.Height - 8);
                    using (Brush b = new SolidBrush(SystemColors.ControlText))
                    {
                        g.FillRectangle(b, inner);
                    }
                }
            }

            // metni çiz
            Rectangle textRect = new Rectangle(boxRect.Right + 6, 0, this.Width - boxRect.Right - 6, this.Height);
            TextRenderer.DrawText(g, this.Text, this.Font, textRect, this.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Left);
        }
    }
}