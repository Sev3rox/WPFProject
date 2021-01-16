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
namespace ProjektWPF.Zawody
{
    /// <summary>
    /// Logika interakcji dla klasy AddDruzynaDoZawody.xaml
    /// </summary>
    public partial class AddDruzynaDoZawody : Window
    {
        public Druzyna druzyna;
        public Zawodys zawodys;
        ZawodnikDbContext context;
        public List<Druzyna> pom=new List<Druzyna>();
        public AddDruzynaDoZawody(ZawodnikDbContext context, Zawodys zawodys)
        {
            this.context = context;
            this.zawodys = zawodys;
            InitializeComponent();
            pom = context.Druzyny.ToList();
            var pom2= context.Druzyny.ToList();
            for (int i=0;i<pom2.Count; i++)
            { var Druzyna = pom2[i];
                if (context.Druzyna_Zawody.FirstOrDefault(e => e.DruzynaId == Druzyna.Id && e.ZawodyId == zawodys.Id)!=null)
                    pom.Remove(Druzyna);
            }
            lista_druzyn.ItemsSource = pom;
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            if (lista_druzyn.SelectedItem != null)
            {
                druzyna = (Druzyna)lista_druzyn.SelectedItem;
                Druzyna_Zawody temp = new Druzyna_Zawody
                {
                    DruzynaId = druzyna.Id,
                    ZawodyId = zawodys.Id
                };
                context.Druzyna_Zawody.Add(temp);
                pom.Remove(druzyna);
                if (pom.Count() <= context.Druzyny.Count())
                    AddButton.IsEnabled = false;
                else AddButton.IsEnabled = true;
                context.SaveChanges();
                NotifyIcon notifyIcon = new NotifyIcon();
                notifyIcon.Icon = new System.Drawing.Icon(@"../../../Files/info.ico");
                notifyIcon.Visible = true;
                notifyIcon.ShowBalloonTip(1000, "Operacja zakończona sukcesem", "Drużyna" + druzyna.ToString() + "została dodana do zawodów", ToolTipIcon.Info);
                this.Close();
            }
        }
        private void Cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
