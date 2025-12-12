namespace BTH5_24521470_Bai06
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
            listbox_font = new ListBox();
            SuspendLayout();
            // 
            // listbox_font
            // 
            listbox_font.DrawMode = DrawMode.OwnerDrawVariable;
            listbox_font.FormattingEnabled = true;
            listbox_font.HorizontalExtent = 360;
            listbox_font.HorizontalScrollbar = true;
            listbox_font.IntegralHeight = false;
            listbox_font.Location = new Point(22, 12);
            listbox_font.Name = "listbox_font";
            listbox_font.Size = new Size(458, 638);
            listbox_font.TabIndex = 0;
            listbox_font.DrawItem += listbox_font_DrawItem;
            listbox_font.MeasureItem += listbox_font_MeasureItem;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(507, 662);
            Controls.Add(listbox_font);
            Name = "Form1";
            Text = "All Fonts";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listbox_font;
    }
}
