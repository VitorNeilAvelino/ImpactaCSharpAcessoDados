namespace CSharp2.Capitulo02.Clientes
{
    partial class ListagemClientesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListagemClientesForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.nomePesquisadoToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.pesquisarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.novoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.imprimirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.clientesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.idClienteColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nascimentoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editarClienteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.excluirClienteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nomePesquisadoToolStripTextBox,
            this.pesquisarToolStripButton,
            this.toolStripSeparator1,
            this.novoToolStripButton,
            this.toolStripSeparator2,
            this.imprimirToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // nomePesquisadoToolStripTextBox
            // 
            this.nomePesquisadoToolStripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomePesquisadoToolStripTextBox.Name = "nomePesquisadoToolStripTextBox";
            this.nomePesquisadoToolStripTextBox.Size = new System.Drawing.Size(300, 25);
            this.nomePesquisadoToolStripTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nomePesquisadoToolStripTextBox_KeyDown);
            // 
            // pesquisarToolStripButton
            // 
            this.pesquisarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pesquisarToolStripButton.Image")));
            this.pesquisarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pesquisarToolStripButton.Name = "pesquisarToolStripButton";
            this.pesquisarToolStripButton.Size = new System.Drawing.Size(77, 22);
            this.pesquisarToolStripButton.Text = "&Pesquisar";
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
            this.novoToolStripButton.Text = "&Novo";
            this.novoToolStripButton.Click += new System.EventHandler(this.novoToolStripButton_Click);
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
            this.imprimirToolStripButton.Text = "&Imprimir";
            this.imprimirToolStripButton.Click += new System.EventHandler(this.imprimirToolStripButton_Click);
            // 
            // clientesDataGridView
            // 
            this.clientesDataGridView.AllowUserToAddRows = false;
            this.clientesDataGridView.AllowUserToDeleteRows = false;
            this.clientesDataGridView.AllowUserToResizeRows = false;
            this.clientesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClienteColumn,
            this.nomeColumn,
            this.nascimentoColumn,
            this.emailColumn,
            this.tipoColumn,
            this.editarClienteColumn,
            this.excluirClienteColumn});
            this.clientesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientesDataGridView.Location = new System.Drawing.Point(0, 25);
            this.clientesDataGridView.Name = "clientesDataGridView";
            this.clientesDataGridView.ReadOnly = true;
            this.clientesDataGridView.RowHeadersVisible = false;
            this.clientesDataGridView.Size = new System.Drawing.Size(784, 325);
            this.clientesDataGridView.TabIndex = 1;
            this.clientesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientesDataGridView_CellContentClick);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = global::CSharp2.Capitulo02.Clientes.Properties.Resources.editarIcone1;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // idClienteColumn
            // 
            this.idClienteColumn.DataPropertyName = "Id";
            this.idClienteColumn.HeaderText = "Id";
            this.idClienteColumn.Name = "idClienteColumn";
            this.idClienteColumn.ReadOnly = true;
            this.idClienteColumn.Visible = false;
            // 
            // nomeColumn
            // 
            this.nomeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeColumn.DataPropertyName = "Nome";
            this.nomeColumn.HeaderText = "Nome";
            this.nomeColumn.Name = "nomeColumn";
            this.nomeColumn.ReadOnly = true;
            // 
            // nascimentoColumn
            // 
            this.nascimentoColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nascimentoColumn.DataPropertyName = "DataNascimento";
            this.nascimentoColumn.HeaderText = "Nascimento";
            this.nascimentoColumn.Name = "nascimentoColumn";
            this.nascimentoColumn.ReadOnly = true;
            // 
            // emailColumn
            // 
            this.emailColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailColumn.DataPropertyName = "Email";
            this.emailColumn.HeaderText = "Email";
            this.emailColumn.MinimumWidth = 200;
            this.emailColumn.Name = "emailColumn";
            this.emailColumn.ReadOnly = true;
            // 
            // tipoColumn
            // 
            this.tipoColumn.DataPropertyName = "Tipo";
            this.tipoColumn.HeaderText = "Tipo";
            this.tipoColumn.Name = "tipoColumn";
            this.tipoColumn.ReadOnly = true;
            // 
            // editarClienteColumn
            // 
            this.editarClienteColumn.HeaderText = "";
            this.editarClienteColumn.Name = "editarClienteColumn";
            this.editarClienteColumn.ReadOnly = true;
            this.editarClienteColumn.Text = "Editar";
            this.editarClienteColumn.UseColumnTextForButtonValue = true;
            // 
            // excluirClienteColumn
            // 
            this.excluirClienteColumn.DataPropertyName = "Id";
            this.excluirClienteColumn.HeaderText = "";
            this.excluirClienteColumn.Name = "excluirClienteColumn";
            this.excluirClienteColumn.ReadOnly = true;
            this.excluirClienteColumn.Text = "Excluir";
            this.excluirClienteColumn.UseColumnTextForButtonValue = true;
            // 
            // ListagemClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 350);
            this.Controls.Add(this.clientesDataGridView);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ListagemClientesForm";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.ListagemClientesForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox nomePesquisadoToolStripTextBox;
        private System.Windows.Forms.ToolStripButton pesquisarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton novoToolStripButton;
        private System.Windows.Forms.DataGridView clientesDataGridView;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton imprimirToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nascimentoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoColumn;
        private System.Windows.Forms.DataGridViewButtonColumn editarClienteColumn;
        private System.Windows.Forms.DataGridViewButtonColumn excluirClienteColumn;
    }
}