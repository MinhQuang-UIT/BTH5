using System.Drawing.Drawing2D;

namespace BTH5_24521470_Bai11
{
    public partial class Form1 : Form
    {
        private PointF startPoint;
        private PointF endPoint;
        private bool isClick;
        private Pen pen = new Pen(Color.Black);
        private Bitmap bitmap;
        public Form1()
        {
            InitializeComponent();

            ptb_shape.MouseDown += picturebox_mousedown;
            ptb_shape.MouseUp += picturebox_mouseup;
            ptb_shape.MouseMove += picturebox_mousemove;
            ptb_shape.Paint += picturebox_paint;

            bitmap = Properties.Resources.pexels_robert_stokoe_105922_733148;
            bitmap = new Bitmap(bitmap, new Size(510, 628));

            tb_width.Text = "1";
        }

        private void picturebox_mousedown(object sender, MouseEventArgs e)
        {
            if (rdb_line.Checked && !Check(tb_width.Text))
                MessageBox.Show("Width có dạng số!");
            else
            {
                if (e.Button == MouseButtons.Left)
                {
                    startPoint.X = e.X;
                    startPoint.Y = e.Y;
                    endPoint.X = e.X;
                    endPoint.Y = e.Y;
                    isClick = true;
                }
            }
        }

        private void picturebox_mousemove(object sender, MouseEventArgs e)
        {
            if (isClick)
            {
                endPoint.X = e.X;
                endPoint.Y = e.Y;
                ptb_shape.Invalidate();
            }
        }
        private void picturebox_mouseup(object sender, MouseEventArgs e)
        {
            isClick = false;
        }

        private void bt_color_Click(object sender, EventArgs e)
        {
            ColorDialog cld = new ColorDialog();

            if (cld.ShowDialog() == DialogResult.OK)
            {
                pen.Color = cld.Color;
            }
        }

        private static bool Check(string s)
        {
            foreach (var c in s)
                if (!char.IsDigit(c))
                    return false;
            return true;
        }

        private void picturebox_paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            float x = Math.Min(startPoint.X, endPoint.X);
            float y = Math.Min(startPoint.Y, endPoint.Y);
            float width = Math.Abs(endPoint.X - startPoint.X);
            float height = Math.Abs(endPoint.Y - startPoint.Y);
            RectangleF rec = new RectangleF(x, y, width, height);

            if (rdb_line.Checked)
            {
                if (tb_width.Text != string.Empty)
                {
                    if (Check(tb_width.Text))
                        pen.Width = Convert.ToInt32(tb_width.Text);
                }
                g.DrawLine(pen, startPoint, endPoint);
            }
            else if (rdb_ellipse.Checked)
            {
                if (rdb_solidbrush.Checked)
                {
                    SolidBrush solidBrush = new SolidBrush(Color.Green);
                    g.FillEllipse(solidBrush, rec);
                }
                else if (rdb_hatchbrush.Checked)
                {
                    HatchStyle hatchStyle = HatchStyle.Horizontal;
                    HatchBrush hatchBrush = new HatchBrush(hatchStyle, Color.Blue, Color.Green);
                    g.FillEllipse(hatchBrush, rec);
                }
                else if (rdb_texturebrush.Checked)
                {
                    TextureBrush texture = new TextureBrush(bitmap);
                    g.FillEllipse(texture, rec);
                }
                else if (rdb_linearGradient.Checked)
                {
                    PointF p1 = new PointF(10, startPoint.Y);
                    PointF p2 = new PointF(10, endPoint.Y);
                    if (p1.Equals(p2))
                        p2.X += 1;
                    LinearGradientBrush linearGradientBrush = new LinearGradientBrush(p1, p2, Color.Red, Color.Green);
                    g.FillEllipse(linearGradientBrush, rec);
                }
            }
            else if (rdb_rectangle.Checked)
            {
                if (rdb_solidbrush.Checked)
                {
                    SolidBrush solidBrush = new SolidBrush(Color.Green);
                    g.FillRectangle(solidBrush, rec);
                }
                else if (rdb_hatchbrush.Checked)
                {
                    HatchStyle hatchStyle = HatchStyle.Horizontal;
                    HatchBrush hatchBrush = new HatchBrush(hatchStyle, Color.Blue, Color.Green);
                    g.FillRectangle(hatchBrush, rec);
                }
                else if (rdb_texturebrush.Checked)
                {
                    TextureBrush texture = new TextureBrush(bitmap);
                    g.FillRectangle(texture, rec);
                }
                else if (rdb_linearGradient.Checked)
                {
                    PointF p1 = new PointF(10, startPoint.Y);
                    PointF p2 = new PointF(10, endPoint.Y);
                    if (p1.Equals(p2))
                        p2.X += 1;
                    LinearGradientBrush linearGradientBrush = new LinearGradientBrush(p1, p2, Color.Red, Color.Green);
                    g.FillRectangle(linearGradientBrush, rec);
                }

            }
        }

        private void rdb_line_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_line.Checked)
            {
                groupBox2.Enabled = true;
                groupBox3.Enabled = false;
            }
        }

        private void rdb_rectangle_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_rectangle.Checked)
            {
                groupBox2.Enabled = false;
                groupBox3.Enabled = true;
            }
        }

        private void rdb_ellipse_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_ellipse.Checked)
            {
                groupBox2.Enabled = false;
                groupBox3.Enabled = true;
            }
        }
    }
}
