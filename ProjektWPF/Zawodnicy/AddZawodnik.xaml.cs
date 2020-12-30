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

namespace ProjektWPF.Zawodnicy
{
    /// <summary>
    /// Interaction logic for AddZawodnik.xaml
    /// </summary>
    public partial class AddZawodnik : Window
    {
       
        public Zawodnik addzaw;
        ZawodnikDbContext context;
        public AddZawodnik(ZawodnikDbContext context)
        {
            this.context = context;
            InitializeComponent();
            addzaw = new Zawodnik();
            AddGrid.DataContext = addzaw;
         

        }

        private void Add(object sender, RoutedEventArgs e)
        {
            var valnum = Validation.GetErrors(NumberTextBox);
            var valage = Validation.GetErrors(AgeTextBox);
            var valnam = Validation.GetErrors(NameTextBox);
            var valsur = Validation.GetErrors(SurnameTextBox);

            if (valnum.Count == 0 && valage.Count == 0 && valnam.Count == 0 && valsur.Count == 0)
            {
                context.Zawodnicy.Add(addzaw);
                context.SaveChanges();
                DialogResult = true;
                this.Close();
            }
        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void NumberFocus(object sender, RoutedEventArgs e)
        {


            if (NumberTextBox.Text == "")
                NumberTextBox.Text = "0";
        }
        private void AgeFocus(object sender, RoutedEventArgs e)
        {


            if (AgeTextBox.Text == "")
                AgeTextBox.Text = "0";
        }
        private void NumberVali(object sender, RoutedEventArgs e)
        {
         NumberTextBox.Foreground=new SolidColorBrush(Colors.Black); ;
            addzaw.Number=0;
            NumberTextBox.Text = null;
        }

        private void AgeVali(object sender, RoutedEventArgs e)
        {
            AgeTextBox.Foreground = new SolidColorBrush(Colors.Black); ;
            addzaw.Age = 0;
            AgeTextBox.Text = null;
        }
        private void NameVali(object sender, RoutedEventArgs e)
        {
            NameTextBox.Foreground = new SolidColorBrush(Colors.Black); ;
            addzaw.Name = null;
            NameTextBox.Text =null;
        }
        private void SurnameVali(object sender, RoutedEventArgs e)
        {
            SurnameTextBox.Foreground = new SolidColorBrush(Colors.Black); ;
            addzaw.Surname = null;
            SurnameTextBox.Text = null;
        }
        private void validationError(object sender, ValidationErrorEventArgs e)
        {
          
                if (e.Action == ValidationErrorEventAction.Added)
                {
                    if (e.Error.ErrorContent.ToString() == "Numer musi być większy od 0")
                    {
                        NumberTextBox.Foreground= new SolidColorBrush(Colors.Red);
                        NumberTextBox.Text = e.Error.ErrorContent.ToString();
                    }

                if (e.Error.ErrorContent.ToString() == "Numer musi być mniejszy od 100")
                {
                    NumberTextBox.Foreground = new SolidColorBrush(Colors.Red);
                    NumberTextBox.Text = e.Error.ErrorContent.ToString();
                }

                if (e.Error.ErrorContent.ToString() == "Minimalny wiek to 12 lat")
                {
                    AgeTextBox.Foreground = new SolidColorBrush(Colors.Red);
                    AgeTextBox.Text = e.Error.ErrorContent.ToString();
                }
                if (e.Error.ErrorContent.ToString() == "Imie musi być podane")
                {
                    NameTextBox.Foreground = new SolidColorBrush(Colors.Red);
                    NameTextBox.Text = e.Error.ErrorContent.ToString();
                }
                if (e.Error.ErrorContent.ToString() == "Nazwisko musi być podane")
                {
                    SurnameTextBox.Foreground = new SolidColorBrush(Colors.Red);
                    SurnameTextBox.Text = e.Error.ErrorContent.ToString();
                }
            }
          
        }
    }
}
