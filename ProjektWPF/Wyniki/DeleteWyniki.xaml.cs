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
    /// Logika interakcji dla klasy DeleteWyniki.xaml
    /// </summary>
    public partial class DeleteWyniki : Window
    {
        public int Id;
        ZawodnikDbContext context;
        public DeleteWyniki(ZawodnikDbContext context)
        {
            InitializeComponent();
            this.context = context;
        }
        private void Del(object sender, RoutedEventArgs e)
        {

            var pom = context.Wyniki.First(a => a.Id == Id);
            var pom2 = context.Rozgrywki.First(e => e.WynikId == Id);
            pom2.WynikId = null;
            context.Wyniki.Remove(pom);
            context.SaveChanges();
            DialogResult = true;
            NotifyIcon notifyIcon = new NotifyIcon();
            notifyIcon.Icon = new System.Drawing.Icon(@"../../../Files/info.ico");
            notifyIcon.Visible = true;
            notifyIcon.ShowBalloonTip(1000, "Operacja zakończona sukcesem", "Wyniki zostały usunięte", ToolTipIcon.Info);
            this.Close();

        }

        private void Cancel(object sender, RoutedEventArgs e)
        {


            this.Close();
        }
    }
}
