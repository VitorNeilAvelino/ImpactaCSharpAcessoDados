namespace CSharp2.Capitulo02.Clientes
{
    partial class RelatorioClientesForm
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
            this.clientesReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ClienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // clientesReportViewer
            // 
            this.clientesReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "clientsDataSet";
            reportDataSource1.Value = this.ClienteBindingSource;
            this.clientesReportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.clientesReportViewer.LocalReport.ReportEmbeddedResource = "CSharp2.Capitulo02.Clientes.ClientesReport.rdlc";
            this.clientesReportViewer.Location = new System.Drawing.Point(0, 0);
            this.clientesReportViewer.Name = "clientesReportViewer";
            this.clientesReportViewer.Size = new System.Drawing.Size(873, 563);
            this.clientesReportViewer.TabIndex = 0;
            // 
            // ClienteBindingSource
            // 
            this.ClienteBindingSource.DataSource = typeof(Impacta.Dominio.Cliente);
            // 
            // RelatorioClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 563);
            this.Controls.Add(this.clientesReportViewer);
            this.Name = "RelatorioClientesForm";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.RelatorioClientesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer clientesReportViewer;
        private System.Windows.Forms.BindingSource ClienteBindingSource;
    }
}