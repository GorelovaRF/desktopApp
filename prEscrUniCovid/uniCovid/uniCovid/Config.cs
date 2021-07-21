using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//using System.Windows.Forms;


namespace uniCovid
{
    public class Config
    {
        private double _windowHeight;
        private double _windowWidth;
     

        private double _listadoHeight;
        private double _listadoWidth;
        

        public double WindowHeight
        {
            get { return _windowHeight; }
            set { _windowHeight = value; }
        }

        public double WindowWidth
        {
            get { return _windowWidth; }
            set { _windowWidth = value; }
        }


     


        public double ListadoHeight
        {
            get { return _listadoHeight; }
            set { _listadoHeight = value; }
        }

        public double ListadoWidth
        {
            get { return _listadoWidth; }
            set { _listadoWidth = value; }
        }


  

        public Config()
        {
            //Load the settings
            Load();

            LoadListado();


        }

        private void Load()
        {
           
            _windowHeight = Properties.Settings.Default.WinHeight;
            _windowWidth = Properties.Settings.Default.WinWidth;
            
        }

        private void LoadListado()
        {
            _listadoHeight = Properties.Settings.Default.listadoHeight;
            _listadoWidth = Properties.Settings.Default.listadoWidth;

        }


        public void Save()
        {
            

                Properties.Settings.Default.WinHeight = _windowHeight;
                Properties.Settings.Default.WinWidth = _windowWidth;

                Properties.Settings.Default.Save();
            
        }

        public void SaveListado()
        {
           

                Properties.Settings.Default.listadoHeight = _listadoHeight;
                Properties.Settings.Default.listadoWidth = _listadoWidth;

                Properties.Settings.Default.Save();
            
        }






    }
}
