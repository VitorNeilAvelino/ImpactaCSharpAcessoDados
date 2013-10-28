using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Impacta.Aplicacao;
using Impacta.Infra.Repositorios.SqlServer.Ef.Designer;
using System.ComponentModel;

namespace CSharp2.Capitulo08.Wpf
{
    /// <summary>
    /// Interaction logic for ServicosWindow.xaml
    /// </summary>
    public partial class ServicosWindow : Window, INotifyPropertyChanged
    {
        OficinaEntities _contexto = new OficinaEntities();

        //public Veiculo Veiculo
        //{
        //    get { return (Veiculo)GetValue(VeiculoDp); }
        //    set { SetValue(VeiculoDp, value); }
        //}

        //// Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        //public static readonly DependencyProperty VeiculoDp =
        //    DependencyProperty.Register("Veiculo", typeof(Veiculo), typeof(ServicosWindow), new UIPropertyMetadata(0));

        private Veiculo _veiculo;

        public Veiculo Veiculo
        {
            get { return _veiculo; }
            set
            {
                _veiculo = value;
                //PropertyChanged(this, new PropertyChangedEventArgs("Veiculo"));
            }
        }

        //public Veiculo Veiculo { get; set; }

        public ServicosWindow()
        {
            InitializeComponent();

            placaTextBox.Focus();
        }

        private void consultarPlacaButton_Click(object sender, RoutedEventArgs e)
        {
            //using (var _contexto = new OficinaEntities())
            //{
                Veiculo = _contexto.Veiculo.Where(x => x.Placa == placaTextBox.Text).FirstOrDefault();
                PropertyChanged(this, new PropertyChangedEventArgs("Veiculo"));
                //_contexto.Connection.Close();
            //}
        }

        public event PropertyChangedEventHandler PropertyChanged;
        //protected void OnPropertyChanged(string propertyName)
        //{
        //    PropertyChangedEventHandler handler = PropertyChanged;
        //    if (handler != null)
        //    {
        //        handler(this, new PropertyChangedEventArgs(propertyName));
        //    }
        //}
    }
}