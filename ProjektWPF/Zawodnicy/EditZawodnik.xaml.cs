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
            context.Update(editzaw);
            context.SaveChanges();
            this.Close();

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
    }
}
