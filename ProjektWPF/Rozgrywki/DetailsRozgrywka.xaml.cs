﻿using ProjektWPF.Data;
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
    /// Interaction logic for DetailsRozgrywka.xaml
    /// </summary>
    public partial class DetailsRozgrywka : Window
    {
        Rozgrywka detroz;
        public DetailsRozgrywka(Rozgrywka Rozgrywka)
        {
            InitializeComponent();
            detroz = Rozgrywka;
            DetailsGrid.DataContext = detroz;
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
