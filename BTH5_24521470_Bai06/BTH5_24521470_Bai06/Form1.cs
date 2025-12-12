using System.Drawing.Text;

namespace BTH5_24521470_Bai06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            InstalledFontCollection fonts = new InstalledFontCollection();

            FontFamily[] fontFamilies = fonts.Families;

            foreach (FontFamily family in fontFamilies)
            {
                listbox_font.Items.Add(family.Name);
            }
            listbox_font.HorizontalExtent = this.MaxSize();
        }

        private void listbox_font_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0 || e.Index >= listbox_font.Items.Count)
                return;

            string fontName = listbox_font.Items[e.Index].ToString();
            Font newFont = new Font(fontName, e.Font.Size + 5, e.Font.Style);

            string newFontName = ".Vn" + fontName;


            e.Graphics.DrawString(newFontName, newFont, Brushes.Black, e.Bounds.Left, e.Bounds.Top);

        }

        private void listbox_font_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            string fontName = listbox_font.Items[e.Index].ToString();
            Font newFont = new Font(fontName, listbox_font.Font.Size + 5, listbox_font.Font.Style);
            string newFontName = ".Vn" + fontName;

            SizeF size = e.Graphics.MeasureString(newFontName, newFont);

            e.ItemHeight = (int)size.Height + 5;
        }

        private int MaxSize()
        {
            Graphics g = listbox_font.CreateGraphics();
            int maxWidth = 0;
            for (int i = 0; i < listbox_font.Items.Count; i++)
            {
                string fontName = listbox_font.Items[i].ToString();
                Font newFont = new Font(fontName, listbox_font.Font.Size, listbox_font.Font.Style);
                string newFontName = ".Vn" + fontName;

                int width = (int)g.MeasureString(newFontName, newFont).Width;
                maxWidth = Math.Max(maxWidth, width);
            }
            return maxWidth;
        }

       
    }
}
