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
using ProjektWPF.Data;
namespace ProjektWPF
{
    /// <summary>
    /// Logika interakcji dla klasy Drabinka.xaml
    /// </summary>
    public partial class Drabinka : Window
    {
        ZawodnikDbContext context;
        public Drabinka(Zawodys zawody, ZawodnikDbContext context)
        {
            this.context = context;
            InitializeComponent();
            Keyboard.Focus(GridDrabinka);
            Loaded += (x, y) => Keyboard.Focus(GridDrabinka);
            if (context.Druzyna_Zawody.Count(e => e.ZawodyId == zawody.Id) != 32) 
                this.Close();
            var temp = new List<Druzyna>();
            var temp2 = context.Druzyna_Zawody.Where(e => e.ZawodyId == zawody.Id).ToList();
            foreach (Druzyna_Zawody d in temp2)
            {
                temp.Add(context.Druzyny.First(e => e.Id == d.DruzynaId));
            }
            for (int i=0;i<32;i++)
            {
                
                ((Label) GridDrabinka.FindName("TeamA" + i)).Content=temp[i].Nazwa;
                ((Image)GridDrabinka.FindName("ImageA" + i)).Source = new BitmapImage(new Uri(temp[i].ImagePath));
                OptionalRadioButton pom = new OptionalRadioButton();
                pom.Name = "RadioA" + i;
                pom.GroupName = "RadioA" + i / 2;
                pom.Checked += new RoutedEventHandler(Onb2Click);
                pom.Unchecked += new RoutedEventHandler(Onb2Click);
                //pom.Click+=new RoutedEventHandler(Onb2Click);
                RegisterName(pom.Name, pom);
                
                GridDrabinka.Children.Add(pom);
                if (i > 15)
                    Grid.SetColumn(pom, Grid.GetColumn((Image)GridDrabinka.FindName("ImageA" + i))-2);
                else
                    Grid.SetColumn(pom, Grid.GetColumn((Image)GridDrabinka.FindName("ImageA" + i))+2);
                Grid.SetRow(pom, Grid.GetRow((Image)GridDrabinka.FindName("ImageA" + i)));
            }
            for (int i = 0; i < 16; i++)
            {

                //((Label)GridDrabinka.FindName("TeamB" + i)).Content = temp[i].Nazwa;
                //((Image)GridDrabinka.FindName("ImageB" + i)).Source = new BitmapImage(new Uri(temp[i].ImagePath));
                OptionalRadioButton pom = new OptionalRadioButton();
                pom.Name = "RadioB" + i;
                pom.GroupName = "RadioB" + i / 2;
                pom.Checked += new RoutedEventHandler(Onb2Click);
                pom.Unchecked += new RoutedEventHandler(Onb2Click);
                RegisterName(pom.Name, pom);
                GridDrabinka.Children.Add(pom);
                if (i > 7)
                    Grid.SetColumn(pom, Grid.GetColumn((Image)GridDrabinka.FindName("ImageB" + i)) - 2);
                else
                    Grid.SetColumn(pom, Grid.GetColumn((Image)GridDrabinka.FindName("ImageB" + i)) + 2);
                Grid.SetRow(pom, Grid.GetRow((Image)GridDrabinka.FindName("ImageB" + i)));
            }
            for (int i = 0; i < 8; i++)
            {

               // ((Label)GridDrabinka.FindName("TeamC" + i)).Content = temp[i].Nazwa;
                //((Image)GridDrabinka.FindName("ImageC" + i)).Source = new BitmapImage(new Uri(temp[i].ImagePath));
                OptionalRadioButton pom = new OptionalRadioButton();
                pom.Name = "RadioC" + i;
                pom.GroupName = "RadioC" + i / 2;
                pom.Checked += new RoutedEventHandler(Onb2Click);
                pom.Unchecked += new RoutedEventHandler(Onb2Click);
                RegisterName(pom.Name, pom);
                GridDrabinka.Children.Add(pom);
                if (i > 3)
                    Grid.SetColumn(pom, Grid.GetColumn((Image)GridDrabinka.FindName("ImageC" + i)) - 2);
                else
                    Grid.SetColumn(pom, Grid.GetColumn((Image)GridDrabinka.FindName("ImageC" + i)) + 2);
                Grid.SetRow(pom, Grid.GetRow((Image)GridDrabinka.FindName("ImageC" + i)));
            }
            for (int i = 0; i < 4; i++)
            {

               // ((Label)GridDrabinka.FindName("TeamD" + i)).Content = temp[i].Nazwa;
                //((Image)GridDrabinka.FindName("ImageD" + i)).Source = new BitmapImage(new Uri(temp[i].ImagePath));
                OptionalRadioButton pom = new OptionalRadioButton();
                pom.Name = "RadioD" + i;
                pom.GroupName = "RadioD" + i / 2;
                pom.Checked += new RoutedEventHandler(Onb2Click);
                pom.Unchecked += new RoutedEventHandler(Onb2Click);
                RegisterName(pom.Name, pom);
                GridDrabinka.Children.Add(pom);
                if (i > 1)
                    Grid.SetColumn(pom, Grid.GetColumn((Image)GridDrabinka.FindName("ImageD" + i)) - 2);
                else
                    Grid.SetColumn(pom, Grid.GetColumn((Image)GridDrabinka.FindName("ImageD" + i)) + 2);
                Grid.SetRow(pom, Grid.GetRow((Image)GridDrabinka.FindName("ImageD" + i)));
            }
            for (int i = 0; i < 2; i++)
            {

                // ((Label)GridDrabinka.FindName("TeamD" + i)).Content = temp[i].Nazwa;
                //((Image)GridDrabinka.FindName("ImageD" + i)).Source = new BitmapImage(new Uri(temp[i].ImagePath));
                OptionalRadioButton pom = new OptionalRadioButton();
                pom.Name = "RadioE" + i;
                pom.GroupName = "RadioE" + i / 2;
                pom.Checked += new RoutedEventHandler(Onb2Click);
                pom.Unchecked += new RoutedEventHandler(Onb2Click);
                pom.HorizontalAlignment = HorizontalAlignment.Center;
                pom.VerticalAlignment = VerticalAlignment.Center;
                RegisterName(pom.Name, pom);
                GridDrabinka.Children.Add(pom);
                Grid.SetColumn(pom, Grid.GetColumn((Label)GridDrabinka.FindName("TeamE" + i)));
                Grid.SetRow(pom, Grid.GetRow((Label)GridDrabinka.FindName("TeamE" + i))-2);
            }



























            for (int i = 0; i < 16; i++)
            {
                ((Label)GridDrabinka.FindName("TeamB" + i)).Content = null;
                ((Image)GridDrabinka.FindName("ImageB" + i)).Source = null;
                if (((OptionalRadioButton)GridDrabinka.FindName("RadioA" + i * 2)).IsChecked == true)
                {
                    ((Label)GridDrabinka.FindName("TeamB" + i)).Content = ((Label)GridDrabinka.FindName("TeamA" + i * 2)).Content;
                    ((Image)GridDrabinka.FindName("ImageB" + i)).Source = ((Image)GridDrabinka.FindName("ImageA" + i * 2)).Source;
                }
                else if (((OptionalRadioButton)GridDrabinka.FindName("RadioA" + ((i * 2) + 1))).IsChecked == true)
                {
                    ((Label)GridDrabinka.FindName("TeamB" + i)).Content = ((Label)GridDrabinka.FindName("TeamA" + (i * 2 + 1))).Content;
                    ((Image)GridDrabinka.FindName("ImageB" + i)).Source = ((Image)GridDrabinka.FindName("ImageA" + (i * 2 + 1))).Source;
                }
                else
                {
                    ((Label)GridDrabinka.FindName("TeamB" + i)).Content = null;
                    ((Image)GridDrabinka.FindName("ImageB" + i)).Source = null;
                }
                if (((Label)GridDrabinka.FindName("TeamB" + ((i / 2) * 2))).Content == null || ((Label)GridDrabinka.FindName("TeamB" + (((i / 2) * 2) + 1))).Content == null)
                {
                    ((OptionalRadioButton)GridDrabinka.FindName("RadioB" + i)).IsEnabled = false;
                    ((OptionalRadioButton)GridDrabinka.FindName("RadioB" + i)).IsChecked = false;
                }
                else ((OptionalRadioButton)GridDrabinka.FindName("RadioB" + i)).IsEnabled = true;
                if (i != 0)
                {
                    if (((Label)GridDrabinka.FindName("TeamB" + (((i - 1) / 2) * 2))).Content == null || ((Label)GridDrabinka.FindName("TeamB" + ((((i - 1) / 2) * 2) + 1))).Content == null)
                    {
                        ((OptionalRadioButton)GridDrabinka.FindName("RadioB" + (i - 1))).IsEnabled = false;
                        ((OptionalRadioButton)GridDrabinka.FindName("RadioB" + (i - 1))).IsChecked = false;
                    }
                    else ((OptionalRadioButton)GridDrabinka.FindName("RadioB" + (i - 1))).IsEnabled = true;
                }
            }
            for (int i = 0; i < 8; i++)
            {
                ((Label)GridDrabinka.FindName("TeamC" + i)).Content = null;
                ((Image)GridDrabinka.FindName("ImageC" + i)).Source = null;
                if (((OptionalRadioButton)GridDrabinka.FindName("RadioB" + i * 2)).IsChecked == true)
                {
                    ((Label)GridDrabinka.FindName("TeamC" + i)).Content = ((Label)GridDrabinka.FindName("TeamB" + i * 2)).Content;
                    ((Image)GridDrabinka.FindName("ImageC" + i)).Source = ((Image)GridDrabinka.FindName("ImageB" + i * 2)).Source;
                }
                else if (((OptionalRadioButton)GridDrabinka.FindName("RadioB" + ((i * 2) + 1))).IsChecked == true)
                {
                    ((Label)GridDrabinka.FindName("TeamC" + i)).Content = ((Label)GridDrabinka.FindName("TeamB" + (i * 2 + 1))).Content;
                    ((Image)GridDrabinka.FindName("ImageC" + i)).Source = ((Image)GridDrabinka.FindName("ImageB" + (i * 2 + 1))).Source;
                }
                else
                {
                    ((Label)GridDrabinka.FindName("TeamC" + i)).Content = null;
                    ((Image)GridDrabinka.FindName("ImageC" + i)).Source = null;
                }
                if (((Label)GridDrabinka.FindName("TeamC" + ((i / 2) * 2))).Content == null || ((Label)GridDrabinka.FindName("TeamC" + (((i / 2) * 2) + 1))).Content == null)
                {
                    ((OptionalRadioButton)GridDrabinka.FindName("RadioC" + i)).IsEnabled = false;
                }
                else
                    ((OptionalRadioButton)GridDrabinka.FindName("RadioC" + i)).IsEnabled = true;
                if (i != 0)
                {
                    if (((Label)GridDrabinka.FindName("TeamC" + (((i - 1) / 2) * 2))).Content == null || ((Label)GridDrabinka.FindName("TeamC" + ((((i - 1) / 2) * 2) + 1))).Content == null)
                    {
                        ((OptionalRadioButton)GridDrabinka.FindName("RadioC" + (i - 1))).IsEnabled = false;
                        ((OptionalRadioButton)GridDrabinka.FindName("RadioC" + (i - 1))).IsChecked = false;
                    }
                    else
                        ((OptionalRadioButton)GridDrabinka.FindName("RadioC" + (i - 1))).IsEnabled = true;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                ((Label)GridDrabinka.FindName("TeamD" + i)).Content = null;
                ((Image)GridDrabinka.FindName("ImageD" + i)).Source = null;
                if (((OptionalRadioButton)GridDrabinka.FindName("RadioC" + i * 2)).IsChecked == true)
                {
                    ((Label)GridDrabinka.FindName("TeamD" + i)).Content = ((Label)GridDrabinka.FindName("TeamC" + i * 2)).Content;
                    ((Image)GridDrabinka.FindName("ImageD" + i)).Source = ((Image)GridDrabinka.FindName("ImageC" + i * 2)).Source;
                }
                else if (((OptionalRadioButton)GridDrabinka.FindName("RadioC" + ((i * 2) + 1))).IsChecked == true)
                {
                    ((Label)GridDrabinka.FindName("TeamD" + i)).Content = ((Label)GridDrabinka.FindName("TeamC" + (i * 2 + 1))).Content;
                    ((Image)GridDrabinka.FindName("ImageD" + i)).Source = ((Image)GridDrabinka.FindName("ImageC" + (i * 2 + 1))).Source;
                }
                else
                {
                    ((Label)GridDrabinka.FindName("TeamD" + i)).Content = null;
                    ((Image)GridDrabinka.FindName("ImageD" + i)).Source = null;
                }
                if (((Label)GridDrabinka.FindName("TeamD" + ((i / 2) * 2))).Content == null || ((Label)GridDrabinka.FindName("TeamD" + (((i / 2) * 2) + 1))).Content == null)
                {
                    ((OptionalRadioButton)GridDrabinka.FindName("RadioD" + i)).IsEnabled = false;
                    ((OptionalRadioButton)GridDrabinka.FindName("RadioD" + i)).IsChecked = false;
                }
                else ((OptionalRadioButton)GridDrabinka.FindName("RadioD" + i)).IsEnabled = true;
                if (i != 0)
                {
                    if (((Label)GridDrabinka.FindName("TeamD" + (((i - 1) / 2) * 2))).Content == null || ((Label)GridDrabinka.FindName("TeamD" + ((((i - 1) / 2) * 2) + 1))).Content == null)
                    {
                        ((OptionalRadioButton)GridDrabinka.FindName("RadioD" + (i - 1))).IsEnabled = false;
                        ((OptionalRadioButton)GridDrabinka.FindName("RadioD" + (i - 1))).IsChecked = false;
                    }
                    else ((OptionalRadioButton)GridDrabinka.FindName("RadioD" + (i - 1))).IsEnabled = true;
                }
            }
            for (int i = 0; i < 2; i++)
            {
                ((Label)GridDrabinka.FindName("TeamE" + i)).Content = null;
                ((Image)GridDrabinka.FindName("ImageE" + i)).Source = null;
                if (((OptionalRadioButton)GridDrabinka.FindName("RadioD" + i * 2)).IsChecked == true)
                {
                    ((Label)GridDrabinka.FindName("TeamE" + i)).Content = ((Label)GridDrabinka.FindName("TeamD" + i * 2)).Content;
                    ((Image)GridDrabinka.FindName("ImageE" + i)).Source = ((Image)GridDrabinka.FindName("ImageD" + i * 2)).Source;
                }
                else if (((OptionalRadioButton)GridDrabinka.FindName("RadioD" + ((i * 2) + 1))).IsChecked == true)
                {
                    ((Label)GridDrabinka.FindName("TeamE" + i)).Content = ((Label)GridDrabinka.FindName("TeamD" + (i * 2 + 1))).Content;
                    ((Image)GridDrabinka.FindName("ImageE" + i)).Source = ((Image)GridDrabinka.FindName("ImageD" + (i * 2 + 1))).Source;
                }
                else
                {
                    ((Label)GridDrabinka.FindName("TeamE" + i)).Content = null;
                    ((Image)GridDrabinka.FindName("ImageE" + i)).Source = null;
                }
                if (((Label)GridDrabinka.FindName("TeamE" + ((i / 2) * 2))).Content == null || ((Label)GridDrabinka.FindName("TeamE" + (((i / 2) * 2) + 1))).Content == null)
                {
                    ((OptionalRadioButton)GridDrabinka.FindName("RadioE" + i)).IsEnabled = false;
                    ((OptionalRadioButton)GridDrabinka.FindName("RadioE" + i)).IsChecked = false;
                    ((Image)GridDrabinka.FindName("Winner")).Source = null;
                }
                else ((OptionalRadioButton)GridDrabinka.FindName("RadioE" + i)).IsEnabled = true;
                if (i != 0)
                {
                    if (((Label)GridDrabinka.FindName("TeamE" + (((i - 1) / 2) * 2))).Content == null || ((Label)GridDrabinka.FindName("TeamE" + ((((i - 1) / 2) * 2) + 1))).Content == null)
                    {
                        ((OptionalRadioButton)GridDrabinka.FindName("RadioE" + (i - 1))).IsEnabled = false;
                        ((OptionalRadioButton)GridDrabinka.FindName("RadioE" + (i - 1))).IsChecked = false;
                        ((Image)GridDrabinka.FindName("Winner")).Source = null;
                    }
                    else ((OptionalRadioButton)GridDrabinka.FindName("RadioE" + (i - 1))).IsEnabled = true;
                }
            }

            if (((OptionalRadioButton)GridDrabinka.FindName("RadioE0")).IsChecked == true)
            {
                ((Image)GridDrabinka.FindName("Winner")).Source = ((Image)GridDrabinka.FindName("ImageE0")).Source;
            }
            if (((OptionalRadioButton)GridDrabinka.FindName("RadioE1")).IsChecked == true)
            {
                ((Image)GridDrabinka.FindName("Winner")).Source = ((Image)GridDrabinka.FindName("ImageE1")).Source;
            }

        }
        void Onb2Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 16; i++)
            {
                ((Label)GridDrabinka.FindName("TeamB" + i)).Content = null;
                ((Image)GridDrabinka.FindName("ImageB" + i)).Source = null;
                if (((OptionalRadioButton)GridDrabinka.FindName("RadioA" + i * 2)).IsChecked == true)
                {
                    ((Label)GridDrabinka.FindName("TeamB" + i)).Content = ((Label)GridDrabinka.FindName("TeamA" + i * 2)).Content;
                    ((Image)GridDrabinka.FindName("ImageB" + i)).Source = ((Image)GridDrabinka.FindName("ImageA" + i * 2)).Source;
                }
                else if (((OptionalRadioButton)GridDrabinka.FindName("RadioA" + ((i * 2)+1))).IsChecked == true)
                {
                    ((Label)GridDrabinka.FindName("TeamB" + i)).Content = ((Label)GridDrabinka.FindName("TeamA" + (i * 2 + 1))).Content;
                    ((Image)GridDrabinka.FindName("ImageB" + i)).Source = ((Image)GridDrabinka.FindName("ImageA" + (i * 2 + 1))).Source;
                }
                else
                {
                    ((Label)GridDrabinka.FindName("TeamB" + i)).Content = null;
                    ((Image)GridDrabinka.FindName("ImageB" + i)).Source = null;
                }
                if(((Label)GridDrabinka.FindName("TeamB" + ((i/2)*2))).Content == null|| ((Label)GridDrabinka.FindName("TeamB" + (((i / 2) * 2)+1))).Content == null)
                {
                    ((OptionalRadioButton)GridDrabinka.FindName("RadioB" + i)).IsEnabled = false;
                    ((OptionalRadioButton)GridDrabinka.FindName("RadioB" + i)).IsChecked = false;
                }
                else ((OptionalRadioButton)GridDrabinka.FindName("RadioB" + i)).IsEnabled = true;
                if (i != 0)
                {
                    if (((Label)GridDrabinka.FindName("TeamB" + (((i - 1) / 2) * 2))).Content == null || ((Label)GridDrabinka.FindName("TeamB" + ((((i - 1) / 2) * 2) + 1))).Content == null)
                    {
                        ((OptionalRadioButton)GridDrabinka.FindName("RadioB" + (i - 1))).IsEnabled = false;
                        ((OptionalRadioButton)GridDrabinka.FindName("RadioB" + (i - 1))).IsChecked = false;
                    }
                    else ((OptionalRadioButton)GridDrabinka.FindName("RadioB" + (i - 1))).IsEnabled = true;
                }
            }
            for (int i = 0; i < 8; i++)
            {
                ((Label)GridDrabinka.FindName("TeamC" + i)).Content = null;
                ((Image)GridDrabinka.FindName("ImageC" + i)).Source = null;
                if (((OptionalRadioButton)GridDrabinka.FindName("RadioB" + i * 2)).IsChecked == true)
                {
                    ((Label)GridDrabinka.FindName("TeamC" + i)).Content = ((Label)GridDrabinka.FindName("TeamB" + i * 2)).Content;
                    ((Image)GridDrabinka.FindName("ImageC" + i)).Source = ((Image)GridDrabinka.FindName("ImageB" + i * 2)).Source;
                }
                else if (((OptionalRadioButton)GridDrabinka.FindName("RadioB" + ((i * 2)+1))).IsChecked == true)
                {
                    ((Label)GridDrabinka.FindName("TeamC" + i)).Content = ((Label)GridDrabinka.FindName("TeamB" + (i * 2 + 1))).Content;
                    ((Image)GridDrabinka.FindName("ImageC" + i)).Source = ((Image)GridDrabinka.FindName("ImageB" + (i * 2 + 1))).Source;
                }
                else
                {
                    ((Label)GridDrabinka.FindName("TeamC" + i)).Content = null;
                    ((Image)GridDrabinka.FindName("ImageC" + i)).Source = null; 
                }
                if (((Label)GridDrabinka.FindName("TeamC" + ((i / 2) * 2))).Content == null || ((Label)GridDrabinka.FindName("TeamC" + (((i / 2) * 2) + 1))).Content == null)
                {
                    ((OptionalRadioButton)GridDrabinka.FindName("RadioC" + i)).IsEnabled = false;
                }
                else
                    ((OptionalRadioButton)GridDrabinka.FindName("RadioC" + i)).IsEnabled = true;
                    if (i != 0)
                    {
                        if (((Label)GridDrabinka.FindName("TeamC" + (((i - 1) / 2) * 2))).Content == null || ((Label)GridDrabinka.FindName("TeamC" + ((((i - 1) / 2) * 2) + 1))).Content == null)
                        {
                            ((OptionalRadioButton)GridDrabinka.FindName("RadioC" + (i - 1))).IsEnabled = false;
                        ((OptionalRadioButton)GridDrabinka.FindName("RadioC" + (i - 1))).IsChecked = false;
                    }
                        else
                            ((OptionalRadioButton)GridDrabinka.FindName("RadioC" + (i - 1))).IsEnabled = true;
                    }
            }
            for (int i = 0; i < 4; i++)
            {
                ((Label)GridDrabinka.FindName("TeamD" + i)).Content = null;
                ((Image)GridDrabinka.FindName("ImageD" + i)).Source = null;
                if (((OptionalRadioButton)GridDrabinka.FindName("RadioC" + i * 2)).IsChecked == true)
                {
                    ((Label)GridDrabinka.FindName("TeamD" + i)).Content = ((Label)GridDrabinka.FindName("TeamC" + i * 2)).Content;
                    ((Image)GridDrabinka.FindName("ImageD" + i)).Source = ((Image)GridDrabinka.FindName("ImageC" + i * 2)).Source;
                }
                else if (((OptionalRadioButton)GridDrabinka.FindName("RadioC" + ((i * 2) + 1))).IsChecked == true)
                {
                    ((Label)GridDrabinka.FindName("TeamD" + i)).Content = ((Label)GridDrabinka.FindName("TeamC" + (i * 2 + 1))).Content;
                    ((Image)GridDrabinka.FindName("ImageD" + i)).Source = ((Image)GridDrabinka.FindName("ImageC" + (i * 2 + 1))).Source;
                }
                else
                {
                    ((Label)GridDrabinka.FindName("TeamD" + i)).Content = null;
                    ((Image)GridDrabinka.FindName("ImageD" + i)).Source = null;
                }
                if (((Label)GridDrabinka.FindName("TeamD" + ((i / 2) * 2))).Content == null || ((Label)GridDrabinka.FindName("TeamD" + (((i / 2) * 2) + 1))).Content == null)
                {
                    ((OptionalRadioButton)GridDrabinka.FindName("RadioD" + i)).IsEnabled = false;
                    ((OptionalRadioButton)GridDrabinka.FindName("RadioD" + i)).IsChecked = false;
                }
                else ((OptionalRadioButton)GridDrabinka.FindName("RadioD" + i)).IsEnabled = true;
                if (i != 0)
                {
                    if (((Label)GridDrabinka.FindName("TeamD" + (((i - 1) / 2) * 2))).Content == null || ((Label)GridDrabinka.FindName("TeamD" + ((((i - 1) / 2) * 2) + 1))).Content == null)
                    {
                        ((OptionalRadioButton)GridDrabinka.FindName("RadioD" + (i - 1))).IsEnabled = false;
                        ((OptionalRadioButton)GridDrabinka.FindName("RadioD" + (i - 1))).IsChecked = false;
                    }
                    else ((OptionalRadioButton)GridDrabinka.FindName("RadioD" + (i - 1))).IsEnabled = true;
                }
            }
            for (int i = 0; i < 2; i++)
            {
                ((Label)GridDrabinka.FindName("TeamE" + i)).Content = null;
                ((Image)GridDrabinka.FindName("ImageE" + i)).Source = null;
                if (((OptionalRadioButton)GridDrabinka.FindName("RadioD" + i * 2)).IsChecked == true)
                {
                    ((Label)GridDrabinka.FindName("TeamE" + i)).Content = ((Label)GridDrabinka.FindName("TeamD" + i * 2)).Content;
                    ((Image)GridDrabinka.FindName("ImageE" + i)).Source = ((Image)GridDrabinka.FindName("ImageD" + i * 2)).Source;
                }
                else if (((OptionalRadioButton)GridDrabinka.FindName("RadioD" + ((i * 2) + 1))).IsChecked == true)
                {
                    ((Label)GridDrabinka.FindName("TeamE" + i)).Content = ((Label)GridDrabinka.FindName("TeamD" + (i * 2 + 1))).Content;
                    ((Image)GridDrabinka.FindName("ImageE" + i)).Source = ((Image)GridDrabinka.FindName("ImageD" + (i * 2 + 1))).Source;
                }
                else 
                {
                    ((Label)GridDrabinka.FindName("TeamE" + i)).Content = null;
                    ((Image)GridDrabinka.FindName("ImageE" + i)).Source = null;
                }
                if (((Label)GridDrabinka.FindName("TeamE" + ((i / 2) * 2))).Content == null || ((Label)GridDrabinka.FindName("TeamE" + (((i / 2) * 2) + 1))).Content == null)
                {
                    ((OptionalRadioButton)GridDrabinka.FindName("RadioE" + i)).IsEnabled = false;
                    ((OptionalRadioButton)GridDrabinka.FindName("RadioE" + i)).IsChecked = false;
                    ((Image)GridDrabinka.FindName("Winner")).Source = null;
                }
                else ((OptionalRadioButton)GridDrabinka.FindName("RadioE" + i)).IsEnabled = true;
                if (i != 0)
                {
                    if (((Label)GridDrabinka.FindName("TeamE" + (((i - 1) / 2) * 2))).Content == null || ((Label)GridDrabinka.FindName("TeamE" + ((((i - 1) / 2) * 2) + 1))).Content == null)
                    {
                        ((OptionalRadioButton)GridDrabinka.FindName("RadioE" + (i - 1))).IsEnabled = false;
                        ((OptionalRadioButton)GridDrabinka.FindName("RadioE" + (i - 1))).IsChecked = false;
                        ((Image)GridDrabinka.FindName("Winner")).Source = null;
                    }
                    else ((OptionalRadioButton)GridDrabinka.FindName("RadioE" + (i - 1))).IsEnabled = true;
                }
            }

            if(((OptionalRadioButton)GridDrabinka.FindName("RadioE0")).IsChecked == true)
            {
                ((Image)GridDrabinka.FindName("Winner")).Source = ((Image)GridDrabinka.FindName("ImageE0")).Source;
            }
            if (((OptionalRadioButton)GridDrabinka.FindName("RadioE1")).IsChecked == true)
            {
                ((Image)GridDrabinka.FindName("Winner")).Source = ((Image)GridDrabinka.FindName("ImageE1")).Source;
            }
        }
        public void Print(object sender,KeyEventArgs e)
        {
            if(e.Key==Key.Space)
            {
                System.Windows.Controls.PrintDialog Printdlg = new System.Windows.Controls.PrintDialog();
                if ((bool)Printdlg.ShowDialog().GetValueOrDefault())
                {
                    Size pageSize = new Size(Printdlg.PrintableAreaWidth, Printdlg.PrintableAreaHeight);
                    GridDrabinka.Measure(pageSize);
                    GridDrabinka.Arrange(new Rect(5, 5, pageSize.Width, pageSize.Height));
                    Printdlg.PrintVisual(GridDrabinka, Title);
                }
            }

            if (e.Key == Key.Escape)
            {
                this.Close();
            }

        }
    }
}
