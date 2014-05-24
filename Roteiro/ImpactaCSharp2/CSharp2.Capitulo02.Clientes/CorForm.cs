using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSharp2.Capitulo02.Clientes
{
    public partial class CorForm : Form
    {
        public CorForm()
        {
            InitializeComponent();
        }

        private void corBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.corBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.oficinaDataSet);

        }

        private void CorForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oficinaDataSet.Cor' table. You can move, or remove it, as needed.
            this.corTableAdapter.Fill(this.oficinaDataSet.Cor);

        }
    }
}
