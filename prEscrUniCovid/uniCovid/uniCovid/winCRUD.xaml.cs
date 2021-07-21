using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Diagnostics;

namespace uniCovid
{
    /// <summary>
    /// Логика взаимодействия для winCRUD.xaml
    /// </summary>
    public partial class winCRUD : Window
    {
       uniCovidDbEntities1 db;

        public winCRUD()
        {
            InitializeComponent();
            db = new uniCovidDbEntities1();

            
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Trace.TraceInformation("Se ha salido de CRUD");
            Trace.Flush();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource prUniDBViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("prUniDBViewSource")));
            // Загрузите данные, установив свойство CollectionViewSource.Source:
            // prUniDBViewSource.Source = [универсальный источник данных]

            db.prUniDBs.Load();
            prUniDBViewSource.Source = db.prUniDBs.Local;

        }

        public void btnDetail_Click(object sender, EventArgs e)
        {
            prUniDB p = (prUniDB)gridListado.SelectedItem;
            gridListado.Visibility = Visibility.Hidden;
            gridCajaDetalle.Margin = new Thickness(5, 55, 5, 4);
            gridCajaDetalle.Visibility = Visibility.Visible;

            btnNuevo.Visibility = Visibility.Hidden;
            Logo.Visibility = Visibility.Hidden;
            btnSalir.Visibility = Visibility.Hidden;

            Trace.TraceInformation("Detalle abierto");
            Trace.Flush();
        }
     

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            gridCajaDetalle.Margin = new Thickness(825, 70, -650, 5);
            gridCajaDetalle.Visibility = Visibility.Hidden;
            gridListado.Visibility = Visibility.Visible;

            btnNuevo.Visibility = Visibility.Visible;
            Logo.Visibility = Visibility.Visible;
            btnSalir.Visibility = Visibility.Visible;


            Trace.TraceInformation("Se ha salido de detalle");
            Trace.Flush();

        }

        private void btnNuevo_Click(object sender, RoutedEventArgs e)
        {
            gridListado.Visibility = Visibility.Hidden;
            btnNuevo.Visibility = Visibility.Hidden;
            gridCajaNuevo.Margin = new Thickness(5, 55, 5, 4);
            gridCajaNuevo.Visibility = Visibility.Visible;

            Logo.Visibility = Visibility.Hidden;
            btnSalir.Visibility = Visibility.Hidden;


            Trace.TraceInformation("Añadir nueva provincia");
            Trace.Flush();
        }
        private void btnVolverNuevo_Click(object sender, RoutedEventArgs
        e)
        {
            gridCajaNuevo.Margin = new Thickness(5, -393, 3.6, 453);
            gridCajaNuevo.Visibility = Visibility.Hidden;
            gridListado.Visibility = Visibility.Visible;
            btnNuevo.Visibility = Visibility.Visible;

            Logo.Visibility = Visibility.Visible;
            btnSalir.Visibility = Visibility.Visible;

            Trace.TraceInformation("Volver de anadir nuevo");
            Trace.Flush();
        }

        private void btnAddNuevo_Click(object sender, RoutedEventArgs e)
        {
            prUniDB nuevo = new prUniDB();
            try
            {
                
                nuevo.Provincia = ProvinciaTextBoxNuevo.Text;
                nuevo.Tests_positivos_alumnado = Convert.ToInt32(Tests_positivos_alumnadoTextBoxNuevo.Text);
                nuevo.Tests_positivos_profesorado = Convert.ToInt32(Tests_positivos_profesoradoTextBoxNuevo.Text);
                nuevo.Fecha = Convert.ToDateTime(fechaDatePicker1.Text);

                db.prUniDBs.Add(nuevo);
                db.SaveChanges();

                Volver();

                MessageBox.Show("Provincia '" + nuevo.Provincia + "' añadido correctamante.", "Atención!", MessageBoxButton.OK, MessageBoxImage.Information);


                Trace.TraceInformation("se ha anadido nueva provincia a BD");
                Trace.Flush();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al añadir una nueva provincia. Causa: " + ex.Message, "Atención!", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void Volver()
        {
            gridCajaNuevo.Margin = new Thickness(5, -393, 3.6, 453);
            gridCajaNuevo.Visibility = Visibility.Hidden;
            gridListado.Visibility = Visibility.Visible;
            btnNuevo.Visibility = Visibility.Visible;

            Logo.Visibility = Visibility.Visible;
            btnSalir.Visibility = Visibility.Visible;

          
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            prUniDB p = (prUniDB)gridListado.SelectedItem;
            MessageBoxResult res = MessageBox.Show("¿Está segurto de que desea borrar la provincia '" + p.Provincia + "'?", "Atención!", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (res == MessageBoxResult.Yes)
            {
                try
                {
                    db.prUniDBs.Remove(p);
                    db.SaveChanges();

                    MessageBox.Show("Provincia '" + p.Provincia + "' eliminado correctamante.", "Atención!", MessageBoxButton.OK, MessageBoxImage.Information);

                    Trace.TraceInformation("se ha eliminado la provincia de BD");
                    Trace.Flush();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar una provincia. Causa: " + ex.Message, "Atención!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            gridListado.Visibility = Visibility.Hidden;
            btnNuevo.Visibility = Visibility.Hidden;
            gridCajaEditar.Margin = new Thickness(5, 60, 5, 4);
            gridCajaEditar.Visibility = Visibility.Visible;

            Logo.Visibility = Visibility.Hidden;
            btnSalir.Visibility = Visibility.Hidden;

            Trace.TraceInformation("se ha abietro edit");
            Trace.Flush();

        }

        private void btnVolverEdit_Click(object sender, RoutedEventArgs e)
        {
            volverDesdeEdit();
        }
        private void volverDesdeEdit()
        {
            gridCajaEditar.Margin = new Thickness(5, 432, 3.6, -372);
            gridCajaEditar.Visibility = Visibility.Hidden;
            gridListado.Visibility = Visibility.Visible;
            btnNuevo.Visibility = Visibility.Visible;
            Logo.Visibility = Visibility.Visible;
            btnSalir.Visibility = Visibility.Visible;

            Trace.TraceInformation("se ha vuelo desde esdit");
            Trace.Flush();
        }

        

        private void btnEditProd_Click(object sender, RoutedEventArgs e)
        {
            //TODO: verificar que los datos del formulario son correctos
            prUniDB p = (prUniDB)gridListado.SelectedItem;
            try
            {
                db.SaveChanges();
                volverDesdeEdit();
                MessageBox.Show("Provincia '" + p.Provincia + "' modificado correctamente.", "Atención!", MessageBoxButton.OK,
               MessageBoxImage.Information);

                Trace.TraceInformation("se ha modificado provincia a BD");
                Trace.Flush();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar una provincia. Causa:" +
               ex.Message, "Atención!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }



    }
}
