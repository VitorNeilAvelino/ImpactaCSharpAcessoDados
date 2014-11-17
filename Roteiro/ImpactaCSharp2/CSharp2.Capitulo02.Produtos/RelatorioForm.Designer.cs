namespace CSharp2.Capitulo02.Produtos
{
    partial class RelatorioForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ProdutoDataSet = new CSharp2.Capitulo02.Produtos.ProdutoDataSet();
            this.SelecionarProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SelecionarProdutoTableAdapter = new CSharp2.Capitulo02.Produtos.ProdutoDataSetTableAdapters.SelecionarProdutoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ProdutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdutoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelecionarProdutoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ProdutoBindingSource
            // 
            this.ProdutoBindingSource.DataSource = typeof(Impacta.Dominio.Produto);
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ProdutoDataSet";
            reportDataSource1.Value = this.SelecionarProdutoBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "CSharp2.Capitulo02.Produtos.ProdutoProcedureReport.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.ReportPath = "/Produtos";
            this.reportViewer.ServerReport.ReportServerUrl = new System.Uri("http://vt3/ReportServer_SQLEXPRESS", System.UriKind.Absolute);
            this.reportViewer.Size = new System.Drawing.Size(775, 525);
            this.reportViewer.TabIndex = 0;
            // 
            // ProdutoDataSet
            // 
            this.ProdutoDataSet.DataSetName = "ProdutoDataSet";
            this.ProdutoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SelecionarProdutoBindingSource
            // 
            this.SelecionarProdutoBindingSource.DataMember = "SelecionarProduto";
            this.SelecionarProdutoBindingSource.DataSource = this.ProdutoDataSet;
            // 
            // SelecionarProdutoTableAdapter
            // 
            this.SelecionarProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // RelatorioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 525);
            this.Controls.Add(this.reportViewer);
            this.Name = "RelatorioForm";
            this.Text = "Relatório";
            this.Load += new System.EventHandler(this.RelatorioForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProdutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdutoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelecionarProdutoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.BindingSource ProdutoBindingSource;
        private System.Windows.Forms.BindingSource SelecionarProdutoBindingSource;
        private ProdutoDataSet ProdutoDataSet;
        private ProdutoDataSetTableAdapters.SelecionarProdutoTableAdapter SelecionarProdutoTableAdapter;
    }
}