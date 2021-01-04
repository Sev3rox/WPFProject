using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjektWPF.Data;
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
    /// Logika interakcji dla klasy DeleteDruzyna.xaml
    /// </summary>
    public partial class DeleteDruzyna : Window
    {
        public int Id;
        ZawodnikDbContext context;
        public DeleteDruzyna(ZawodnikDbContext context)
        {
            InitializeComponent();
            this.context = context;
        }
        private void Del(object sender, RoutedEventArgs e)
        {
            var temp = context.Druzyny.First(a => a.Id == Id);
            var pom = context.Druzyny.First(a => a.Id == Id);
            context.Druzyny.Remove(pom);
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
