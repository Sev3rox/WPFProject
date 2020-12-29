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

namespace ProjektWPF.Rozgrywki
{
    /// <summary>
    /// Interaction logic for FilterRozgrywka.xaml
    /// </summary>
    public partial class FilterRozgrywka : Window
    {
        ListCollectionView View;
        Rozgrywka pomroz;
        public FilterRozgrywka(ListCollectionView View)
        {
            InitializeComponent();
            this.View = View;
            pomroz= new Rozgrywka();
            FiltrGrid.DataContext = pomroz;

        }

        private void Filtr(object sender, RoutedEventArgs e)
        {

            View.Filter = delegate (object item)
            {
                Rozgrywka filroz = item as Rozgrywka;
                if (filroz == null)
                {
                    return false;
                }
                if (pomroz.Place != null)
                {
                    if (pomroz.Place != filroz.Place)
                    {
                        return false;
                    }
                }
                if (pomroz.Sedziaglowny != null)
                {
                    if (pomroz.Sedziaglowny != filroz.Sedziaglowny && pomroz.Sedziaglowny != filroz.Sedziapom1 && pomroz.Sedziaglowny != filroz.Sedziapom2 && pomroz.Sedziaglowny != filroz.Sedziatechniczny)
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
