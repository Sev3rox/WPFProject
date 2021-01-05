using Microsoft.Win32;
using ProjektWPF.Data;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace ProjektWPF.Druzyny
{
    /// <summary>
    /// Logika interakcji dla klasy AddDruzyna.xaml
    /// </summary>
    public partial class AddDruzyna : Window
    {

        public Druzyna adddruzyna;
        ZawodnikDbContext context;
        
        public AddDruzyna(ZawodnikDbContext context)
        {
            this.context = context;
            InitializeComponent();
            adddruzyna = new Druzyna();
            AddDruzGrid.DataContext = adddruzyna;
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            var validname = Validation.GetErrors(NazwaTextBox);
            var validcountry = Validation.GetErrors(KrajTextBox);
            var validcity = Validation.GetErrors(SiedzibaTextBox);
            var validowner = Validation.GetErrors(WlasicielTextBox);
            var validsponsors = Validation.GetErrors(SponsorzyTextBox);

            if(validname.Count == 0 && validcountry.Count == 0 &&
                validcity.Count ==0 && validowner.Count == 0 && validsponsors.Count == 0)
            {
                context.Druzyny.Add(adddruzyna);
                context.SaveChanges();
                DialogResult = true;
                this.Close();
            }
        }



        private void Cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void NazwaValid(object sender, RoutedEventArgs e)
        {
            NazwaTextBox.Foreground = new SolidColorBrush(Colors.Black);
            adddruzyna.Nazwa = null;
            NazwaTextBox.Text = null;
        }
        private void KrajValid(object sender, RoutedEventArgs e)
        {
            KrajTextBox.Foreground = new SolidColorBrush(Colors.Black);
            adddruzyna.Country = null;
            KrajTextBox.Text = null;
        }
        private void SiedzibaValid(object sender, RoutedEventArgs e)
        {
            SiedzibaTextBox.Foreground = new SolidColorBrush(Colors.Black);
            adddruzyna.City = null;
            SiedzibaTextBox.Text = null;
        }
        private void SponsorzyValid(object sender, RoutedEventArgs e)
        {
            SponsorzyTextBox.Foreground = new SolidColorBrush(Colors.Black);
            adddruzyna.Sponsors = null;
            SponsorzyTextBox.Text = null;
        }
        private void WlascicielValid(object sender, RoutedEventArgs e)
        {
            WlasicielTextBox.Foreground = new SolidColorBrush(Colors.Black);
            adddruzyna.Owner = null;
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
        public string ImageDirectory { get; set; }
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
                adddruzyna.ImagePath = ((BitmapImage)imgDynamic.Source).UriSource.AbsoluteUri;
            }
        }
    }
}
