using Impacta.Repositorios.Ef.Designer;
using System.Collections.Generic;
using System.Windows;
using System.Linq;
using System.ComponentModel;
using System.Collections.ObjectModel;
using Impacta.Dominio;
using System;

namespace CSharp2.Capitulo10.Wpf.Produtos
{
    public partial class PedidosWindow : Window, INotifyPropertyChanged
    {
        public PedidosWindow()
        {
            InitializeComponent();
            PopularPropriedades();
        }

        //PedidosEntities _contexto = new PedidosEntities();

        private void PopularPropriedades()
        {
            using (var _contexto = new PedidosEntities())
            {
                Vendedores = _contexto.Vendedor.Include("Pessoa").ToList();
                PropertyChanged(this, new PropertyChangedEventArgs("Vendedores"));
            }
        }

        public List<Impacta.Repositorios.Ef.Designer.Vendedor> Vendedores { get; set; }
        public Impacta.Repositorios.Ef.Designer.Cliente Cliente { get; set; }

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
            using (var _contexto = new PedidosEntities())
            {
                Cliente = _contexto.Cliente.Include("Pessoa")
                    .SingleOrDefault(
                        c => c.Pessoa.PessoaDocumentos.Any(
                            d => d.Tipo == (int)TipoDocumento.Cpf && d.Numero == cpfCliente.Text));

                if (Cliente == null)
                {
                    nomeCliente.Content = "CPF não encontrado";
                    return;
                }

                nomeCliente.Content = Cliente.Pessoa.Nome;
            }
        }

        //protected override void OnClosing(CancelEventArgs e)
        //{
        //    //_contexto.Dispose();
        //    base.OnClosing(e);
        //}
    }
}