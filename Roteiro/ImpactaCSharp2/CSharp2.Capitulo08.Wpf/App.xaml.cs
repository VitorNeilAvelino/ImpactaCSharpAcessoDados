using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using System.Threading;
using System.Globalization;

namespace CSharp2.Capitulo08.Wpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("pt-BR");
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("pt-BR");
            FrameworkElement.LanguageProperty.OverrideMetadata(typeof(FrameworkElement), new FrameworkPropertyMetadata(
            System.Windows.Markup.XmlLanguage.GetLanguage(CultureInfo.CurrentCulture.IetfLanguageTag)));
        }
    }
}
