using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSharp2.Capitulo03.Oficina
{
    public partial class ModeloForm : Form
    {
        public ModeloForm()
        {
            InitializeComponent();
        }

        private void modeloBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.modeloBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.oficinaDataSet);

        }

        private void ModeloForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oficinaDataSet.Modelo' table. You can move, or remove it, as needed.
            this.modeloTableAdapter.Fill(this.oficinaDataSet.Modelo);
            // TODO: This line of code loads data into the 'oficinaDataSet.Modelo' table. You can move, or remove it, as needed.
            this.modeloTableAdapter.Fill(this.oficinaDataSet.Modelo);

        }

        private void modeloBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.modeloBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.oficinaDataSet);

        }
    }
}
