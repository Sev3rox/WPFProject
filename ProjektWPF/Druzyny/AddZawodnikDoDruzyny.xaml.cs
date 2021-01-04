using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public Collection<Zawodnik> zawodnicy { get; } = new ObservableCollection<Zawodnik>();
        public AddZawodnikDoDruzyny(ZawodnikDbContext context, Druzyna Druzyna, 
            Collection<Zawodnik> Zawodnicy)
        {
            this.context = context;
            InitializeComponent();
            druzyna = Druzyna;
            Zawdruz.DataContext = druzyna;
            zawodnicy = Zawodnicy;
            lista_zawodnikow.ItemsSource = zawodnicy;
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            zawodnik = (Zawodnik)lista_zawodnikow.SelectedItem;
            druzyna.AddZawodnikDoDruzyny(zawodnik);
            context.Update(druzyna);
            context.SaveChanges();
            this.Close();
        }
        private void Cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
