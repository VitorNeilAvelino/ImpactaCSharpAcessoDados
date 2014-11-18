using System.Windows;
using System.Windows.Markup;

namespace CSharp2.Capitulo08.Threads
{
    public partial class App : Application
    {
        public App()
        {
            FrameworkElement.LanguageProperty.OverrideMetadata(typeof(FrameworkElement),
                new FrameworkPropertyMetadata(XmlLanguage.GetLanguage("pt-BR")));
        }
    }
}