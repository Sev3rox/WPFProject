using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjektWPF.Data;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace ProjektWPF.Druzyny
{
    /// <summary>
    /// Logika interakcji dla klasy EditDruzyny.xaml
    /// </summary>
    public partial class EditDruzyny : Window
    {
        public Druzyna editdruzyna;
        public ZawodnikDbContext context;

        public string Nazwa;
        public string Country;
        public string City;
        public string Succes;
        public string Sponsors;
        public string Owner;
        public EditDruzyny(ZawodnikDbContext context, Druzyna Druzyna)
        {
            this.context = context;
            InitializeComponent();
            editdruzyna = Druzyna;
            EditDruz.DataContext = editdruzyna;
            Nazwa = editdruzyna.Nazwa;
            Country = editdruzyna.Country;
            City = editdruzyna.City;
            Succes = editdruzyna.Succes;
            Sponsors = editdruzyna.Sponsors;
            Owner = editdruzyna.Owner;
        }
        private void Edit(object sender, RoutedEventArgs e)
        {
            var validname = Validation.GetErrors(NazwaTextBox);
            var validcountry = Validation.GetErrors(KrajTextBox);
            var validcity = Validation.GetErrors(SiedzibaTextBox);
            var validowner = Validation.GetErrors(WlasicielTextBox);
            var validsponsors = Validation.GetErrors(SponsorzyTextBox);
            var validsucces = Validation.GetErrors(SukcesyTextBox);

            if (validname.Count == 0 && validcountry.Count == 0 && validsucces.Count == 0 &&
                validcity.Count == 0 && validowner.Count == 0 && validsponsors.Count == 0)
            {
                context.Update(editdruzyna);
                context.SaveChanges();
                this.Close();
            }
        }
        private void Cancel(object sender, RoutedEventArgs e)
        {
            editdruzyna.Nazwa = Nazwa;
            editdruzyna.Country = Country;
            editdruzyna.City = City;
            editdruzyna.Sponsors = Sponsors;
            editdruzyna.Succes = Succes;
            editdruzyna.Owner = Owner;
            this.Close();
        }

        private void NazwaValid(object sender, RoutedEventArgs e)
        {
            NazwaTextBox.Foreground = new SolidColorBrush(Colors.Black);
            editdruzyna.Nazwa = null;
            NazwaTextBox.Text = null;
        }
        private void KrajValid(object sender, RoutedEventArgs e)
        {
            KrajTextBox.Foreground = new SolidColorBrush(Colors.Black);
            editdruzyna.Country = null;
            KrajTextBox.Text = null;
        }
        private void SiedzibaValid(object sender, RoutedEventArgs e)
        {
            SiedzibaTextBox.Foreground = new SolidColorBrush(Colors.Black);
            editdruzyna.City = null;
            SiedzibaTextBox.Text = null;
        }
        private void SponsorzyValid(object sender, RoutedEventArgs e)
        {
            SponsorzyTextBox.Foreground = new SolidColorBrush(Colors.Black);
            editdruzyna.Sponsors = null;
            SponsorzyTextBox.Text = null;
        }
        private void WlascicielValid(object sender, RoutedEventArgs e)
        {
            WlasicielTextBox.Foreground = new SolidColorBrush(Colors.Black);
            editdruzyna.Owner = null;
            WlasicielTextBox.Text = null;
        }

        private void validationError(object sender, ValidationErrorEventArgs e)
        {
            if(e.Action == ValidationErrorEventAction.Added)
            {
                if (e.Error.ErrorContent.ToString() == "Nazwę klubu trzeba podać")
                {
                    NazwaTextBox.Foreground = new SolidColorBrush(Colors.Red);
                    NazwaTextBox.Text = e.Error.ErrorContent.ToString();
                }

                if (e.Error.ErrorContent.ToString() == "Kraj trzeba podać")
                {
                    KrajTextBox.Foreground = new SolidColorBrush(Colors.Red);
                    KrajTextBox.Text = e.Error.ErrorContent.ToString();
                }

                if (e.Error.ErrorContent.ToString() == "Miasto trzeba podać")
                {
                    SiedzibaTextBox.Foreground = new SolidColorBrush(Colors.Red);
                    SiedzibaTextBox.Text = e.Error.ErrorContent.ToString();
                }
                if (e.Error.ErrorContent.ToString() == "Właściciela trzeba podać")
                {
                    WlasicielTextBox.Foreground = new SolidColorBrush(Colors.Red);
                    WlasicielTextBox.Text = e.Error.ErrorContent.ToString();
                }
            }
        }
        private void ImageFromFile(object sender, RoutedEventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                BitmapImage bt = new BitmapImage();
                bt.BeginInit();
                bt.UriSource = new Uri(openFileDialog.FileName);
                bt.EndInit();
                imgDynamic.Source = bt;
                editdruzyna.ImagePath = ((BitmapImage)imgDynamic.Source).UriSource.AbsoluteUri;
            }
        }
    }
}
