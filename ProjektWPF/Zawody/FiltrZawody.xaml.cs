using ProjektWPF.Data;
using System;
using System.Collections.Generic;
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

namespace ProjektWPF.Zawody
{
    /// <summary>
    /// Logika interakcji dla klasy FiltrZawody.xaml
    /// </summary>
    public partial class FiltrZawody : Window
    {
        ListCollectionView View;
        ZawodnikDbContext context;
        public FiltrZawody(ListCollectionView View, ZawodnikDbContext context)
        {
            InitializeComponent();
            this.View = View;
            this.context = context;

        }

        private void Filtr(object sender, RoutedEventArgs e)
        {
            var a = MiesiacStart.Text;
            var b = MiesiacStop.Text;
            var c = Rok.Text;
            var d = Rodzaj.Text;
            var f = 1;
            View.Filter = delegate (object item)
            {
                Zawodys filroz = item as Zawodys;
                if (filroz == null)
                {
                    return false;
                }
                if (MiesiacStart.Text != null&&MiesiacStart.Text!="")
                {
                    if (MiesiacStart.Text != filroz.DataStart.Month.ToString())
                    {
                        return false;
                    }
                }
                if (MiesiacStop.Text != null && MiesiacStop.Text != "")
                {
                    string a;
                    if (MiesiacStop.Text != filroz.DataStart.Month.ToString())
                    {
                        return false;
                    }
                }
                if (Rok.Text != null && Rok.Text != "")
                {
                    if (Rok.Text != filroz.DataStart.Year.ToString())
                    {
                        return false;
                    }
                }
                if (Rodzaj.Text != null && Rodzaj.Text != "")
                {
                    if (Rodzaj.Text != filroz.rodzaj)
                    {
                        return false;
                    }
                }

                return true;
            };
            this.Close();
        }

        private void Reset(object sender, RoutedEventArgs e)
        {
            View.Filter = null;
            this.Close();
        }


    }
}
