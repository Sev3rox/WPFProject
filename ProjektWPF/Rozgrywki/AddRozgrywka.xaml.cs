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
    /// Interaction logic for AddRozgrywka.xaml
    /// </summary>
    public partial class AddRozgrywka : Window
    {
        public Rozgrywka addroz;
        ZawodnikDbContext context;
        public AddRozgrywka(ZawodnikDbContext context)
        {
            this.context = context;
            InitializeComponent();
            addroz = new Rozgrywka();
            AddGrid.DataContext = addroz;
        }

            private void Add(object sender, RoutedEventArgs e)
            {
            var valhou = Validation.GetErrors(HourTextBox);
            var valdat = Validation.GetErrors(DateCalendar);
            var valsed = Validation.GetErrors(SedziaglownyTextBox);
            var valpla = Validation.GetErrors(PlaceTextBox);

            if (valhou.Count == 0 && valdat.Count == 0 && valsed.Count == 0 && valpla.Count == 0)
            {
                context.Rozgrywki.Add(addroz);
                context.SaveChanges();
                DialogResult = true;
                this.Close();
            }
            }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void HourFocus(object sender, RoutedEventArgs e)
        {


            if (HourTextBox.Text == "")
                HourTextBox.Text = "0";
        }
      
        private void HourVali(object sender, RoutedEventArgs e)
        {
            HourTextBox.Foreground = new SolidColorBrush(Colors.Black); ;
            addroz.Hour = 0;
            HourTextBox.Text = null;
        }

       
        private void PlaceVali(object sender, RoutedEventArgs e)
        {
            PlaceTextBox.Foreground = new SolidColorBrush(Colors.Black); ;
            addroz.Place = null;
            PlaceTextBox.Text = null;
        }
        private void SedziaglownyVali(object sender, RoutedEventArgs e)
        {
            SedziaglownyTextBox.Foreground = new SolidColorBrush(Colors.Black); ;
            addroz.Sedziaglowny = null;
            SedziaglownyTextBox.Text = null;
        }
        private void validationError(object sender, ValidationErrorEventArgs e)
        {

            if (e.Action == ValidationErrorEventAction.Added)
            {
                if (e.Error.ErrorContent.ToString() == "Godzina musi być większa od 0")
                {
                    HourTextBox.Foreground = new SolidColorBrush(Colors.Red);
                    HourTextBox.Text = e.Error.ErrorContent.ToString();
                }

                if (e.Error.ErrorContent.ToString() == "Godzina musi być mniejsza od 24")
                {
                    HourTextBox.Foreground = new SolidColorBrush(Colors.Red);
                    HourTextBox.Text = e.Error.ErrorContent.ToString();
                }

                if (e.Error.ErrorContent.ToString() == "Data musi być podana")
                {
                    
                }
                if (e.Error.ErrorContent.ToString() == "Miejsce musi być podane")
                {
                   
     
                }
                if (e.Error.ErrorContent.ToString() == "Obowiązkowe")
                {
                    SedziaglownyTextBox.Foreground = new SolidColorBrush(Colors.Red);
                    SedziaglownyTextBox.Text = e.Error.ErrorContent.ToString();
                }
            }

        }

        
    }
}
