namespace CSharp2.Capitulo02.Clientes
{
    partial class ClienteForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.gravarButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.clienteErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.nascimentoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.clienteErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nascimento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nomeTextBox.Location = new System.Drawing.Point(84, 6);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(344, 20);
            this.nomeTextBox.TabIndex = 1;
            this.nomeTextBox.Tag = "*";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailTextBox.Location = new System.Drawing.Point(84, 98);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(344, 20);
            this.emailTextBox.TabIndex = 5;
            this.emailTextBox.Tag = "EMAIL";
            // 
            // gravarButton
            // 
            this.gravarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gravarButton.Location = new System.Drawing.Point(429, 126);
            this.gravarButton.Name = "gravarButton";
            this.gravarButton.Size = new System.Drawing.Size(75, 23);
            this.gravarButton.TabIndex = 6;
            this.gravarButton.Text = "&Gravar";
            this.gravarButton.UseVisualStyleBackColor = true;
            this.gravarButton.Click += new System.EventHandler(this.gravarButton_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(-1, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(526, 2);
            this.label4.TabIndex = 3;
            // 
            // clienteErrorProvider
            // 
            this.clienteErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.clienteErrorProvider.ContainerControl = this;
            // 
            // nascimentoMaskedTextBox
            // 
            this.nascimentoMaskedTextBox.Location = new System.Drawing.Point(84, 52);
            this.nascimentoMaskedTextBox.Mask = "00/00/0000";
            this.nascimentoMaskedTextBox.Name = "nascimentoMaskedTextBox";
            this.nascimentoMaskedTextBox.Size = new System.Drawing.Size(344, 20);
            this.nascimentoMaskedTextBox.TabIndex = 3;
            this.nascimentoMaskedTextBox.Tag = "*DATETIME";
            this.nascimentoMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // ClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 152);
            this.Controls.Add(this.nascimentoMaskedTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gravarButton);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ClienteForm";
            this.Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.clienteErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button gravarButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider clienteErrorProvider;
        private System.Windows.Forms.MaskedTextBox nascimentoMaskedTextBox;
    }
}

