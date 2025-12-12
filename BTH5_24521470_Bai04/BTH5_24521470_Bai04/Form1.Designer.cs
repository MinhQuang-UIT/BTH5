namespace BTH5_24521470_Bai04
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            cb_font = new ComboBox();
            cb_bold = new CheckBox();
            cb_italic = new CheckBox();
            cb_underline = new CheckBox();
            groupBox1 = new GroupBox();
            rdb_right = new RadioButton();
            rdb_center = new RadioButton();
            rdb_left = new RadioButton();
            cb_size = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            bt_color = new Button();
            rtb_noidung = new RichTextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 59);
            label1.Name = "label1";
            label1.Size = new Size(59, 31);
            label1.TabIndex = 0;
            label1.Text = "Font";
            // 
            // cb_font
            // 
            cb_font.FormattingEnabled = true;
            cb_font.Location = new Point(86, 59);
            cb_font.Name = "cb_font";
            cb_font.Size = new Size(236, 28);
            cb_font.TabIndex = 1;
            cb_font.Text = "Segoe UI";
            cb_font.SelectedIndexChanged += cb_font_SelectedIndexChanged;
            // 
            // cb_bold
            // 
            cb_bold.Image = (Image)resources.GetObject("cb_bold.Image");
            cb_bold.Location = new Point(37, 129);
            cb_bold.Name = "cb_bold";
            cb_bold.Size = new Size(43, 35);
            cb_bold.TabIndex = 2;
            cb_bold.UseVisualStyleBackColor = true;
            cb_bold.CheckedChanged += cb_bold_CheckedChanged;
            // 
            // cb_italic
            // 
            cb_italic.Image = (Image)resources.GetObject("cb_italic.Image");
            cb_italic.Location = new Point(114, 124);
            cb_italic.Name = "cb_italic";
            cb_italic.Size = new Size(56, 45);
            cb_italic.TabIndex = 3;
            cb_italic.UseVisualStyleBackColor = true;
            cb_italic.CheckedChanged += cb_italic_CheckedChanged;
            // 
            // cb_underline
            // 
            cb_underline.Image = (Image)resources.GetObject("cb_underline.Image");
            cb_underline.Location = new Point(191, 119);
            cb_underline.Name = "cb_underline";
            cb_underline.Size = new Size(62, 55);
            cb_underline.TabIndex = 4;
            cb_underline.UseVisualStyleBackColor = true;
            cb_underline.CheckedChanged += cb_underline_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdb_right);
            groupBox1.Controls.Add(rdb_center);
            groupBox1.Controls.Add(rdb_left);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(37, 234);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(186, 130);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Align Text";
            // 
            // rdb_right
            // 
            rdb_right.AutoSize = true;
            rdb_right.Location = new Point(16, 89);
            rdb_right.Name = "rdb_right";
            rdb_right.Size = new Size(65, 24);
            rdb_right.TabIndex = 2;
            rdb_right.Text = "Right";
            rdb_right.UseVisualStyleBackColor = true;
            rdb_right.CheckedChanged += rdb_right_CheckedChanged;
            // 
            // rdb_center
            // 
            rdb_center.AutoSize = true;
            rdb_center.Location = new Point(16, 59);
            rdb_center.Name = "rdb_center";
            rdb_center.Size = new Size(73, 24);
            rdb_center.TabIndex = 1;
            rdb_center.Text = "Center";
            rdb_center.UseVisualStyleBackColor = true;
            rdb_center.CheckedChanged += rdb_center_CheckedChanged;
            // 
            // rdb_left
            // 
            rdb_left.AutoSize = true;
            rdb_left.Checked = true;
            rdb_left.Location = new Point(16, 27);
            rdb_left.Name = "rdb_left";
            rdb_left.Size = new Size(55, 24);
            rdb_left.TabIndex = 0;
            rdb_left.TabStop = true;
            rdb_left.Text = "Left";
            rdb_left.UseVisualStyleBackColor = true;
            rdb_left.CheckedChanged += rdb_left_CheckedChanged;
            // 
            // cb_size
            // 
            cb_size.FormattingEnabled = true;
            cb_size.Items.AddRange(new object[] { "8", "9", "10", "11", "12", "14", "16", "18", "20", "22", "24", "26", "28", "36", "48", "72" });
            cb_size.Location = new Point(444, 62);
            cb_size.Name = "cb_size";
            cb_size.Size = new Size(73, 28);
            cb_size.TabIndex = 6;
            cb_size.Text = "9";
            cb_size.SelectedIndexChanged += cb_size_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(368, 59);
            label2.Name = "label2";
            label2.Size = new Size(54, 31);
            label2.TabIndex = 7;
            label2.Text = "Size";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(368, 129);
            label3.Name = "label3";
            label3.Size = new Size(68, 31);
            label3.TabIndex = 8;
            label3.Text = "Color";
            // 
            // bt_color
            // 
            bt_color.Location = new Point(444, 131);
            bt_color.Name = "bt_color";
            bt_color.Size = new Size(41, 29);
            bt_color.TabIndex = 9;
            bt_color.UseVisualStyleBackColor = true;
            bt_color.Click += bt_color_Click;
            // 
            // rtb_noidung
            // 
            rtb_noidung.Location = new Point(276, 260);
            rtb_noidung.Name = "rtb_noidung";
            rtb_noidung.Size = new Size(273, 78);
            rtb_noidung.TabIndex = 10;
            rtb_noidung.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 426);
            Controls.Add(rtb_noidung);
            Controls.Add(bt_color);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cb_size);
            Controls.Add(groupBox1);
            Controls.Add(cb_underline);
            Controls.Add(cb_italic);
            Controls.Add(cb_bold);
            Controls.Add(cb_font);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cb_font;
        private CheckBox cb_bold;
        private CheckBox cb_italic;
        private CheckBox cb_underline;
        private GroupBox groupBox1;
        private ComboBox cb_size;
        private Label label2;
        private Label label3;
        private Button bt_color;
        private RichTextBox rtb_noidung;
        private RadioButton rdb_right;
        private RadioButton rdb_center;
        private RadioButton rdb_left;
    }
}
