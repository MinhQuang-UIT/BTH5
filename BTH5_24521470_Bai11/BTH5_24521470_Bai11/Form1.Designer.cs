namespace BTH5_24521470_Bai11
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
            groupBox1 = new GroupBox();
            rdb_ellipse = new RadioButton();
            rdb_rectangle = new RadioButton();
            rdb_line = new RadioButton();
            ptb_shape = new PictureBox();
            groupBox2 = new GroupBox();
            tb_width = new TextBox();
            bt_color = new Button();
            label1 = new Label();
            groupBox3 = new GroupBox();
            rdb_linearGradient = new RadioButton();
            rdb_texturebrush = new RadioButton();
            rdb_hatchbrush = new RadioButton();
            rdb_solidbrush = new RadioButton();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_shape).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdb_ellipse);
            groupBox1.Controls.Add(rdb_rectangle);
            groupBox1.Controls.Add(rdb_line);
            groupBox1.Location = new Point(31, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(226, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Shapes";
            // 
            // rdb_ellipse
            // 
            rdb_ellipse.AutoSize = true;
            rdb_ellipse.Location = new Point(6, 95);
            rdb_ellipse.Name = "rdb_ellipse";
            rdb_ellipse.Size = new Size(73, 24);
            rdb_ellipse.TabIndex = 2;
            rdb_ellipse.TabStop = true;
            rdb_ellipse.Text = "Ellipse";
            rdb_ellipse.UseVisualStyleBackColor = true;
            rdb_ellipse.CheckedChanged += rdb_ellipse_CheckedChanged;
            // 
            // rdb_rectangle
            // 
            rdb_rectangle.AutoSize = true;
            rdb_rectangle.Location = new Point(6, 56);
            rdb_rectangle.Name = "rdb_rectangle";
            rdb_rectangle.Size = new Size(96, 24);
            rdb_rectangle.TabIndex = 1;
            rdb_rectangle.TabStop = true;
            rdb_rectangle.Text = "Rectangle";
            rdb_rectangle.UseVisualStyleBackColor = true;
            rdb_rectangle.CheckedChanged += rdb_rectangle_CheckedChanged;
            // 
            // rdb_line
            // 
            rdb_line.AutoSize = true;
            rdb_line.Location = new Point(6, 26);
            rdb_line.Name = "rdb_line";
            rdb_line.Size = new Size(57, 24);
            rdb_line.TabIndex = 0;
            rdb_line.TabStop = true;
            rdb_line.Text = "Line";
            rdb_line.UseVisualStyleBackColor = true;
            rdb_line.CheckedChanged += rdb_line_CheckedChanged;
            // 
            // ptb_shape
            // 
            ptb_shape.BackColor = Color.White;
            ptb_shape.Location = new Point(292, 0);
            ptb_shape.Name = "ptb_shape";
            ptb_shape.Size = new Size(510, 628);
            ptb_shape.TabIndex = 1;
            ptb_shape.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tb_width);
            groupBox2.Controls.Add(bt_color);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(31, 173);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(226, 125);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pen";
            // 
            // tb_width
            // 
            tb_width.Location = new Point(64, 30);
            tb_width.Name = "tb_width";
            tb_width.Size = new Size(79, 27);
            tb_width.TabIndex = 2;
            // 
            // bt_color
            // 
            bt_color.Location = new Point(48, 76);
            bt_color.Name = "bt_color";
            bt_color.Size = new Size(120, 29);
            bt_color.TabIndex = 1;
            bt_color.Text = "Color...";
            bt_color.UseVisualStyleBackColor = true;
            bt_color.Click += bt_color_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 33);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 0;
            label1.Text = "Width:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rdb_linearGradient);
            groupBox3.Controls.Add(rdb_texturebrush);
            groupBox3.Controls.Add(rdb_hatchbrush);
            groupBox3.Controls.Add(rdb_solidbrush);
            groupBox3.Location = new Point(31, 323);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(226, 276);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Brushes";
            // 
            // rdb_linearGradient
            // 
            rdb_linearGradient.AutoSize = true;
            rdb_linearGradient.Location = new Point(17, 168);
            rdb_linearGradient.Name = "rdb_linearGradient";
            rdb_linearGradient.Size = new Size(163, 24);
            rdb_linearGradient.TabIndex = 3;
            rdb_linearGradient.TabStop = true;
            rdb_linearGradient.Text = "LinearGradientBrush";
            rdb_linearGradient.UseVisualStyleBackColor = true;
            // 
            // rdb_texturebrush
            // 
            rdb_texturebrush.AutoSize = true;
            rdb_texturebrush.Location = new Point(17, 126);
            rdb_texturebrush.Name = "rdb_texturebrush";
            rdb_texturebrush.Size = new Size(114, 24);
            rdb_texturebrush.TabIndex = 2;
            rdb_texturebrush.TabStop = true;
            rdb_texturebrush.Text = "TextureBrush";
            rdb_texturebrush.UseVisualStyleBackColor = true;
            // 
            // rdb_hatchbrush
            // 
            rdb_hatchbrush.AutoSize = true;
            rdb_hatchbrush.Location = new Point(17, 81);
            rdb_hatchbrush.Name = "rdb_hatchbrush";
            rdb_hatchbrush.Size = new Size(105, 24);
            rdb_hatchbrush.TabIndex = 1;
            rdb_hatchbrush.TabStop = true;
            rdb_hatchbrush.Text = "HatchBrush";
            rdb_hatchbrush.UseVisualStyleBackColor = true;
            // 
            // rdb_solidbrush
            // 
            rdb_solidbrush.AutoSize = true;
            rdb_solidbrush.Location = new Point(17, 36);
            rdb_solidbrush.Name = "rdb_solidbrush";
            rdb_solidbrush.Size = new Size(100, 24);
            rdb_solidbrush.TabIndex = 0;
            rdb_solidbrush.TabStop = true;
            rdb_solidbrush.Text = "SolidBrush";
            rdb_solidbrush.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 628);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(ptb_shape);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_shape).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rdb_ellipse;
        private RadioButton rdb_rectangle;
        private RadioButton rdb_line;
        private PictureBox ptb_shape;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private RadioButton rdb_linearGradient;
        private RadioButton rdb_texturebrush;
        private RadioButton rdb_hatchbrush;
        private RadioButton rdb_solidbrush;
        private TextBox tb_width;
        private Button bt_color;
        private Label label1;
    }
}
