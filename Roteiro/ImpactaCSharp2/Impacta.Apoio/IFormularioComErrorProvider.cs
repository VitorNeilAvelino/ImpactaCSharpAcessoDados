using System.Windows.Forms;
namespace Impacta.Apoio
{
    public interface IFormularioComErrorProvider
    {
        ErrorProvider ProvedorDeErro { get; }
    }
}