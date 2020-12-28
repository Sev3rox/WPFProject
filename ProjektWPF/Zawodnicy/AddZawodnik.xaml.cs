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
         
            context.Zawodnicy.Add(addzaw);
            context.SaveChanges();
            DialogResult = true;
            this.Close();
        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
