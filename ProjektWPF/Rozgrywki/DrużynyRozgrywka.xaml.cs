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
    /// Interaction logic for DrużynyRozgrywka.xaml
    /// </summary>
    public partial class DrużynyRozgrywka : Window
    {
        Rozgrywka druroz;
        ZawodnikDbContext context;
        public DrużynyRozgrywka(Rozgrywka roz, ZawodnikDbContext context)
        {
            InitializeComponent();
            this.druroz = roz;
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
