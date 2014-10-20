namespace CSharp2.Capitulo02.Produtos
{
    partial class TipoProdutoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TipoProdutoForm));
            this.pedidosDataSet = new CSharp2.Capitulo02.Produtos.PedidosDataSet();
            this.tipoProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoProdutoTableAdapter = new CSharp2.Capitulo02.Produtos.PedidosDataSetTableAdapters.TipoProdutoTableAdapter();
            this.tableAdapterManager = new CSharp2.Capitulo02.Produtos.PedidosDataSetTableAdapters.TableAdapterManager();
            this.tipoProdutoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tipoProdutoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tipoProdutoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProdutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProdutoBindingNavigator)).BeginInit();
            this.tipoProdutoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProdutoDataGridView)).BeginInit();
            this.SuspendLayout();
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TipoProdutoTableAdapter = this.tipoProdutoTableAdapter;
            this.tableAdapterManager.UpdateOrder = CSharp2.Capitulo02.Produtos.PedidosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tipoProdutoBindingNavigator
            // 
            this.tipoProdutoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tipoProdutoBindingNavigator.BindingSource = this.tipoProdutoBindingSource;
            this.tipoProdutoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tipoProdutoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tipoProdutoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tipoProdutoBindingNavigatorSaveItem});
            this.tipoProdutoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tipoProdutoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tipoProdutoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tipoProdutoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tipoProdutoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tipoProdutoBindingNavigator.Name = "tipoProdutoBindingNavigator";
            this.tipoProdutoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tipoProdutoBindingNavigator.Size = new System.Drawing.Size(563, 25);
            this.tipoProdutoBindingNavigator.TabIndex = 0;
            this.tipoProdutoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // tipoProdutoBindingNavigatorSaveItem
            // 
            this.tipoProdutoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tipoProdutoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tipoProdutoBindingNavigatorSaveItem.Image")));
            this.tipoProdutoBindingNavigatorSaveItem.Name = "tipoProdutoBindingNavigatorSaveItem";
            this.tipoProdutoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tipoProdutoBindingNavigatorSaveItem.Text = "Save Data";
            this.tipoProdutoBindingNavigatorSaveItem.Click += new System.EventHandler(this.tipoProdutoBindingNavigatorSaveItem_Click);
            // 
            // tipoProdutoDataGridView
            // 
            this.tipoProdutoDataGridView.AutoGenerateColumns = false;
            this.tipoProdutoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tipoProdutoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tipoProdutoDataGridView.DataSource = this.tipoProdutoBindingSource;
            this.tipoProdutoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tipoProdutoDataGridView.Location = new System.Drawing.Point(0, 25);
            this.tipoProdutoDataGridView.Name = "tipoProdutoDataGridView";
            this.tipoProdutoDataGridView.Size = new System.Drawing.Size(563, 365);
            this.tipoProdutoDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descricao";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // TipoProdutoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 390);
            this.Controls.Add(this.tipoProdutoDataGridView);
            this.Controls.Add(this.tipoProdutoBindingNavigator);
            this.Name = "TipoProdutoForm";
            this.Text = "TipoProdutoForm";
            this.Load += new System.EventHandler(this.TipoProdutoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pedidosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProdutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProdutoBindingNavigator)).EndInit();
            this.tipoProdutoBindingNavigator.ResumeLayout(false);
            this.tipoProdutoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProdutoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PedidosDataSet pedidosDataSet;
        private System.Windows.Forms.BindingSource tipoProdutoBindingSource;
        private PedidosDataSetTableAdapters.TipoProdutoTableAdapter tipoProdutoTableAdapter;
        private PedidosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tipoProdutoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tipoProdutoBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tipoProdutoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}