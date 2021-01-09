using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
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
    /// Logika interakcji dla klasy DeleteZawodnikZDruzyny.xaml
    /// </summary>
    public partial class DeleteZawodnikZDruzyny : Window
    {
        public Druzyna druzyna;
        public Zawodnik zawodnik;
        ZawodnikDbContext context;

        public Collection<Zawodnik> zawodnicy { get; } = new ObservableCollection<Zawodnik>();
        
        public DeleteZawodnikZDruzyny(ZawodnikDbContext context, Druzyna Druzyna, Collection<Zawodnik> Zawodnicy)
        {
            this.context = context;
            InitializeComponent();
            druzyna = Druzyna;
            DeletZawdruz.DataContext = druzyna;
            foreach(var zawodnik in Zawodnicy)
            {
                if(zawodnik.Druzyna == druzyna)
                {
                    zawodnicy.Add(zawodnik);
                }
            }
            lista_zawodnikow.ItemsSource = zawodnicy;
        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            zawodnik = (Zawodnik)lista_zawodnikow.SelectedItem;
            druzyna.DeleteZawodnikZDruzyny(zawodnik);
            context.Update(druzyna);
            context.SaveChanges();
            this.Close();
        }
    }
}
