using System;
using System.Windows;
using Impacta.Dominio;
using Impacta.Repositorios.Ef.CodeFirst;
using System.ComponentModel;
using System.Linq;
using System.Xml.Linq;
using System.Collections.ObjectModel;

namespace CSharp2.Capitulo10.Wpf
{
    public partial class ServicosWindow : Window, INotifyPropertyChanged
    {
        public ServicosWindow()
        {
            InitializeComponent();
            placaTextBox.Focus();
        }

        OficinaUnityOfWork _oficinaUow = new OficinaUnityOfWork();

        BolsaServiceReference.StockQuoteSoapClient _bolsaServico = new BolsaServiceReference.StockQuoteSoapClient("StockQuoteSoap");

        BackgroundWorker _bgWorker;

        public Veiculo Veiculo { get; set; }

        public ObservableCollection<Servico> Servicos
        {
            get { return Veiculo != null ? new ObservableCollection<Servico>(Veiculo.Servicos) : null; }
        }

        private void pesquisarButton_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(placaTextBox.Text.Trim()))
            {
                MessageBox.Show("Informe uma placa.");
                placaTextBox.Focus();
            }

            Veiculo = _oficinaUow.VeiculoRepositorio.PesquisarPorPlaca(placaTextBox.Text.Trim());
            PropertyChanged(this, new PropertyChangedEventArgs("Veiculo"));
            PropertyChanged(this, new PropertyChangedEventArgs("Servicos"));

            totalTextBox.Text = Veiculo.Servicos.Sum(s => s.Valor).Value.ToString("c");
            custoProgressBar.Value = 0;

            DefinirBackgroundWorker();
        }

        private void DefinirBackgroundWorker()
        {
            _bgWorker = new BackgroundWorker();
            _bgWorker.DoWork += delegate { ObterCotacao(); };
            _bgWorker.WorkerReportsProgress = true;
            _bgWorker.ProgressChanged += (s, e) => custoProgressBar.Value = e.ProgressPercentage;
            _bgWorker.RunWorkerCompleted += delegate { PropertyChanged(this, new PropertyChangedEventArgs("Servicos")); };
            
            _bgWorker.RunWorkerAsync();
        }

        //void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        //{
        //    custoProgressBar.Value = e.ProgressPercentage;
        //}

        private void ObterCotacao()
        {
            var contador = 0;

            foreach (var servico in Veiculo.Servicos)
            {
                servico.Custo = ObterCotacao(servico.Sigla);

                var percentual = Convert.ToDecimal(++contador) / Veiculo.Servicos.Count * 100;
                _bgWorker.ReportProgress(Convert.ToInt32(percentual));
            }
        }

        private decimal ObterCotacao(string sigla)
        {
            var stringXml = _bolsaServico.GetQuote(sigla);
            var xml = XDocument.Parse(stringXml);
            var cotacao = xml.Descendants("Last").First().Value.Replace(".", ",");

            return Convert.ToDecimal(cotacao);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            _oficinaUow.Dispose();
            _bgWorker.Dispose();
        }
    }
}