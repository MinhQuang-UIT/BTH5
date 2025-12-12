namespace BTH5_24521470_Bai09
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
            cbx_hinh = new ComboBox();
            SuspendLayout();
            // 
            // cbx_hinh
            // 
            cbx_hinh.FormattingEnabled = true;
            cbx_hinh.Items.AddRange(new object[] { "Circle", "Square", "Ellipse", "Pie", "Filled Circle", "Filled Square", "Filled Ellipse", "Filled Pie" });
            cbx_hinh.Location = new Point(39, 28);
            cbx_hinh.Name = "cbx_hinh";
            cbx_hinh.Size = new Size(151, 28);
            cbx_hinh.TabIndex = 0;
            cbx_hinh.SelectedIndexChanged += cbx_hinh_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 453);
            Controls.Add(cbx_hinh);
            Name = "Form1";
            Text = "ComboBoxTest";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbx_hinh;
    }
}
