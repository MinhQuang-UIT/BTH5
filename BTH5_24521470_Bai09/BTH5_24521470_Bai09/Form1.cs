namespace BTH5_24521470_Bai09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black, 2);
            Brush brush = new SolidBrush(Color.Red);
            
            if (cbx_hinh.SelectedItem != null)
            {
                string shape = cbx_hinh.SelectedItem.ToString();
                if (shape == "Circle")
                {
                    g.DrawEllipse(pen, 150, 100, 300, 300);
                }
                else if (shape == "Square")
                {
                    g.DrawRectangle(pen, 150, 100, 300, 300);
                }
                else if (shape == "Ellipse")
                {
                    g.DrawEllipse(pen, 150, 150, 300, 200);
                }
                else if (shape == "Pie")
                {
                    g.DrawPie(pen, 150, 150, 300, 200, 135, 270);
                }
                else if (shape == "Filled Circle")
                {
                    g.FillEllipse(brush, 150, 100, 300, 300);
                }
                else if (shape == "Filled Square")
                {
                    g.FillRectangle(brush, 150, 100, 300, 300);
                }
                else if (shape == "Filled Ellipse")
                {
                    g.FillEllipse(brush, 150, 150, 300, 200);
                }
                else if (shape == "Filled Pie")
                {
                    g.FillPie(brush, 150, 150, 300, 200, 135, 270);
                }
            }
        }

        private void cbx_hinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}
