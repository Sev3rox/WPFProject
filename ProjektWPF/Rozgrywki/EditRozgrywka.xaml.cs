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
    /// Interaction logic for EditRozgrywka.xaml
    /// </summary>
    public partial class EditRozgrywka : Window
    {
    
        public ZawodnikDbContext context;
        public Rozgrywka editroz;
        public string Place { get; set; }
        public DateTime Date { get; set; }
        public int Hour { get; set; }
        public string Tournament { get; set; }
        public string Opis { get; set; }
        public string Sedziaglowny { get; set; }
        public string Sedziapom1 { get; set; }
        public string Sedziapom2 { get; set; }
        public string Sedziatechniczny { get; set; }

        public EditRozgrywka(ZawodnikDbContext context, Rozgrywka Rozgrywka)
        {
            this.context = context;
            InitializeComponent();
            editroz = Rozgrywka;
            EditGrid.DataContext = editroz;
            Place = editroz.Place;
            Date = editroz.Date;
            Hour = editroz.Hour;
            Opis = editroz.Opis;
            Sedziaglowny = editroz.Sedziaglowny;
            Sedziapom1 = editroz.Sedziapom1;
            Sedziapom2 = editroz.Sedziapom2;
            Sedziatechniczny = editroz.Sedziatechniczny;
        }

        private void Edit(object sender, RoutedEventArgs e)
        {
            context.Update(editroz);
            context.SaveChanges();
            this.Close();
        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            editroz.Place=Place;
            editroz.Date=Date;
            editroz.Hour = Hour;
            editroz.Opis=Opis;
            editroz.Sedziaglowny=Sedziaglowny;
            editroz.Sedziapom1=Sedziapom1;
            editroz.Sedziapom2=Sedziapom2;
            editroz.Sedziatechniczny=Sedziatechniczny;
            this.Close();
        }
    }
}
