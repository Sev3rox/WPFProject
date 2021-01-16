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
using System.Windows.Forms;

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
        public Druzyna_Rozgrywka dr1 { get; set; }
        public Druzyna_Rozgrywka dr2 { get; set; }

        public EditRozgrywka(ZawodnikDbContext context, Rozgrywka Rozgrywka)
        {
            this.context = context;
            InitializeComponent();
            Team2.ItemsSource = context.Druzyny.ToList();
            Team1.ItemsSource = context.Druzyny.ToList();
            editroz = Rozgrywka;
            var pom = context.Druzyna_Rozgrywka.Where(z => z.RozgrywkaId == editroz.Id).ToList();
          
            if (pom.Count > 0)
            {
                var pomm1 = context.Druzyny.ToList();
                pomm1.Remove(pom[0].Druzyna);
                Team2.ItemsSource = pomm1;
                Team1.SelectedItem = (pom[0].Druzyna);
            }
            else
                Team1.SelectedIndex = -1;
           
            if (pom.Count > 1)
            {
                var pomm2 = context.Druzyny.ToList();
                pomm2.Remove(pom[1].Druzyna);
                Team1.ItemsSource = pomm2;
                Team2.SelectedItem = (pom[1].Druzyna);
            }
            else
                Team2.SelectedIndex = -1;
            if (pom.Count > 0)
                dr1 = pom[0];
            if (pom.Count > 1)
                dr2 = pom[1];
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
            var valhou = Validation.GetErrors(HourTextBox);
            var valdat = Validation.GetErrors(DateCalendar);
            var valsed = Validation.GetErrors(SedziaglownyTextBox);
            var valpla = Validation.GetErrors(PlaceTextBox);

            if (valhou.Count == 0 && valdat.Count == 0 && valsed.Count == 0 && valpla.Count == 0)
            {
              
               
                if (((Druzyna)Team1.SelectedItem) != null)
                {
                    if (dr1 != null)
                    {
                        context.Druzyna_Rozgrywka.Remove(dr1);
                        context.SaveChanges();
                    }
                  
                }
                if (((Druzyna)Team2.SelectedItem) != null)
                {
                    if (dr2 != null)
                    {
                        context.Druzyna_Rozgrywka.Remove(dr2);
                        context.SaveChanges();
                    }
              
                }
                if (((Druzyna)Team1.SelectedItem) != null)
                {
                  
                    var pom1 = new Druzyna_Rozgrywka
                    {
                        DruzynaId = ((Druzyna)Team1.SelectedItem).Id,
                        RozgrywkaId = editroz.Id
                    };
                    context.Druzyna_Rozgrywka.Add(pom1);
                }
                if (((Druzyna)Team2.SelectedItem) != null)
                {
                 
                    var pom2 = new Druzyna_Rozgrywka
                    {
                        DruzynaId = ((Druzyna)Team2.SelectedItem).Id,
                        RozgrywkaId = editroz.Id
                    };
                    context.Druzyna_Rozgrywka.Add(pom2);
                }
                context.SaveChanges();
                context.Update(editroz);
                context.SaveChanges();
                NotifyIcon notifyIcon = new NotifyIcon();
                notifyIcon.Icon = new System.Drawing.Icon(@"../../../Files/info.ico");
                notifyIcon.Visible = true;
                notifyIcon.ShowBalloonTip(1000, "Operacja zakończona sukcesem", "Rozgrywka została zedytowana", ToolTipIcon.Info);
                this.Close();
            }
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
        private void HourFocus(object sender, RoutedEventArgs e)
        {


            if (HourTextBox.Text == "")
                HourTextBox.Text = "0";
        }

        private void HourVali(object sender, RoutedEventArgs e)
        {
            HourTextBox.Foreground = new SolidColorBrush(Colors.Black); ;
            editroz.Hour = 0;
            HourTextBox.Text = null;
        }


        private void PlaceVali(object sender, RoutedEventArgs e)
        {
            PlaceTextBox.Foreground = new SolidColorBrush(Colors.Black); ;
            editroz.Place = null;
            PlaceTextBox.Text = null;
        }
        private void SedziaglownyVali(object sender, RoutedEventArgs e)
        {
            SedziaglownyTextBox.Foreground = new SolidColorBrush(Colors.Black); ;
            editroz.Sedziaglowny = null;
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
        private void Team1sel(object sender, SelectionChangedEventArgs e)
        {
            var pom = context.Druzyny.ToList();
            pom.Remove((Druzyna)Team1.SelectedItem);
            Team2.ItemsSource = pom;
        }
        private void Team2sel(object sender, SelectionChangedEventArgs e)
        {

            var pom = context.Druzyny.ToList();
            pom.Remove((Druzyna)Team2.SelectedItem);
            Team1.ItemsSource = pom;

        }

    }
}
