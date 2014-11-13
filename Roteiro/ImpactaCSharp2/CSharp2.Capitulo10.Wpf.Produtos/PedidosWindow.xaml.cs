using Impacta.Repositorios.Ef.Designer;
using System.Collections.Generic;
using System.Windows;
using System.Linq;
using System.ComponentModel;
using System.Collections.ObjectModel;

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

        public List<Vendedor> Vendedores { get; set; }
        public Cliente Cliente { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        //protected override void OnClosing(CancelEventArgs e)
        //{
        //    //_contexto.Dispose();
        //    base.OnClosing(e);
        //}
    }
}