using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Impacta.Apoio
{
    public static class Imagens
    {
        /// <summary>
        /// Grava um print screen da tela toda no caminho especificado
        /// </summary>
        /// <param name="caminhoArquivo">Nome completo da imagem, com caminho e extensão</param>
        public static void CapturarTela(string caminhoArquivo)
        {
            var tamanhoTela = Screen.PrimaryScreen.Bounds;

            using (Bitmap bitmap = new Bitmap(tamanhoTela.Width, tamanhoTela.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(new Point(0, 0), new Point(0, 0), tamanhoTela.Size);
                }
                bitmap.Save(caminhoArquivo, ImageFormat.Png);
                bitmap.Dispose();
            }
        }
    }
}