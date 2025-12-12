namespace BTH5_24521470_Bai10
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
            label1 = new Label();
            lb_width = new Label();
            lb_linejoin = new Label();
            lb_dashcap = new Label();
            lb_startcap = new Label();
            lb_endcap = new Label();
            cbx_dashstyle = new ComboBox();
            cbx_width = new ComboBox();
            cbx_linejoin = new ComboBox();
            cbx_dashcap = new ComboBox();
            cbx_startcap = new ComboBox();
            cbx_endcap = new ComboBox();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 41);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 0;
            label1.Text = "Dash Style :";
            // 
            // lb_width
            // 
            lb_width.AutoSize = true;
            lb_width.Location = new Point(12, 96);
            lb_width.Name = "lb_width";
            lb_width.Size = new Size(56, 20);
            lb_width.TabIndex = 1;
            lb_width.Text = "Width :";
            // 
            // lb_linejoin
            // 
            lb_linejoin.AutoSize = true;
            lb_linejoin.Location = new Point(12, 146);
            lb_linejoin.Name = "lb_linejoin";
            lb_linejoin.Size = new Size(73, 20);
            lb_linejoin.TabIndex = 2;
            lb_linejoin.Text = "Line Join :";
            // 
            // lb_dashcap
            // 
            lb_dashcap.AutoSize = true;
            lb_dashcap.Location = new Point(6, 200);
            lb_dashcap.Name = "lb_dashcap";
            lb_dashcap.Size = new Size(79, 20);
            lb_dashcap.TabIndex = 3;
            lb_dashcap.Text = "Dash Cap :";
            // 
            // lb_startcap
            // 
            lb_startcap.AutoSize = true;
            lb_startcap.Location = new Point(6, 255);
            lb_startcap.Name = "lb_startcap";
            lb_startcap.Size = new Size(77, 20);
            lb_startcap.TabIndex = 4;
            lb_startcap.Text = "Start Cap :";
            // 
            // lb_endcap
            // 
            lb_endcap.AutoSize = true;
            lb_endcap.Location = new Point(6, 310);
            lb_endcap.Name = "lb_endcap";
            lb_endcap.Size = new Size(71, 20);
            lb_endcap.TabIndex = 5;
            lb_endcap.Text = "End Cap :";
            // 
            // cbx_dashstyle
            // 
            cbx_dashstyle.FormattingEnabled = true;
            cbx_dashstyle.Items.AddRange(new object[] { "Custom", "Dash", "DashDot", "DashDotDot", "Dot", "Solid" });
            cbx_dashstyle.Location = new Point(106, 38);
            cbx_dashstyle.Name = "cbx_dashstyle";
            cbx_dashstyle.Size = new Size(151, 28);
            cbx_dashstyle.TabIndex = 6;
            cbx_dashstyle.SelectedIndexChanged += cbx_dashstyle_SelectedIndexChanged;
            // 
            // cbx_width
            // 
            cbx_width.FormattingEnabled = true;
            cbx_width.Items.AddRange(new object[] { "1", "2", "4", "6", "8", "10", "12", "14", "16", "18", "20" });
            cbx_width.Location = new Point(106, 88);
            cbx_width.Name = "cbx_width";
            cbx_width.Size = new Size(151, 28);
            cbx_width.TabIndex = 7;
            cbx_width.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // cbx_linejoin
            // 
            cbx_linejoin.FormattingEnabled = true;
            cbx_linejoin.Items.AddRange(new object[] { "Miter", "Bevel", "Round", "MiterClipped" });
            cbx_linejoin.Location = new Point(106, 138);
            cbx_linejoin.Name = "cbx_linejoin";
            cbx_linejoin.Size = new Size(151, 28);
            cbx_linejoin.TabIndex = 8;
            cbx_linejoin.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // cbx_dashcap
            // 
            cbx_dashcap.FormattingEnabled = true;
            cbx_dashcap.Items.AddRange(new object[] { "Flat", "Round", "Triangle" });
            cbx_dashcap.Location = new Point(106, 192);
            cbx_dashcap.Name = "cbx_dashcap";
            cbx_dashcap.Size = new Size(151, 28);
            cbx_dashcap.TabIndex = 9;
            cbx_dashcap.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // cbx_startcap
            // 
            cbx_startcap.FormattingEnabled = true;
            cbx_startcap.Items.AddRange(new object[] { "ArrowAnchor", "Custom", "DiamondAnchor", "Flat", "Round", "RoundAnchor", "Square", "SquareAnchor", "Triangle" });
            cbx_startcap.Location = new Point(106, 247);
            cbx_startcap.Name = "cbx_startcap";
            cbx_startcap.Size = new Size(151, 28);
            cbx_startcap.TabIndex = 10;
            cbx_startcap.SelectedIndexChanged += comboBox5_SelectedIndexChanged;
            // 
            // cbx_endcap
            // 
            cbx_endcap.FormattingEnabled = true;
            cbx_endcap.Items.AddRange(new object[] { "ArrowAnchor", "Custom", "DiamondAnchor", "Flat", "Round", "RoundAnchor", "Square", "SquareAnchor", "Triangle" });
            cbx_endcap.Location = new Point(106, 302);
            cbx_endcap.Name = "cbx_endcap";
            cbx_endcap.Size = new Size(151, 28);
            cbx_endcap.TabIndex = 11;
            cbx_endcap.SelectedIndexChanged += comboBox6_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(330, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(423, 370);
            panel1.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(754, 370);
            Controls.Add(panel1);
            Controls.Add(cbx_endcap);
            Controls.Add(cbx_startcap);
            Controls.Add(cbx_dashcap);
            Controls.Add(cbx_linejoin);
            Controls.Add(cbx_width);
            Controls.Add(cbx_dashstyle);
            Controls.Add(lb_endcap);
            Controls.Add(lb_startcap);
            Controls.Add(lb_dashcap);
            Controls.Add(lb_linejoin);
            Controls.Add(lb_width);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Pen Demo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lb_width;
        private Label lb_linejoin;
        private Label lb_dashcap;
        private Label lb_startcap;
        private Label lb_endcap;
        private ComboBox cbx_dashstyle;
        private ComboBox cbx_width;
        private ComboBox cbx_linejoin;
        private ComboBox cbx_dashcap;
        private ComboBox cbx_startcap;
        private ComboBox cbx_endcap;
        private Panel panel1;
    }
}
