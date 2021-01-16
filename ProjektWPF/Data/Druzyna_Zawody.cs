using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektWPF.Data
{
    public class Druzyna_Zawody
    {
        public int DruzynaId { get; set; }
        public Druzyna Druzyna { get; set; }

        public int ZawodyId { get; set; }
        public Zawodys Zawody { get; set; }
    }
}
