using Impacta.Dominio;
using System.ComponentModel;
using System.Windows;
using System.Xml.Linq;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharp2.Capitulo08.Threads
{
    public partial class CotacoesWindow : Window, INotifyPropertyChanged
    {
        public CotacoesWindow()
        {
            InitializeComponent();
        }

        public List<Cotacao> Cotacoes { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        //private StockQuoteServiceReference.StockQuoteServiceClient _cotacaoServico = new StockQuoteServiceReference.StockQuoteServiceClient();
        DateTime _inicio = DateTime.Now;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Cotacoes = new List<Cotacao> { 
                new Cotacao { Sigla = "AAPL" },
                new Cotacao { Sigla = "GOOG" },
                new Cotacao { Sigla = "INTC" },
                new Cotacao { Sigla = "KO" },
                new Cotacao { Sigla = "MSFT" }
            };

            ObterCotacoes();
        }

        private void ObterCotacoes()
        {
            var processoUi = Application.Current.Dispatcher; //expedidor

            //ThreadPool.QueueUserWorkItem(
            //    delegate // t =>
            //    {
            //        Parallel.ForEach<Cotacao>(Cotacoes, c =>
            //        {
            //            ObterCotacao(c);
            //            processoUi.BeginInvoke(new Action(AtualizarInterface));
            //        });
            //    });

            //Cotacoes.AsParallel().ForAll<Cotacao>(c => { ObterCotacao(c); processoUi.BeginInvoke(new Action(AtualizarInterface)); });

            //Parallel.ForEach<Cotacao>(Cotacoes, c =>
            //{
            //    ObterCotacao(c);
            //    processoUi.BeginInvoke(new Action(AtualizarInterface));
            //});

            foreach (var cotacao in Cotacoes)
            {
                ThreadPool.QueueUserWorkItem(
                delegate // t =>
                {
                    ObterCotacao(cotacao);
                    processoUi.BeginInvoke(new Action(AtualizarInterface));
                    //processoUi.InvokeAsync(new Action(AtualizarInterface));
                    //processoUi.BeginInvoke(new Action(() => AtualizarInterface()));
                    //processoUi.Invoke(new Action(AtualizarInterface));
                });
            }

            //foreach (var cotacao in Cotacoes)
            //{
            //    ObterCotacao(cotacao);
            //}

            //PropertyChanged(this, new PropertyChangedEventArgs("Cotacoes"));
            //cotacaoesBusyIndicator.IsBusy = false;
            //MessageBox.Show((DateTime.Now - _inicio).ToString());
        }

        private void AtualizarInterface()
        {
            if (cotacaoesBusyIndicator.IsBusy)
            {
                cotacaoesBusyIndicator.IsBusy = false;
            }

            cotacoesProgressBar.Value += (100 / Cotacoes.Count);
            PropertyChanged(this, new PropertyChangedEventArgs("Cotacoes"));
            cotacaoDataGrid.Items.Refresh();
        }

        private void ObterCotacao(Cotacao cotacao)
        {
            using (var _cotacaoServico = new StockQuoteServiceReference.StockQuoteServiceClient())
            {
                var response = _cotacaoServico.GetStockQuote(cotacao.Sigla);

                cotacao.Valor = Convert.ToDecimal(response.Last, new CultureInfo("en-US"));
                cotacao.NomeEmpresa = response.Name;
            }
        }

        private void cotacoesProgressBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (e.NewValue >= 100)
            {
                MessageBox.Show((DateTime.Now - _inicio).ToString());
            }
        }
    }
}