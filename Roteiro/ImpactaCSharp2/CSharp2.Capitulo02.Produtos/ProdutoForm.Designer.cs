namespace CSharp2.Capitulo02.Produtos
{
    partial class ProdutoForm
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
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.custoTextBox = new System.Windows.Forms.TextBox();
            this.tipoComboBox = new System.Windows.Forms.ComboBox();
            this.gravarButton = new System.Windows.Forms.Button();
            this.produtoErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pedidosDataSet = new CSharp2.Capitulo02.Produtos.PedidosDataSet();
            this.tipoProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoProdutoTableAdapter = new CSharp2.Capitulo02.Produtos.PedidosDataSetTableAdapters.TipoProdutoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.produtoErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProdutoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Descrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "&Custo";
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descricaoTextBox.Location = new System.Drawing.Point(73, 6);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(399, 20);
            this.descricaoTextBox.TabIndex = 1;
            this.descricaoTextBox.Tag = "*";
            // 
            // custoTextBox
            // 
            this.custoTextBox.Location = new System.Drawing.Point(73, 98);
            this.custoTextBox.Name = "custoTextBox";
            this.custoTextBox.Size = new System.Drawing.Size(121, 20);
            this.custoTextBox.TabIndex = 5;
            this.custoTextBox.Tag = "*DECIMAL";
            this.custoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.custoTextBox_KeyPress);
            // 
            // tipoComboBox
            // 
            this.tipoComboBox.DataSource = this.tipoProdutoBindingSource;
            this.tipoComboBox.DisplayMember = "Descricao";
            this.tipoComboBox.FormattingEnabled = true;
            this.tipoComboBox.Location = new System.Drawing.Point(73, 52);
            this.tipoComboBox.Name = "tipoComboBox";
            this.tipoComboBox.Size = new System.Drawing.Size(121, 21);
            this.tipoComboBox.TabIndex = 3;
            this.tipoComboBox.Tag = "*";
            this.tipoComboBox.ValueMember = "Id";
            // 
            // gravarButton
            // 
            this.gravarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gravarButton.Location = new System.Drawing.Point(417, 295);
            this.gravarButton.Name = "gravarButton";
            this.gravarButton.Size = new System.Drawing.Size(75, 23);
            this.gravarButton.TabIndex = 6;
            this.gravarButton.Text = "&Gravar";
            this.gravarButton.UseVisualStyleBackColor = true;
            this.gravarButton.Click += new System.EventHandler(this.gravarButton_Click);
            // 
            // produtoErrorProvider
            // 
            this.produtoErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.produtoErrorProvider.ContainerControl = this;
            // 
            // pedidosDataSet
            // 
            this.pedidosDataSet.DataSetName = "PedidosDataSet";
            this.pedidosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipoProdutoBindingSource
            // 
            this.tipoProdutoBindingSource.DataMember = "TipoProduto";
            this.tipoProdutoBindingSource.DataSource = this.pedidosDataSet;
            // 
            // tipoProdutoTableAdapter
            // 
            this.tipoProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // ProdutoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 330);
            this.Controls.Add(this.gravarButton);
            this.Controls.Add(this.tipoComboBox);
            this.Controls.Add(this.custoTextBox);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProdutoForm";
            this.Text = "Produto";
            this.Load += new System.EventHandler(this.ProdutoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produtoErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProdutoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.TextBox custoTextBox;
        private System.Windows.Forms.ComboBox tipoComboBox;
        private System.Windows.Forms.Button gravarButton;
        private System.Windows.Forms.ErrorProvider produtoErrorProvider;
        private PedidosDataSet pedidosDataSet;
        private System.Windows.Forms.BindingSource tipoProdutoBindingSource;
        private PedidosDataSetTableAdapters.TipoProdutoTableAdapter tipoProdutoTableAdapter;
    }
}

