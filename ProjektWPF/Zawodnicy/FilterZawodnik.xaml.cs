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
    /// Interaction logic for FilterZawodnik.xaml
    /// </summary>
    public partial class FilterZawodnik : Window
    {
        ListCollectionView View;
        Zawodnik pomzaw;
        public FilterZawodnik(ListCollectionView View)
        {
            InitializeComponent();
            this.View = View;
            pomzaw = new Zawodnik();
            FiltrGrid.DataContext = pomzaw;
            
        }

        private void Filtr(object sender, RoutedEventArgs e)
        {
       
                View.Filter = delegate (object item)
                {
                    Zawodnik filzaw = item as Zawodnik;
                    if (filzaw == null)
                    {
                        return false;
                    }

                    if (pomzaw.Age!=0)
                    {
                        if(pomzaw.Age != filzaw.Age)
                        {
                            return false;
                        }
                    }

                    if (pomzaw.Position != null)
                    {
                        if (pomzaw.Position != filzaw.Position)
                        {
                            return false;
                        }
                    }

                    if (pomzaw.Number != 0)
                    {
                        if (pomzaw.Number != filzaw.Number)
                        {
                            return false;
                        }
                    }

                    if (pomzaw.Leftleg != false)
                    {
                        if (pomzaw.Leftleg != filzaw.Leftleg)
                        {
                            return false;
                        }
                    }

                    if (pomzaw.Rightleg != false)
                    {
                        if (pomzaw.Rightleg != filzaw.Rightleg)
                        {
                            return false;
                        }
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
