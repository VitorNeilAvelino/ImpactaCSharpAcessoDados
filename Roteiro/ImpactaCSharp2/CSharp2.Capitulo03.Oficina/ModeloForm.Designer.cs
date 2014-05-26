namespace CSharp2.Capitulo03.Oficina
{
    partial class ModeloForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModeloForm));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label montadora_IdLabel;
            this.oficinaDataSet = new CSharp2.Capitulo03.Oficina.OficinaDataSet();
            this.modeloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modeloTableAdapter = new CSharp2.Capitulo03.Oficina.OficinaDataSetTableAdapters.ModeloTableAdapter();
            this.tableAdapterManager = new CSharp2.Capitulo03.Oficina.OficinaDataSetTableAdapters.TableAdapterManager();
            this.modeloBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.modeloBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idLabel1 = new System.Windows.Forms.Label();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.montadora_IdComboBox = new System.Windows.Forms.ComboBox();
            idLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            montadora_IdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.oficinaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloBindingNavigator)).BeginInit();
            this.modeloBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // oficinaDataSet
            // 
            this.oficinaDataSet.DataSetName = "OficinaDataSet";
            this.oficinaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // modeloBindingSource
            // 
            this.modeloBindingSource.DataMember = "Modelo";
            this.modeloBindingSource.DataSource = this.oficinaDataSet;
            // 
            // modeloTableAdapter
            // 
            this.modeloTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.ClienteVeiculoTableAdapter = null;
            this.tableAdapterManager.CorTableAdapter = null;
            this.tableAdapterManager.ModeloTableAdapter = this.modeloTableAdapter;
            this.tableAdapterManager.MontadoraTableAdapter = null;
            this.tableAdapterManager.ServicoTableAdapter = null;
            this.tableAdapterManager.TipoServicoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CSharp2.Capitulo03.Oficina.OficinaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VeiculoTableAdapter = null;
            // 
            // modeloBindingNavigator
            // 
            this.modeloBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.modeloBindingNavigator.BindingSource = this.modeloBindingSource;
            this.modeloBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.modeloBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.modeloBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.modeloBindingNavigatorSaveItem});
            this.modeloBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.modeloBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.modeloBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.modeloBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.modeloBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.modeloBindingNavigator.Name = "modeloBindingNavigator";
            this.modeloBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.modeloBindingNavigator.Size = new System.Drawing.Size(514, 25);
            this.modeloBindingNavigator.TabIndex = 0;
            this.modeloBindingNavigator.Text = "bindingNavigator1";
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
            // modeloBindingNavigatorSaveItem
            // 
            this.modeloBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.modeloBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("modeloBindingNavigatorSaveItem.Image")));
            this.modeloBindingNavigatorSaveItem.Name = "modeloBindingNavigatorSaveItem";
            this.modeloBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.modeloBindingNavigatorSaveItem.Text = "Save Data";
            this.modeloBindingNavigatorSaveItem.Click += new System.EventHandler(this.modeloBindingNavigatorSaveItem_Click_1);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(23, 49);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // idLabel1
            // 
            this.idLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modeloBindingSource, "Id", true));
            this.idLabel1.Location = new System.Drawing.Point(102, 49);
            this.idLabel1.Name = "idLabel1";
            this.idLabel1.Size = new System.Drawing.Size(121, 23);
            this.idLabel1.TabIndex = 2;
            this.idLabel1.Text = "label1";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(23, 78);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(58, 13);
            descricaoLabel.TabIndex = 3;
            descricaoLabel.Text = "Descricao:";
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modeloBindingSource, "Descricao", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(102, 75);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(121, 20);
            this.descricaoTextBox.TabIndex = 4;
            // 
            // montadora_IdLabel
            // 
            montadora_IdLabel.AutoSize = true;
            montadora_IdLabel.Location = new System.Drawing.Point(23, 104);
            montadora_IdLabel.Name = "montadora_IdLabel";
            montadora_IdLabel.Size = new System.Drawing.Size(73, 13);
            montadora_IdLabel.TabIndex = 5;
            montadora_IdLabel.Text = "Montadora Id:";
            // 
            // montadora_IdComboBox
            // 
            this.montadora_IdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modeloBindingSource, "Montadora_Id", true));
            this.montadora_IdComboBox.FormattingEnabled = true;
            this.montadora_IdComboBox.Location = new System.Drawing.Point(102, 101);
            this.montadora_IdComboBox.Name = "montadora_IdComboBox";
            this.montadora_IdComboBox.Size = new System.Drawing.Size(121, 21);
            this.montadora_IdComboBox.TabIndex = 6;
            // 
            // ModeloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 387);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idLabel1);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(montadora_IdLabel);
            this.Controls.Add(this.montadora_IdComboBox);
            this.Controls.Add(this.modeloBindingNavigator);
            this.Name = "ModeloForm";
            this.Text = "Modelos";
            this.Load += new System.EventHandler(this.ModeloForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oficinaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloBindingNavigator)).EndInit();
            this.modeloBindingNavigator.ResumeLayout(false);
            this.modeloBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OficinaDataSet oficinaDataSet;
        private System.Windows.Forms.BindingSource modeloBindingSource;
        private OficinaDataSetTableAdapters.ModeloTableAdapter modeloTableAdapter;
        private OficinaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator modeloBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton modeloBindingNavigatorSaveItem;
        private System.Windows.Forms.Label idLabel1;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.ComboBox montadora_IdComboBox;



    }
}

