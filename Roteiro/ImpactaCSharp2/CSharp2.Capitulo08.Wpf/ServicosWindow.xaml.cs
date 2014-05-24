using System.Linq;
using System.Windows;
using System.ComponentModel;
using System.Xml.Linq;
using Impacta.Infra.Apoio;
using System.Threading;
using Impacta.Repositorios.Ef.Designer;

namespace CSharp2.Capitulo08.Wpf
{
    public partial class ServicosWindow : Window, INotifyPropertyChanged
    {
        public ServicosWindow()
        {
            InitializeComponent();

            placaTextBox.Focus();
        }

        OficinaEntities _contexto = new OficinaEntities();

        public event PropertyChangedEventHandler PropertyChanged;

        ConsultaPrecoServiceReference.StockQuoteSoapClient _servicoConsulta;

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

        private void consultarPlacaButton_Click(object sender, RoutedEventArgs e)
        {
            Veiculo = _contexto.Veiculo.Where(x => x.Placa == placaTextBox.Text).FirstOrDefault();

            ThreadPool.QueueUserWorkItem(delegate { ObterCotacao(); });

            PropertyChanged(this, new PropertyChangedEventArgs("Veiculo"));
        }

        private void ObterCotacao()
        {
            _servicoConsulta = new ConsultaPrecoServiceReference.StockQuoteSoapClient("StockQuoteSoap");

            foreach (var servico in Veiculo.Servico)
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
        //    //Veiculo.Servicos. = (respostaMs + respostaGoogle + respostaApple) / 3;
        //}

        private decimal ObterCotacao(string sigla)
        {
            return XDocument.Parse(_servicoConsulta.GetQuote(sigla)).Descendants("Last").First().Value.Replace(".", ",").ParaDecimal();
        }

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