using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using ProjektWPF.Data;

namespace ProjektWPF.Druzyny
{
    /// <summary>
    /// Logika interakcji dla klasy AddZawodnikDoDruzyny.xaml
    /// </summary>
    public partial class AddZawodnikDoDruzyny : Window
    {
        public Druzyna druzyna;
        public Zawodnik zawodnik;
        ZawodnikDbContext context;
        public Collection<Zawodnik> zawodnicy { get; } = new ObservableCollection<Zawodnik>();
        public AddZawodnikDoDruzyny(ZawodnikDbContext context, Druzyna Druzyna, 
            Collection<Zawodnik> Zawodnicy)
        {
            this.context = context;
            InitializeComponent();
            druzyna = Druzyna;
            Zawdruz.DataContext = druzyna;
            foreach(var zawodnik in Zawodnicy)
            {
                if(zawodnik.Druzyna == null)
                {
                    zawodnicy.Add(zawodnik);
                }
            }
            lista_zawodnikow.ItemsSource = zawodnicy;
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            zawodnik = (Zawodnik)lista_zawodnikow.SelectedItem;
            druzyna.AddZawodnikDoDruzyny(zawodnik);
            context.Update(druzyna);
            context.SaveChanges();
            NotifyIcon notifyIcon = new NotifyIcon();
            notifyIcon.Icon = new System.Drawing.Icon(@"../../../Files/info.ico");
            notifyIcon.Visible = true;
            notifyIcon.ShowBalloonTip(1000, "Operacja zakończona sukcesem", "Zawodnik" + zawodnik.ToString() +  " został dodany do drużyny " + druzyna.ToString(), ToolTipIcon.Info);
            this.Close();
        }
        private void Cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
