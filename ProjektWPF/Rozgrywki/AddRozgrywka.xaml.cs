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
            var x = addroz;
            context.Rozgrywki.Add(addroz);
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
