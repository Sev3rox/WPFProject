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
    /// Logika interakcji dla klasy TeamWyniki.xaml
    /// </summary>
    public partial class TeamWyniki : Window
    {
        Rozgrywka druroz;
        Wynik druwyn;
        ZawodnikDbContext context;
        public TeamWyniki(Wynik wyn, ZawodnikDbContext context)
        {
            InitializeComponent();
            this.druwyn = wyn;
            this.druroz=context.Rozgrywki.First(e => e.Id == druwyn.RozgrywkaId);
            this.context = context;
            var pom = context.Druzyna_Rozgrywka.Where(z => z.RozgrywkaId == druroz.Id).ToList();
            if (pom.Count > 0)
            {
                Team1.Content = pom[0].Druzyna.Nazwa;
                lista1.ItemsSource = pom[0].Druzyna.lista_zawodnikow;
            }
            if (pom.Count > 1)
            {
                Team2.Content = pom[1].Druzyna.Nazwa;
                lista2.ItemsSource = pom[1].Druzyna.lista_zawodnikow;
            }
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
