using System;
using System.Configuration;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BTH5_24521470_Bai08
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            timer.Interval = 1000;
            timer.Tick += Tick;
            timer.Start();
        }

        private void Tick(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int x = this.ClientSize.Width / 2;
            int y = this.ClientSize.Height / 2;

            g.TranslateTransform(x, y);

            int r = 200;
            
            // Vẽ các chấm tròn trên mặt đồng hồ
            for ( int i = 0; i < 60; i++ )
            {
                GraphicsState state = g.Save();

                g.RotateTransform(i * 6);

                if ( i % 5 == 0 )
                {
                    g.FillEllipse(Brushes.White, -8, -r, 16, 16);
                }
                else
                {
                    g.FillEllipse(Brushes.White, -3, -r + 5, 6, 6);
                } 
                g.Restore(state); 
            }    

            DateTime time_now = DateTime.Now;

            //Tính góc quay cho giờ, phút, giây
            float hour = (time_now.Hour % 12 + (float)time_now.Minute / 60 ) * 30; 
            float minute = (time_now.Minute % 60 + (float)time_now.Second / 60) * 6 ;
            float second = time_now.Second * 6;

            // Vẽ kim giờ, phút, giây
            Draw(g, hour, 32, r * 0.7f, true);
            Draw(g, minute, 16, r * 0.9f, true);
            Draw(g, second, 1, r * 0.9f, false);
        }

        private void Draw( Graphics g, float gocquay, float width, float length, bool flag)
        {
            GraphicsState state = g.Save();
            g.RotateTransform(gocquay);

            Pen pen = new Pen(Color.White);
            if (flag)  // Vẽ kim giờ, phút
            {
                PointF[] points =
                {
                new PointF(0, -length + 20),
                new PointF( width / 2, 0 ),
                new PointF(0, 20),
                new PointF(-width / 2, 0)
                };                
                g.DrawPolygon(pen, points);
            }
            else // Vẽ kim giây
            {
                g.DrawLine(pen, 0, 0, 0, -length);
            }    
            g.Restore(state);
        }
    }
}
