using System;
using System.Collections.Generic;
using ProjektWPF.Data;
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
    /// Logika interakcji dla klasy FilterDruzyna.xaml
    /// </summary>
    public partial class FilterDruzyna : Window
    {
        ListCollectionView View;
        Druzyna druzynapomoc;
        public FilterDruzyna(ListCollectionView view)
        {
            InitializeComponent();
            this.View = view;
            druzynapomoc = new Druzyna();
            FilterGrid.DataContext = druzynapomoc;
        }
        private void Filtr(object sender, RoutedEventArgs e)
        {
            View.Filter = delegate (object item)
            {
                Druzyna druzyna = item as Druzyna;
                if (druzyna == null) { return false; }
                if (druzynapomoc.Country != null)
                {
                    if (druzynapomoc.Country != druzyna.Country) { return false; }
                }
                if (druzynapomoc.City != null)
                {
                    if (druzynapomoc.City != druzyna.City) { return false; }
                }
                return true;
            };
            this.Close();
        }
        private void Reset(object sender, RoutedEventArgs e)
        {
            View.Filter = null;
            this.Close();
        }
    }
}
