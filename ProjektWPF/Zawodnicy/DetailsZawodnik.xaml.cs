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
    /// Interaction logic for DetailsZawodnik.xaml
    /// </summary>
    public partial class DetailsZawodnik : Window
    {
        Zawodnik detzaw;
        public DetailsZawodnik(Zawodnik Zawodnik)
        {
            InitializeComponent();
            detzaw = Zawodnik;
            DetailsGrid.DataContext = detzaw;
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
