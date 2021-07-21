using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using uniCovid.Properties;


namespace uniCovid
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        App()
        {
             }

        //protected override void OnStartup(StartupEventArgs e)
        //{
        //    base.OnStartup(e);
        //    // Cargamos la configuración anterior (si existía)
        //    LANG.cargar(getLengFromSettings());
        //}

        //private string getLengFromSettings()
        //{
        //    return Settings.Default.Language;
        //}

    }
}
