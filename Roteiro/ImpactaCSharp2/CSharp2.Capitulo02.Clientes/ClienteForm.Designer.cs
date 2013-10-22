using Impacta.Apoio.WindowsForms.Controles;

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
            this.gravarButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.clienteErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.emailEnterTextBox = new Impacta.Apoio.WindowsForms.Controles.EnterTextBox();
            this.nomeEnterTextBox = new Impacta.Apoio.WindowsForms.Controles.EnterTextBox();
            this.nascimentoEnterMaskedTextBox = new Impacta.Apoio.WindowsForms.Controles.EnterMaskedTextBox();
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
            // gravarButton
            // 
            this.gravarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gravarButton.Location = new System.Drawing.Point(477, 300);
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
            this.label4.Location = new System.Drawing.Point(-1, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(574, 2);
            this.label4.TabIndex = 7;
            // 
            // clienteErrorProvider
            // 
            this.clienteErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.clienteErrorProvider.ContainerControl = this;
            // 
            // emailEnterTextBox
            // 
            this.emailEnterTextBox.Location = new System.Drawing.Point(84, 98);
            this.emailEnterTextBox.Name = "emailEnterTextBox";
            this.emailEnterTextBox.Size = new System.Drawing.Size(389, 20);
            this.emailEnterTextBox.TabIndex = 5;
            this.emailEnterTextBox.Tag = "*EMAIL";
            // 
            // nomeEnterTextBox
            // 
            this.nomeEnterTextBox.Location = new System.Drawing.Point(84, 6);
            this.nomeEnterTextBox.Name = "nomeEnterTextBox";
            this.nomeEnterTextBox.Size = new System.Drawing.Size(389, 20);
            this.nomeEnterTextBox.TabIndex = 1;
            this.nomeEnterTextBox.Tag = "*";
            // 
            // nascimentoEnterMaskedTextBox
            // 
            this.nascimentoEnterMaskedTextBox.Location = new System.Drawing.Point(84, 52);
            this.nascimentoEnterMaskedTextBox.Mask = "00/00/0000";
            this.nascimentoEnterMaskedTextBox.Name = "nascimentoEnterMaskedTextBox";
            this.nascimentoEnterMaskedTextBox.Size = new System.Drawing.Size(389, 20);
            this.nascimentoEnterMaskedTextBox.TabIndex = 3;
            this.nascimentoEnterMaskedTextBox.Tag = "*DATETIME";
            this.nascimentoEnterMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // ClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 326);
            this.Controls.Add(this.nascimentoEnterMaskedTextBox);
            this.Controls.Add(this.emailEnterTextBox);
            this.Controls.Add(this.nomeEnterTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gravarButton);
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
        private System.Windows.Forms.Button gravarButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider clienteErrorProvider;
        private EnterTextBox nomeEnterTextBox;
        private EnterTextBox emailEnterTextBox;
        private EnterMaskedTextBox nascimentoEnterMaskedTextBox;
    }
}

