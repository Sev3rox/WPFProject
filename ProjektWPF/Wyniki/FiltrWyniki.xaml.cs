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

namespace ProjektWPF.Wyniki
{
    /// <summary>
    /// Logika interakcji dla klasy FiltrWyniki.xaml
    /// </summary>
    public partial class FiltrWyniki : Window
    {
        ListCollectionView View;
        Rozgrywka pomwyn;
        ZawodnikDbContext context;
        public FiltrWyniki(ListCollectionView View, ZawodnikDbContext context)
        {
            InitializeComponent();
            this.View = View;
            this.context = context;
            pomwyn = new Rozgrywka();
            FiltrGrid.DataContext = pomwyn;
            Team1.ItemsSource = context.Druzyny.ToList();
            Team1.SelectedIndex = -1;
            Team2.ItemsSource = context.Druzyny.ToList();
            Team2.SelectedIndex = -1;

        }

        private void Filtr(object sender, RoutedEventArgs e)
        {

            View.Filter = delegate (object item)
            {
                Wynik filroz = item as Wynik;
                if (filroz == null)
                {
                    return false;
                }
                if (Team1.SelectedItem != null)
                {
                    var pom = context.Druzyna_Rozgrywka.Where(z => z.RozgrywkaId == filroz.RozgrywkaId).ToList();
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
                if (Team2.SelectedItem != null)
                {   
                    var pom = context.Druzyna_Rozgrywka.Where(z => z.RozgrywkaId == filroz.RozgrywkaId).ToList();
                    if (pom.Count >= 2)
                    {
                        if ((Druzyna)Team2.SelectedItem != pom[0].Druzyna && (Druzyna)Team2.SelectedItem != pom[1].Druzyna)
                        {
                            return false;
                        }
                    }
                    else if (pom.Count == 1)
                    {
                        if ((Druzyna)Team2.SelectedItem != pom[0].Druzyna)
                        {
                            return false;
                        }
                    }
                    else if (pom.Count <= 0)
                    {

                        return false;

                    }
                }
                Rozgrywka pom1 = pomwyn;
                Rozgrywka pom2 = context.Rozgrywki.First(e => e.Id == filroz.RozgrywkaId);
                if (pom1.Place != null)
                {
                    if (pom1.Place != pom2.Place)
                    {
                        return false;
                    }
                }
                if (pom1.Sedziaglowny != null)
                {
                    if (pom1.Sedziaglowny != pom2.Sedziaglowny && pom1.Sedziaglowny != pom2.Sedziapom1 && pom1.Sedziaglowny != pom2.Sedziapom2 && pom1.Sedziaglowny != pom2.Sedziatechniczny)
                    {
                        return false;
                    }
                }
                if ((int)filroz.Wynik1[0] > (int)filroz.Wynik2[0])
                    if ((Druzyna)Won.SelectedItem != null)
                    {
                        var pom = context.Druzyna_Rozgrywka.Where(z => z.RozgrywkaId == filroz.RozgrywkaId).ToList();
                        if (pom.Count() < 2) return false;
                        if ((Druzyna)Won.SelectedItem != pom[0].Druzyna)
                            return false;
                    }
                if ((int)filroz.Wynik1[0] < (int)filroz.Wynik2[0])
                    if ((Druzyna)Won.SelectedItem != null)
                    {
                        var pom = context.Druzyna_Rozgrywka.Where(z => z.RozgrywkaId == filroz.RozgrywkaId).ToList();
                        if (pom.Count() < 2) return false;
                        if ((Druzyna)Won.SelectedItem != pom[1].Druzyna)
                            return false;
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
        private void Team1sel(object sender, SelectionChangedEventArgs e)
        {
            var pom = context.Druzyny.ToList();
            pom.Remove((Druzyna)Team1.SelectedItem);
            Team2.ItemsSource = pom;
            Won.Items.Clear();
            Won.Items.Add(Team1.SelectedItem);
            if(Team2.SelectedItem!=null)
            Won.Items.Add(Team2.SelectedItem);
        }
        private void Team2sel(object sender, SelectionChangedEventArgs e)
        {

            var pom = context.Druzyny.ToList();
            pom.Remove((Druzyna)Team2.SelectedItem);
            Team1.ItemsSource = pom;
            Won.Items.Clear();
            if (Team1.SelectedItem != null)
                Won.Items.Add(Team1.SelectedItem);
            Won.Items.Add(Team2.SelectedItem);
        }
    }
}
