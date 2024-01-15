

namespace _07_Dict
{
    partial class Frm_Principal
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
            lstAlimento = new ListBox();
            SuspendLayout();
            // 
            // lstAlimento
            // 
            lstAlimento.FormattingEnabled = true;
            lstAlimento.HorizontalScrollbar = true;
            lstAlimento.ItemHeight = 15;
            lstAlimento.Location = new Point(13, 13);
            lstAlimento.Name = "lstAlimento";
            lstAlimento.Size = new Size(517, 379);
            lstAlimento.TabIndex = 0;
            // 
            // Frm_Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstAlimento);
            Name = "Frm_Principal";
            Text = "Form1";
            ResumeLayout(false);
        }





        #endregion

        private ListBox lstAlimento;
    }
}
