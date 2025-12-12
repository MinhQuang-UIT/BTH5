using System.Drawing.Text;

namespace BTH5_24521470_Bai04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            InstalledFontCollection installedFont = new InstalledFontCollection();

            FontFamily[] fontFamilies = installedFont.Families;

            foreach (FontFamily family in fontFamilies)
            {
                cb_font.Items.Add(family.Name);
            }

            bt_color.BackColor = Color.Black;
        }

        private void cb_size_SelectedIndexChanged(object sender, EventArgs e)
        {
            Font oldFont = rtb_noidung.Font;
            rtb_noidung.Font = new Font(oldFont.FontFamily, Convert.ToInt32(cb_size.SelectedItem), oldFont.Style);
        }

        private void cb_font_SelectedIndexChanged(object sender, EventArgs e)
        {
            Font oldFont = rtb_noidung.Font;
            rtb_noidung.Font = new Font(cb_font.Text, oldFont.Size, oldFont.Style);
        }

        //CheckBox B
        private void cb_bold_CheckedChanged(object sender, EventArgs e)
        {
            ChangeStyle(FontStyle.Bold);
        }

        //CheckBox I
        private void cb_italic_CheckedChanged(object sender, EventArgs e)
        {
            ChangeStyle(FontStyle.Italic);
        }

        //CheckBox U
        private void cb_underline_CheckedChanged(object sender, EventArgs e)
        {
            ChangeStyle(FontStyle.Underline);
        }

        
        private void ChangeStyle(FontStyle style)
        {
            Font oldFont = rtb_noidung.Font;

            FontStyle newStyle;
            if (oldFont.Style.HasFlag(style))
            {
                newStyle = oldFont.Style & ~style;
            }
            else
                newStyle = oldFont.Style | style;
            rtb_noidung.Font = new Font(oldFont.FontFamily, oldFont.Size, newStyle);

        }

        // RadioButton Left
        private void rdb_left_CheckedChanged(object sender, EventArgs e)
        {
            rtb_noidung.SelectionAlignment = HorizontalAlignment.Left;
        }

        //RadioButton Center
        private void rdb_center_CheckedChanged(object sender, EventArgs e)
        {
            rtb_noidung.SelectionAlignment = HorizontalAlignment.Center;
        }

        //RadioButton Right
        private void rdb_right_CheckedChanged(object sender, EventArgs e)
        {
            rtb_noidung.SelectionAlignment = HorizontalAlignment.Right;
        }

        //Button Color
        private void bt_color_Click(object sender, EventArgs e)
        {
            ColorDialog cld = new ColorDialog();
            
            if ( cld.ShowDialog() == DialogResult.OK)
            {
                bt_color.BackColor = cld.Color;
                rtb_noidung.ForeColor = cld.Color;
            } 
                
        }
    }
}
