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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ProjektWPF.Zawody;
using ProjektWPF.Wyniki;
using ProjektWPF.Zawodnicy;
using ProjektWPF.Rozgrywki;
using ProjektWPF.Druzyny;

namespace ProjektWPF
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //elo
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Drabinka d = new Drabinka();
            d.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AddZawody add = new AddZawody();
            add.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AddWyniki add = new AddWyniki();
            add.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            AddZawody add = new AddZawody();
            add.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            DeleteZawody add = new DeleteZawody();
            add.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            FiltrZawody add = new FiltrZawody();
            add.Show();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            FiltrWyniki add = new FiltrWyniki();
            add.Show();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            DeleteWyniki add = new DeleteWyniki();
            add.Show();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            TeamWyniki add = new TeamWyniki();
            add.Show();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            DetailsWyniki add = new DetailsWyniki();
            add.Show();
        }

        private void AddZawodnik(object sender, RoutedEventArgs e)
        {
            AddZawodnik add = new AddZawodnik();
            add.Show();
        }

        private void DetailsZawodnik(object sender, RoutedEventArgs e)
        {
            DetailsZawodnik det = new DetailsZawodnik();
            det.Show();
        }

        private void DelZawodnik(object sender, RoutedEventArgs e)
        {
            DeleteZawodnik del = new DeleteZawodnik();
            del.Show();
        }

        private void EditZawodnik(object sender, RoutedEventArgs e)
        {
            EditZawodnik edit = new EditZawodnik();
            edit.Show();
        }

        private void FilterZawodnik(object sender, RoutedEventArgs e)
        {
            FilterZawodnik filtr = new FilterZawodnik();
            filtr.Show();
        }

        private void DeatailsRozgrywka(object sender, RoutedEventArgs e)
        {
            DetailsRozgrywka addroz = new DetailsRozgrywka();
            addroz.Show();
        }

        private void AddRozgrywka(object sender, RoutedEventArgs e)
        {
            AddRozgrywka addroz = new AddRozgrywka();
            addroz.Show();
        }

        private void EditRozgrywka(object sender, RoutedEventArgs e)
        {
            EditRozgrywka editroz = new EditRozgrywka();
            editroz.Show();
        }

        private void DelRozgrywka(object sender, RoutedEventArgs e)
        {
            DeleteRozgrywka delroz = new DeleteRozgrywka();
            delroz.Show();
        }

        private void FilterRozgrywka(object sender, RoutedEventArgs e)
        {
            FilterRozgrywka filtrroz = new FilterRozgrywka();
            filtrroz.Show();
        }

        private void DrużynyRozgrywka(object sender, RoutedEventArgs e)
        {
            DrużynyRozgrywka druroz = new DrużynyRozgrywka();
            druroz.Show();
        }

        private void DodajDruzyne(object sender, RoutedEventArgs e)
        {
            AddDruzyna druzynadodaj = new AddDruzyna();
            druzynadodaj.Show();
        }

        private void DodajZawodnikaDoDruzyny(object sender, RoutedEventArgs e)
        {
            AddZawodnikDoDruzyny addZawodnikDoDruzyny = new AddZawodnikDoDruzyny();
            addZawodnikDoDruzyny.Show();
        }

        private void FiltrujDruzyne(object sender, RoutedEventArgs e)
        {
            FilterDruzyna filterDruzyna = new FilterDruzyna();
            filterDruzyna.Show();
        }

        private void UsunDruzyne(object sender, RoutedEventArgs e)
        {
            DeleteDruzyna deleteDruzyna = new DeleteDruzyna();
            deleteDruzyna.Show();
        }

        private void EdytujDruzyne(object sender, RoutedEventArgs e)
        {
            EditDruzyny editDruzyny = new EditDruzyny();
            editDruzyny.Show();
        }
    }
}
