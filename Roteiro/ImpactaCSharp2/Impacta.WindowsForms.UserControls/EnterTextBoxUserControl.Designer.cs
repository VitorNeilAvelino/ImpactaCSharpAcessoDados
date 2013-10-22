namespace Impacta.Apoio.WindowsForms.Controles
{
    partial class EnterTextBoxUserControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.enterTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // enterTextBox
            // 
            this.enterTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.enterTextBox.Location = new System.Drawing.Point(0, 0);
            this.enterTextBox.Name = "enterTextBox";
            this.enterTextBox.Size = new System.Drawing.Size(363, 20);
            this.enterTextBox.TabIndex = 0;
            this.enterTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enterTextBox_KeyDown);
            // 
            // EnterTextBoxUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.enterTextBox);
            this.Name = "EnterTextBoxUserControl";
            this.Size = new System.Drawing.Size(363, 23);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox enterTextBox;
    }
}
