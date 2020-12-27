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

namespace ProjektWPF.Druzyny
{
    /// <summary>
    /// Logika interakcji dla klasy EditDruzyny.xaml
    /// </summary>
    public partial class EditDruzyny : Window
    {
        public EditDruzyny()
        {
            InitializeComponent();
        }
        private void Add(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
