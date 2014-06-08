using System.Linq;
using System.Windows;
using System.ComponentModel;
using System.Xml.Linq;
using Impacta.Infra.Apoio;
using Impacta.Repositorios.Ef.CodeFirst;
using Impacta.Dominio;
using System;
using System.Collections.ObjectModel;

namespace CSharp2.Capitulo08.Wpf
{
    public partial class ServicosWindow : Window, INotifyPropertyChanged
    {
        public ServicosWindow()
        {
            InitializeComponent();

            placaTextBox.Focus();
        }

        OficinaUnityOfWork _oficinaUow = new OficinaUnityOfWork();

        public event PropertyChangedEventHandler PropertyChanged;

        ConsultaPrecoServiceReference.StockQuoteSoapClient _servicoConsulta = new ConsultaPrecoServiceReference.StockQuoteSoapClient("StockQuoteSoap");

        private Veiculo _veiculo;

        public Veiculo Veiculo
        {
            get { return _veiculo; }
            set
            {
                _veiculo = value;
                //PropertyChanged(this, new PropertyChangedEventArgs("Veiculo"));
                //OnPropertyChanged("Veiculo");
            }
        }

        public ObservableCollection<Servico> Servicos
        {
            get { return Veiculo != null ? new ObservableCollection<Servico>(Veiculo.Servicos) : null; }
        }

        private void consultarPlacaButton_Click(object sender, RoutedEventArgs e)
        {
            Veiculo = _oficinaUow.VeiculoRepositorio.PesquisarPorPlaca(placaTextBox.Text);
            OnPropertyChanged("Veiculo");
            OnPropertyChanged("Servicos");

            BackgroundWorker backgroundWorker = new BackgroundWorker();

            backgroundWorker.DoWork += delegate { ObterCotacao(); };
            backgroundWorker.RunWorkerAsync();
            backgroundWorker.RunWorkerCompleted += delegate { OnPropertyChanged("Servicos"); };

            //PropertyChanged(this, new PropertyChangedEventArgs("Veiculo"));
        }

        public void MudarAno()
        {
            Veiculo.AnoModelo = ObterCotacao("GOOG").ParaInteiro() + DateTime.Now.Second;
            //Veiculo.AnoModelo = 1327;
            Veiculo.Servicos.First().Custo = ObterCotacao("GOOG").ParaInteiro() + DateTime.Now.Second;
            //Veiculo.Servicos.First().Custo = DateTime.Now.Second;
        }

        private void ObterCotacao()
        {
            foreach (var servico in Veiculo.Servicos)
            {
                servico.Custo = ObterCotacao(servico.Sigla);
            }
        }

        //private void consultarCustoButton_Click(object sender, RoutedEventArgs e)
        //{
        //    _servicoConsulta = new ConsultaPrecoServiceReference.StockQuoteSoapClient("StockQuoteSoap");
        //    var respostaMs = ObterCotacao("MSFT");
        //    var respostaGoogle = ObterCotacao("GOOG");
        //    var respostaApple = ObterCotacao("AAPL");
        //}

        private decimal ObterCotacao(string sigla)
        {
            return XDocument.Parse(_servicoConsulta.GetQuote(sigla)).Descendants("Last").First().Value.Replace(".", ",").ParaDecimal();
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}