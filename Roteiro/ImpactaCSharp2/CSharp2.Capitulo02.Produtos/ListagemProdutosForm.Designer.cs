namespace CSharp2.Capitulo02.Produtos
{
    partial class ListagemProdutosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListagemProdutosForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.descricaoToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.pesquisarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.novoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.imprimirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.produtosDataGridView = new System.Windows.Forms.DataGridView();
            this.produtoIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editarProdutoColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.excluirProdutoColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.descricaoToolStripTextBox,
            this.pesquisarToolStripButton,
            this.toolStripSeparator1,
            this.novoToolStripButton,
            this.toolStripSeparator2,
            this.imprimirToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(865, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // descricaoToolStripTextBox
            // 
            this.descricaoToolStripTextBox.Name = "descricaoToolStripTextBox";
            this.descricaoToolStripTextBox.Size = new System.Drawing.Size(300, 25);
            this.descricaoToolStripTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.descricaoToolStripTextBox_KeyDown);
            // 
            // pesquisarToolStripButton
            // 
            this.pesquisarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pesquisarToolStripButton.Image")));
            this.pesquisarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pesquisarToolStripButton.Name = "pesquisarToolStripButton";
            this.pesquisarToolStripButton.Size = new System.Drawing.Size(77, 22);
            this.pesquisarToolStripButton.Text = "Pesquisar";
            this.pesquisarToolStripButton.Click += new System.EventHandler(this.pesquisarToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // novoToolStripButton
            // 
            this.novoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("novoToolStripButton.Image")));
            this.novoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.novoToolStripButton.Name = "novoToolStripButton";
            this.novoToolStripButton.Size = new System.Drawing.Size(56, 22);
            this.novoToolStripButton.Text = "Novo";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // imprimirToolStripButton
            // 
            this.imprimirToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("imprimirToolStripButton.Image")));
            this.imprimirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.imprimirToolStripButton.Name = "imprimirToolStripButton";
            this.imprimirToolStripButton.Size = new System.Drawing.Size(73, 22);
            this.imprimirToolStripButton.Text = "Imprimir";
            // 
            // produtosDataGridView
            // 
            this.produtosDataGridView.AllowUserToAddRows = false;
            this.produtosDataGridView.AllowUserToDeleteRows = false;
            this.produtosDataGridView.AllowUserToOrderColumns = true;
            this.produtosDataGridView.AllowUserToResizeRows = false;
            this.produtosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.produtosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produtosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.produtoIdColumn,
            this.Column1,
            this.Column2,
            this.Column3,
            this.editarProdutoColumn,
            this.excluirProdutoColumn});
            this.produtosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.produtosDataGridView.Location = new System.Drawing.Point(0, 25);
            this.produtosDataGridView.Name = "produtosDataGridView";
            this.produtosDataGridView.ReadOnly = true;
            this.produtosDataGridView.Size = new System.Drawing.Size(865, 361);
            this.produtosDataGridView.TabIndex = 1;
            this.produtosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.produtosDataGridView_CellContentClick);
            // 
            // produtoIdColumn
            // 
            this.produtoIdColumn.DataPropertyName = "Id";
            this.produtoIdColumn.HeaderText = "";
            this.produtoIdColumn.Name = "produtoIdColumn";
            this.produtoIdColumn.ReadOnly = true;
            this.produtoIdColumn.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Descricao";
            this.Column1.HeaderText = "Descrição";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "DescricaoTipoProduto";
            this.Column2.HeaderText = "Tipo";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Custo";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column3.HeaderText = "Custo";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // editarProdutoColumn
            // 
            this.editarProdutoColumn.HeaderText = "";
            this.editarProdutoColumn.Name = "editarProdutoColumn";
            this.editarProdutoColumn.ReadOnly = true;
            this.editarProdutoColumn.Text = "Editar";
            this.editarProdutoColumn.UseColumnTextForButtonValue = true;
            // 
            // excluirProdutoColumn
            // 
            this.excluirProdutoColumn.HeaderText = "";
            this.excluirProdutoColumn.Name = "excluirProdutoColumn";
            this.excluirProdutoColumn.ReadOnly = true;
            this.excluirProdutoColumn.Text = "Excluir";
            this.excluirProdutoColumn.UseColumnTextForButtonValue = true;
            // 
            // ListagemProdutosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 386);
            this.Controls.Add(this.produtosDataGridView);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ListagemProdutosForm";
            this.Text = "Produtos";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox descricaoToolStripTextBox;
        private System.Windows.Forms.ToolStripButton pesquisarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton novoToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton imprimirToolStripButton;
        private System.Windows.Forms.DataGridView produtosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtoIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn editarProdutoColumn;
        private System.Windows.Forms.DataGridViewButtonColumn excluirProdutoColumn;
    }
}