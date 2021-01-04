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
using ProjektWPF.Data;

namespace ProjektWPF.Druzyny
{
    /// <summary>
    /// Logika interakcji dla klasy AddZawodnikDoDruzyny.xaml
    /// </summary>
    public partial class AddZawodnikDoDruzyny : Window
    { 
        public Druzyna druzyna;
        public Zawodnik zawodnik;
        ZawodnikDbContext context;
        public AddZawodnikDoDruzyny(ZawodnikDbContext context)
        {
            this.context = context;
            InitializeComponent();
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            if (lista_zawodnikow.Items.Count != 0)
            {
                zawodnik = (Zawodnik)lista_zawodnikow.SelectedItem;
                druzyna.AddZawodnikDoDruzyny(zawodnik);
            }
            this.Close();
        }
        private void Cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
