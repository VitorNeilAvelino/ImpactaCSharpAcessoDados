using Impacta.Repositorios.Ef.Designer;
using System.Collections.Generic;
using System.Windows;
using System.Linq;
using System.ComponentModel;
using System.Collections.ObjectModel;
using Impacta.Dominio;
using System;
using System.Windows.Media;
using Produto = Impacta.Repositorios.Ef.Designer.Produto;

namespace CSharp2.Capitulo10.Wpf.Produtos
{
    public partial class PedidosWindow : Window, INotifyPropertyChanged
    {
        public PedidosWindow()
        {
            InitializeComponent();
            PopularPropriedades();
        }

        #region ViewModel
        public List<Impacta.Repositorios.Ef.Designer.Vendedor> Vendedores { get; set; }
        public List<Impacta.Repositorios.Ef.Designer.Produto> Produtos { get; set; }
        public Impacta.Repositorios.Ef.Designer.Pedido Pedido { get; set; }
        public decimal TotalPedido
        {
            get
            {
                if (Pedido == null)
                {
                    return 0;
                }

                return Pedido.ItensPedido.Sum(i => (i.PrecoUnitario * i.Quantidade));
            }
        }
        public bool PodeFecharPedido { get; set; }
        #endregion

        PedidosEntities _contexto = new PedidosEntities();

        private void PopularPropriedades()
        {
            //using (var _contexto = new PedidosEntities())
            //{
            Vendedores = _contexto.Vendedor.Include("Pessoa").ToList();
            Produtos = _contexto.Produto.Include("TipoProduto").ToList();
            Pedido = new Impacta.Repositorios.Ef.Designer.Pedido();

            PropertyChanged(this, new PropertyChangedEventArgs("Vendedores"));
            PropertyChanged(this, new PropertyChangedEventArgs("Produtos"));
            //}
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void cpfCliente_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter)
            {
                SelecionarClientePorCpf();
            }
        }

        private void SelecionarClientePorCpf()
        {
            //using (var _contexto = new PedidosEntities())
            //{
            Pedido.Cliente = _contexto.Cliente.Include("Pessoa")
                .SingleOrDefault(
                    c => c.Pessoa.PessoaDocumentos.Any(
                        d => d.Tipo == (int)TipoDocumento.Cpf && d.Numero == cpfCliente.Text));

            if (Pedido.Cliente == null)
            {
                nomeCliente.Content = "CPF não encontrado";
                cpfCliente.BorderBrush = Brushes.Red;
                return;
            }

            cpfCliente.BorderBrush = Brushes.Black;
            nomeCliente.Content = Pedido.Cliente.Pessoa.Nome;
            //}
        }

        private void adicionarButton_Click(object sender, RoutedEventArgs e)
        {
            var item = new Impacta.Repositorios.Ef.Designer.ItensPedido();

            item.Quantidade = Convert.ToInt32(quantidadeTextBox.Text);
            item.Produto = (Produto)produtosComboBox.SelectedItem;
            item.PrecoUnitario = item.Produto.Custo;

            Pedido.ItensPedido.Add(item);
            PropertyChanged(this, new PropertyChangedEventArgs("Pedido"));
            PropertyChanged(this, new PropertyChangedEventArgs("TotalPedido"));
            itensPedidoDataGrid.Items.Refresh();
            quantidadeTextBox.Text = "1";
        }

        private void removerButton_Click(object sender, RoutedEventArgs e)
        {
            var item = ((FrameworkElement)sender).DataContext as ItensPedido;

            Pedido.ItensPedido.Remove(item);
            PropertyChanged(this, new PropertyChangedEventArgs("Pedido"));
            PropertyChanged(this, new PropertyChangedEventArgs("TotalPedido"));
            itensPedidoDataGrid.Items.Refresh();
        }

        private void itensPedidoDataGrid_PreviewMouseWheel(object sender, System.Windows.Input.MouseWheelEventArgs e)
        {
            itensPedidoScrollViewer.ScrollToVerticalOffset(itensPedidoScrollViewer.VerticalOffset - e.Delta);
        }

        private void fecharPedidoButton_Click(object sender, RoutedEventArgs e)
        {
            //using (var contexto = new PedidosEntities())
            //{

            Pedido.Vendedor = (Impacta.Repositorios.Ef.Designer.Vendedor)vendedorComboBox.SelectedItem;
            Pedido.DataEmissao = DateTime.Now;

            if (!ValidarFormulario())
            {
                return;
            }

            _contexto.Pedido.Add(Pedido);

            _contexto.SaveChanges();

            MessageBox.Show("Pedido realizado com sucesso.");

            LimparFormulario();
            //}
        }

        private bool ValidarFormulario()
        {
            if (Pedido.Vendedor == null)
            {
                MessageBox.Show("Selecione um vendedor.");
                vendedorComboBox.Focus();
                return false;
            }

            if (Pedido.Cliente == null)
            {
                MessageBox.Show("Digite o CPF do cliente.");
                cpfCliente.Focus();
                return false;
            }

            if (Pedido.ItensPedido.Count == 0)
            {
                MessageBox.Show("Adicione ao menos um produto.");
                produtosComboBox.Focus();
                return false;
            }

            return true;
        }

        private void LimparFormulario()
        {
            cpfCliente.Text = string.Empty;
            nomeCliente.Content = string.Empty;
            produtosComboBox.SelectedIndex = -1;

            Pedido = new Pedido();
            PropertyChanged(this, new PropertyChangedEventArgs("Pedido"));
            PropertyChanged(this, new PropertyChangedEventArgs("TotalPedido"));
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            _contexto.Dispose();
            base.OnClosing(e);
        }
    }
}