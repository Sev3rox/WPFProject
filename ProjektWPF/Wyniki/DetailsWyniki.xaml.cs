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
    /// Logika interakcji dla klasy DetailsWyniki.xaml
    /// </summary>
    public partial class DetailsWyniki : Window
    {
        Wynik detwyn;
        ZawodnikDbContext context;
        public DetailsWyniki(Wynik Wynik, ZawodnikDbContext context)
        {
            InitializeComponent();
            detwyn = Wynik;
            DetailsGrid.DataContext = detwyn;
            this.context = context;

            //var pom = context.Druzyna_Rozgrywka.Where(z => z.RozgrywkaId == detroz.Id).ToList();
            var pom = context.Druzyna_Rozgrywka.Where(z => z.RozgrywkaId == detwyn.RozgrywkaId).ToList();
            if (pom.Count > 1)
            {
                Team1.Content = pom[0].Druzyna.Nazwa;
                Team2.Content = pom[1].Druzyna.Nazwa;
                Image1.Source = new BitmapImage(new Uri(pom[0].Druzyna.ImagePath));
                Image2.Source = new BitmapImage(new Uri(pom[1].Druzyna.ImagePath));
            }
            else if (pom.Count == 1)
            {
                Team1.Content = pom[0].Druzyna.Nazwa;
                Team2.Content = "";
                Image1.Source = new BitmapImage(new Uri(pom[0].Druzyna.ImagePath));
                Image2.Source = null;

            }
            else
            {
                Team1.Content = "";
                Team2.Content = "";
                Image1.Source = null;
                Image2.Source = null;
            }
            Rozgrywka roz = context.Rozgrywki.First(e => e.Id == (Wynik).RozgrywkaId);
            Miejsce.Content = roz.Place;
            Opis.Content = roz.Opis;
            Turniej.Content = roz.Turniej;
            SedziaGlow.Content = roz.Sedziaglowny;
            Sedziatech.Content = roz.Sedziatechniczny;
            Sedziepom11.Content = roz.Sedziapom1;
            Sedziepom22.Content = roz.Sedziapom2;
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
