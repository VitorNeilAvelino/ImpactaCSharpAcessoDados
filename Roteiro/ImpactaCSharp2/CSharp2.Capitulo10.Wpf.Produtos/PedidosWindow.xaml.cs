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

        private void PopularPropriedades()
        {
            using (var contexto = new PedidosEntities())
            {
                Vendedores = new ObservableCollection<Vendedor>(contexto.Vendedor.ToList());
                PropertyChanged(this, new PropertyChangedEventArgs("Vendedores"));
            }
        }

        public ObservableCollection<Vendedor> Vendedores { get; set; }
        public Cliente Cliente { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}