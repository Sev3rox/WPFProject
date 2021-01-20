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
namespace ProjektWPF.Zawody
{
    /// <summary>
    /// Logika interakcji dla klasy EditZawody.xaml
    /// </summary>
    public partial class EditZawody : Window
    {
        public Zawodys addzaw;
        ZawodnikDbContext context;
        public DateTime DataStart { get; set; }
        public DateTime DataStop { get; set; }
        public string rodzaj { get; set; }
        public string nazwa { get; set; }
        public EditZawody(ZawodnikDbContext context, Zawodys zawodys)
        {
            this.context = context;
            InitializeComponent();
            addzaw = zawodys;
            AddGrid.DataContext = addzaw;
            DataStart = addzaw.DataStart;
            DataStop = addzaw.DataStop;
            nazwa = addzaw.nazwa;
            rodzaj = addzaw.rodzaj;
        }
        private void Add(object sender, RoutedEventArgs e)
        {
            var valhou = Validation.GetErrors(NazwaB);
            var valdat = Validation.GetErrors(DataStartB);
            var valsed = Validation.GetErrors(DataStopB);


            if (valhou.Count == 0 && valdat.Count == 0 && valsed.Count == 0)
            {
                context.Update(addzaw);
                context.SaveChanges();
                DialogResult = true;
                NotifyIcon notifyIcon = new NotifyIcon();
                notifyIcon.Icon = new System.Drawing.Icon(@"../../../Files/info.ico");
                notifyIcon.Visible = true;
                notifyIcon.ShowBalloonTip(1000, "Operacja zakończona sukcesem", "Zawody zostały zedytowane", ToolTipIcon.Info);
                this.Close();
            }
        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            addzaw.DataStop = DataStop;
            addzaw.DataStart = DataStart;
            addzaw.nazwa = nazwa;
            addzaw.rodzaj = rodzaj;

            this.Close();
        }
        private void NameVali(object sender, RoutedEventArgs e)
        {
            NazwaB.Foreground = new SolidColorBrush(Colors.Black); ;
            addzaw.nazwa = null;
            NazwaB.Text = null;
        }

        private void validationError(object sender, ValidationErrorEventArgs e)
        {

            if (e.Action == ValidationErrorEventAction.Added)
            {
                if (e.Error.ErrorContent.ToString() == "Nazwę trzeba podać")
                {
                    NazwaB.Foreground = new SolidColorBrush(Colors.Red);
                    NazwaB.Text = e.Error.ErrorContent.ToString();
                }

                if (e.Error.ErrorContent.ToString() == "Datę rozpoczęcia trzeba podać")
                {

                }

                if (e.Error.ErrorContent.ToString() == "Datę zakończenia trzeba podać")
                {

                }

            }
        }
    }
}