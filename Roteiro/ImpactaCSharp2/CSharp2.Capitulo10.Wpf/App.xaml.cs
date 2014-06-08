using System.Windows;
using System.Windows.Markup;

namespace CSharp2.Capitulo10.Wpf
{
    public partial class App : Application
    {
        public App()
        {
            //Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo("pt-BR");

            FrameworkElement.LanguageProperty.OverrideMetadata(typeof(FrameworkElement),
                new FrameworkPropertyMetadata(XmlLanguage.GetLanguage("pt-BR")));
        }
    }
}