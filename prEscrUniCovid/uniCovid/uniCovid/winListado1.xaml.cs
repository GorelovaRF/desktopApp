using System;
using System.Collections.Generic;
using System.Diagnostics;
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
//using System.Windows.Forms;
using uniCovid.Models;
//using System.Drawing;
using System.IO;
using Microsoft.Win32;
using uniCovid.resources;

namespace uniCovid
{
    /// <summary>
    /// Логика взаимодействия для winListado1.xaml
    /// </summary>
    public partial class winListado1 : Window
    {
        drvJSON uni = new drvJSON();
        public winListado1()
        {

         


            InitializeComponent();



            // drvJSON uni = new drvJSON();
            //uni.origen = "uniCovid.json";
            uni.origen = resources.Resources.jsonFile;


            uni.loadData();

            for (int i = 0; i < uni.getTotalKeys(); i++)
            {
                Label label = new Label
                {
                    Name = "lblHeader_" + (i + 1).ToString(),
                    Content = uni.getKey(i),
                    Margin = new Thickness(i * 150, 0, 0, 0),
                    FontFamily = new FontFamily("Futura"),
                    FontSize = 12.0,
                    FontWeight = FontWeights.Bold,
                    Foreground = new SolidColorBrush(Colors.White),
                    HorizontalContentAlignment = HorizontalAlignment.Center,
                   

                };



                pnlDatos.Children.Add(label);
            }
        
            for (int i = 0; i < uni.getTotal(); i++)
            {
                for (int j = 0; j < uni.getTotalKeys(); j++)
                {
                   

                    Label label = new Label
                    {
                        Name = "lblData_" + (i + 1).ToString() + "_" + (j + 1).ToString(),

                        Content = uni.getDato(i)[uni.getKey(j)],
                        Foreground = new SolidColorBrush(Colors.White),
                        Margin = new Thickness(0 + (j * 150), 24 + (i * 24), 0, 0),
                        FontFamily = new FontFamily("Futura"),
                        FontSize = 12.0,
                        BorderThickness = new Thickness(1, 0, 0, 0),
                        Width = 150,
                        
                      
                    };
                   
                    if (i % 2 == 0)
                    {
                        label.Background = new SolidColorBrush(Colors.White);
                        label.Foreground = new SolidColorBrush(Colors.Black);
                    }
                    else
                    {
                       
                        label.Background = new SolidColorBrush(Colors.DarkCyan);
                        label.Foreground = new SolidColorBrush(Colors.Black);
                       
                    }
                    pnlDatos.Children.Add(label);
                }
                pnlDatos.Height += 24;
            }

            var config = new Config();
            this.Height = config.ListadoHeight;
            this.Width = config.ListadoWidth;

        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {

             var config = new Config();

            config.ListadoHeight = this.Height;
            config.ListadoWidth = this.Width;
            config.SaveListado();

            Trace.TraceInformation("La lista cerrada");
            Trace.Flush();
            this.Close();



        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string text;
            text = "";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text file (*.txt)|*.txt|C# file (*.cs)|*.cs";


            if (saveFileDialog.ShowDialog() == true)
            {

                for (int i = 0; i < uni.getTotal(); i++)
                {
                    for (int j = 0; j < uni.getTotalKeys(); j++)
                    {
                        text += "  " + uni.getDato(i)[uni.getKey(j)];

                        if (j == 3)
                        {
                            text += "\n";
                        }
                    }
                }

                File.WriteAllText(saveFileDialog.FileName, text);

                Trace.TraceInformation("se ha pulsado descargar la lista");
                Trace.Flush();


            }

        }
    }
}
