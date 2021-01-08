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
        ZawodnikDbContext context;
        public FilterRozgrywka(ListCollectionView View, ZawodnikDbContext context)
        {
            InitializeComponent();
            this.View = View;
            this.context = context;
            pomroz= new Rozgrywka();
            FiltrGrid.DataContext = pomroz;
            Team1.ItemsSource = context.Druzyny.ToList();
            Team1.SelectedIndex = -1;

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
                if (Team1.SelectedItem != null)
                {
                    var pom = context.Druzyna_Rozgrywka.Where(z => z.RozgrywkaId == filroz.Id).ToList();
                    if (pom.Count >= 2)
                    {
                        if ((Druzyna)Team1.SelectedItem != pom[0].Druzyna && (Druzyna)Team1.SelectedItem != pom[1].Druzyna)
                        {
                            return false;
                        }
                    }
                   else if (pom.Count == 1)
                    {
                        if ((Druzyna)Team1.SelectedItem != pom[0].Druzyna)
                        {
                            return false;
                        }
                    }
                    else if (pom.Count <= 0)
                    {
                        
                            return false;
                        
                    }
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
