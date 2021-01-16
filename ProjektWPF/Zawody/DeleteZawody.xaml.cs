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

namespace ProjektWPF.Zawody
{
    /// <summary>
    /// Logika interakcji dla klasy DeleteZawody.xaml
    /// </summary>
    public partial class DeleteZawody : Window
    {
        public int Id;
        ZawodnikDbContext context;
        public DeleteZawody(ZawodnikDbContext context,int Id)
        {
            InitializeComponent();
            this.context = context;
            this.Id = Id;
        }

        private void Del(object sender, RoutedEventArgs e)
        {

            var pom = context.Zawodys.First(a => a.Id == Id);
            context.Zawodys.Remove(pom);
            var pom2 = context.Druzyna_Zawody.Where(a => a.ZawodyId == Id).ToList();
            foreach(Druzyna_Zawody x in pom2)
            {
                context.Druzyna_Zawody.Remove(x);
            }
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
