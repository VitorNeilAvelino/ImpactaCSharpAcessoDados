using System;
using System.Windows;
using Impacta.Dominio;
using Impacta.Repositorios.Ef.CodeFirst;
using System.ComponentModel;
using System.Linq;

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
        BackgroundWorker _bgWorker;

        public event PropertyChangedEventHandler PropertyChanged;

        public Veiculo Veiculo { get; set; }

        private void pesquisarButton_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(placaTextBox.Text.Trim()))
            {
                MessageBox.Show("Informe uma placa.");
                placaTextBox.Focus();
                return;
            }

            Veiculo = _oficinaUow.VeiculoRepositorio.PesquisarPorPlaca(placaTextBox.Text.Trim());
            PropertyChanged(this, new PropertyChangedEventArgs("Veiculo"));

            totalRegistrosProgressBar.Value = 0;

            if (Veiculo == null)
            {
                totalTextBox.Text = null;
                MessageBox.Show("Veículo não encontrado.");
                return;
            }

            totalTextBox.Text = Veiculo.Servicos.Sum(s => s.Valor).Value.ToString("c");

            DefinirBackgroundWorker();
        }

        private void DefinirBackgroundWorker()
        {
            _bgWorker = new BackgroundWorker();
            _bgWorker.DoWork += _bgWorker_DoWork;
            _bgWorker.WorkerReportsProgress = true;
            _bgWorker.ProgressChanged += (s, e) => totalRegistrosProgressBar.Value = e.ProgressPercentage;

            _bgWorker.RunWorkerAsync();
        }

        void _bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            decimal contador = 0;

            while (contador < 1000000)
            {
                contador++;

                var percentual = contador / 1000000 * 100;

                if (contador % 1000 == 0)
                {
                    _bgWorker.ReportProgress(Convert.ToInt32(percentual));
                }
            }
        }

        //void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        //{
        //    custoProgressBar.Value = e.ProgressPercentage;
        //}

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            _oficinaUow.Dispose();

            if (_bgWorker != null)
            {
                _bgWorker.Dispose();
            }
        }
    }
}