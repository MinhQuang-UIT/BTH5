using System.Drawing.Drawing2D;
using System.Text;

namespace BTH5_24521470_Bai10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            panel1.Paint += PaintLine;
        }

        private void cbx_dashstyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void PaintLine(object sender, PaintEventArgs e)
        {
            if (cbx_dashstyle.SelectedIndex == -1 || cbx_width.SelectedIndex == -1 || cbx_linejoin.SelectedIndex == -1 
                 || cbx_dashcap.SelectedIndex == -1 || cbx_startcap.SelectedIndex == -1 || cbx_endcap.SelectedIndex == -1)
            {
                return; 
            }

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Pen pen = new Pen(Color.Red);

            if (cbx_dashstyle.SelectedIndex != -1)
            {
                switch (cbx_dashstyle.Text.ToString())
                {
                    case "Custom":
                        pen.DashStyle = DashStyle.Custom; break;
                    case "Dash":
                        pen.DashStyle = DashStyle.Dash; break;
                    case "DashDot":
                        pen.DashStyle = DashStyle.DashDot; break;
                    case "DashDotDot":
                        pen.DashStyle = DashStyle.DashDotDot; break;
                    case "Dot":
                        pen.DashStyle = DashStyle.Dot; break;
                    default:
                        pen.DashStyle = DashStyle.Solid; break;
                }
            }

            if (cbx_width.SelectedIndex != -1)
            {
                switch (cbx_width.Text.ToString())
                {
                    case "1":
                        pen.Width = 1.0f; break;
                    case "2":
                        pen.Width = 2.0f; break;
                    case "4":
                        pen.Width = 4.0f; break;
                    case "6":
                        pen.Width = 6.0f; break;
                    case "8":
                        pen.Width = 8.0f; break;
                    case "10":
                        pen.Width = 10.0f; break;
                    case "12":
                        pen.Width = 12.0f; break;
                    case "14":
                        pen.Width = 14.0f; break;
                    case "16":
                        pen.Width = 16.0f; break;
                    case "18":
                        pen.Width = 18.0f; break;
                    default:
                        pen.Width = 20.0f; break;
                }
            }

            if (cbx_linejoin.SelectedIndex != -1)
            {
                switch (cbx_linejoin.Text.ToString())
                {
                    case "Miter":
                        pen.LineJoin = LineJoin.Miter; break;
                    case "Bevel":
                        pen.LineJoin = LineJoin.Bevel; break;
                    case "Round":
                        pen.LineJoin = LineJoin.Round; break;
                    default:
                        pen.LineJoin = LineJoin.MiterClipped; break;
                }
            }

            if (cbx_dashcap.SelectedIndex != -1)
            {
                switch (cbx_dashcap.Text.ToString())
                {
                    case "Flat":
                        pen.DashCap = DashCap.Flat; break;
                    case "Round":
                        pen.DashCap = DashCap.Round; break;
                    default:
                        pen.DashCap = DashCap.Triangle; break;
                }
            }

            if (cbx_startcap.SelectedIndex != -1)
            {
                switch (cbx_startcap.Text.ToString())
                {
                    case "ArrowAnchor":
                        pen.StartCap = LineCap.ArrowAnchor; break;
                    case "Custom":
                        pen.StartCap = LineCap.Custom; break;
                    case "DiamondAnchor":
                        pen.StartCap = LineCap.DiamondAnchor; break;
                    case "Flat":
                        pen.StartCap = LineCap.Flat; break;
                    case "Round":
                        pen.StartCap = LineCap.Round; break;
                    case "RoundAnchor":
                        pen.StartCap = LineCap.RoundAnchor; break;
                    case "Square":
                        pen.StartCap = LineCap.Square; break;
                    case "SquareAnchor":
                        pen.StartCap = LineCap.SquareAnchor; break;
                    default:
                        pen.StartCap = LineCap.Triangle; break;
                }
            }

            if (cbx_endcap.SelectedIndex != -1)
            {
                switch (cbx_endcap.Text.ToString())
                {
                    case "ArrowAnchor":
                        pen.EndCap = LineCap.ArrowAnchor; break;
                    case "Custom":
                        pen.EndCap = LineCap.Custom; break;
                    case "DiamondAnchor":
                        pen.EndCap = LineCap.DiamondAnchor; break;
                    case "Flat":
                        pen.EndCap = LineCap.Flat; break;
                    case "Round":
                        pen.EndCap = LineCap.Round; break;
                    case "RoundAnchor":
                        pen.EndCap = LineCap.RoundAnchor; break;
                    case "Square":
                        pen.EndCap = LineCap.Square; break;
                    case "SquareAnchor":
                        pen.EndCap = LineCap.SquareAnchor; break;
                    default:
                        pen.EndCap = LineCap.Triangle; break;
                }
            }

            g.DrawLine(pen, 30, 30, 150, 150);

            PointF[] points =
            {
                new PointF(100, 200),
                new PointF(180, 310),
                new PointF(260, 250),
            };
            g.DrawLines(pen, points);
        }

    }
}
