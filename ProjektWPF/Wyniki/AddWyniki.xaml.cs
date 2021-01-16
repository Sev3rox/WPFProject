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

namespace ProjektWPF.Wyniki
{
    /// <summary>
    /// Logika interakcji dla klasy AddWyniki.xaml
    /// </summary>
    public partial class AddWyniki : Window
    {
        public Wynik addwyn;
        ZawodnikDbContext context;
        public AddWyniki(ZawodnikDbContext context)
        {
            this.context = context;
            InitializeComponent();
            addwyn = new Wynik();
            AddGrid.DataContext = addwyn;
            List<Rozgrywka> lis = new List<Rozgrywka>();
            var pom = context.Rozgrywki.ToList();
            foreach (Rozgrywka x in pom)
            {
                if (x.WynikId == null)
                    lis.Add(x);
            }
            Mecz.ItemsSource = lis;
            Mecz.SelectedIndex = -1;
        }
        private void Cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Add(object sender, RoutedEventArgs e)
        {
            var valwyn1 = Validation.GetErrors(WynikTextBox1);
            var valwyn2 = Validation.GetErrors(WynikTextBox2);
            if (valwyn1.Count == 0&& valwyn2.Count==0&&Mecz.SelectedIndex!=-1)
            {

                var pom = (Rozgrywka)Mecz.SelectedItem;
                addwyn.Rozgryweczka = pom.ToString();
                addwyn.Rozgrywka = pom;
                addwyn.RozgrywkaId = ((Rozgrywka)Mecz.SelectedItem).Id;
                context.Wyniki.Add(addwyn);
                context.SaveChanges();
                pom.WynikId = (context.Wyniki.First(e => e.RozgrywkaId == pom.Id)).Id;
                context.Update(pom);
                context.SaveChanges();
                DialogResult = true;
                NotifyIcon notifyIcon = new NotifyIcon();
                notifyIcon.Icon = new System.Drawing.Icon(@"../../../Files/info.ico");
                notifyIcon.Visible = true;
                notifyIcon.ShowBalloonTip(1000, "Operacja zakończona sukcesem", "Wyniki zostały dodane", ToolTipIcon.Info);
                this.Close();
            }
        }
        private void WynikVali1(object sender, RoutedEventArgs e)
        {
            WynikTextBox1.Foreground = new SolidColorBrush(Colors.Black); ;
            addwyn.Wynik1 = null;
            WynikTextBox1.Text = null;
        }
        private void WynikVali2(object sender, RoutedEventArgs e)
        {
            WynikTextBox2.Foreground = new SolidColorBrush(Colors.Black); ;
            addwyn.Wynik2 = null;
            WynikTextBox2.Text = null;
        }
        private void validationError(object sender, ValidationErrorEventArgs e)
        {

            if (e.Action == ValidationErrorEventAction.Added)
            {
                if (e.Error.ErrorContent.ToString() == "Wynik1 trzeba podać")
                {
                    WynikTextBox1.Foreground = new SolidColorBrush(Colors.Red);
                    WynikTextBox1.Text = e.Error.ErrorContent.ToString();
                }
                if (e.Error.ErrorContent.ToString() == "Wynik2 trzeba podać")
                {
                    WynikTextBox2.Foreground = new SolidColorBrush(Colors.Red);
                    WynikTextBox2.Text = e.Error.ErrorContent.ToString();
                }

            }

        }
    }
}
