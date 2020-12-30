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
    /// Interaction logic for EditZawodnik.xaml
    /// </summary>
    public partial class EditZawodnik : Window
    {
        public Zawodnik editzaw;
        public ZawodnikDbContext context;

        public string Name;
        public string Surname;
        public int Number;
        public int Age;
        public string Adres;
        public string Position;
        public bool Leftleg;
        public bool Rightleg;

        public int Spotkania;
        public int Gole;
        public int Asysty;
        public int Redcard;
        public int Yellowcard;
        public int Minuty;
        public int Strzaly;
        public int Nabramke;
        public EditZawodnik(ZawodnikDbContext context, Zawodnik Zawodnik)
        {this.context=context;
            InitializeComponent();
            editzaw = Zawodnik;
            EditGrid.DataContext = editzaw;
            Name = editzaw.Name;
            Surname = editzaw.Surname;
            Number = editzaw.Number;
            Age = editzaw.Age;
            Adres = editzaw.Adres;
            Position = editzaw.Position;
            Leftleg = editzaw.Leftleg;
            Rightleg = editzaw.Rightleg;
            Spotkania = editzaw.Spotkania;
            Gole = editzaw.Gole;
            Asysty = editzaw.Asysty;
            Redcard = editzaw.Redcard;
            Yellowcard = editzaw.Yellowcard;
            Minuty = editzaw.Minuty;
            Strzaly = editzaw.Strzaly;
            Nabramke = editzaw.Nabramke;
        }

        private void Edit(object sender, RoutedEventArgs e)
        {

            var valnum = Validation.GetErrors(NumberTextBox);
            var valage = Validation.GetErrors(AgeTextBox);
            var valnam = Validation.GetErrors(NameTextBox);
            var valsur = Validation.GetErrors(SurnameTextBox);

            if (valnum.Count == 0 && valage.Count == 0 && valnam.Count == 0 && valsur.Count == 0)
            {


                context.Update(editzaw);
                context.SaveChanges();
                this.Close();
            }

        }
        
        private void Reset(object sender, RoutedEventArgs e)
        {
            editzaw.Name = Name;
            editzaw.Surname = Surname;
            editzaw.Number = Number;
            editzaw.Age = Age;
            editzaw.Adres = Adres;
            editzaw.Position = Position;
            editzaw.Leftleg = Leftleg;
            editzaw.Rightleg = Rightleg;
            editzaw.Spotkania = Spotkania;
            editzaw.Gole = Gole;
            editzaw.Asysty = Asysty;
            editzaw.Redcard = Redcard;
            editzaw.Yellowcard = Yellowcard;
            editzaw.Minuty = Minuty;
            editzaw.Strzaly = Strzaly;
            editzaw.Nabramke = Nabramke;
           
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
            NumberTextBox.Foreground = new SolidColorBrush(Colors.Black); ;
            editzaw.Number = 0;
            NumberTextBox.Text = null;
        }

        private void AgeVali(object sender, RoutedEventArgs e)
        {
            AgeTextBox.Foreground = new SolidColorBrush(Colors.Black); ;
            editzaw.Age = 0;
            AgeTextBox.Text = null;
        }
        private void NameVali(object sender, RoutedEventArgs e)
        {
            NameTextBox.Foreground = new SolidColorBrush(Colors.Black); ;
            editzaw.Name = null;
            NameTextBox.Text = null;
        }
        private void SurnameVali(object sender, RoutedEventArgs e)
        {
            SurnameTextBox.Foreground = new SolidColorBrush(Colors.Black); ;
            editzaw.Surname = null;
            SurnameTextBox.Text = null;
        }
        private void validationError(object sender, ValidationErrorEventArgs e)
        {

            if (e.Action == ValidationErrorEventAction.Added)
            {
                if (e.Error.ErrorContent.ToString() == "Numer musi być większy od 0")
                {
                    NumberTextBox.Foreground = new SolidColorBrush(Colors.Red);
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
