using System.Diagnostics;
using System.Threading;
using System.Windows;
using System.Globalization;
using System.Resources;
using uniCovid;
using System;
using System.Windows.Controls;
using uniCovid.Properties;
using uniCovid.resources;

namespace uniCovid
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {

        public MainWindow()
        {


            
            //hook up DataChanged event to get notification to make culture-related changes in code
            CultureRes.ResourceProvider.DataChanged += new EventHandler(ResourceProvider_DataChanged);

            //initialise with default culture
            Debug.WriteLine(string.Format("Set culture to default [{0}]:", Properties.Settings.Default.DefaultCulture));
            CultureRes.ChangeCulture(Properties.Settings.Default.DefaultCulture);

            this.InitializeComponent();

            //only attach SelectionChanged event here to avoid the culture being updated twice
            this.cbLanguages.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbLanguages_SelectionChanged);
            cbLanguages.SelectedItem = Properties.Settings.Default.DefaultCulture;

            var config = new Config();
            this.Height = config.WindowHeight;
            this.Width = config.WindowWidth;
        }

        void ResourceProvider_DataChanged(object sender, EventArgs e)
        {
            Debug.WriteLine(string.Format("ObjectDataProvider.DataChanged event. fetching culturename property for new culture [{0}]", resources.Resources.bthSalir));
        }
        public void cbLanguages_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CultureInfo selected_culture = cbLanguages.SelectedItem as CultureInfo;

            //if not current language
            //could check here whether the culture we want to change to is available in order to provide feedback / action
            if (resources.Resources.Culture != null && !resources.Resources.Culture.Equals(selected_culture))
            {
                Debug.WriteLine(string.Format("Change Current Culture to [{0}]", selected_culture));

                //change resources to new culture
                CultureRes.ChangeCulture(selected_culture);


                Properties.Settings.Default.DefaultCulture = selected_culture;
                Properties.Settings.Default.Save();

            }

            Trace.TraceInformation("Se ha cambiado el lenguaje");
            Trace.Flush();
        }

        



        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult res = MessageBox.Show("¿Estás seguro que deseas salir? ", "Atención", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (res == MessageBoxResult.Yes)
            {
                Trace.TraceInformation("Aplicacion cerrada");
                Trace.Flush(); 
                Application.Current.Shutdown();
            }

            var config = new Config();

            config.WindowHeight = this.Height;
            config.WindowWidth = this.Width;
            

            config.Save();
        }



        private void btnListado1_Click(object sender, RoutedEventArgs e)
        {

            Trace.TraceInformation("Listado abierto");
            Trace.Flush();
            winListado1 listado1 = new winListado1();
            listado1.Show();

        }

        private void btnCRUD_Click(object sender, RoutedEventArgs e)
        {
            Trace.TraceInformation("CRUD abierto");
            Trace.Flush();
            winCRUD crud = new winCRUD();
            crud.Show();

        }

       
    }
}
