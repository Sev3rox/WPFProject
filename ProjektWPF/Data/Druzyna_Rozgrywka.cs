using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektWPF.Data
{
    public class Druzyna_Rozgrywka
    {
        public int DruzynaId { get; set; }
        public Druzyna Druzyna { get; set; }

        public int RozgrywkaId { get; set; }
        public Rozgrywka Rozgrywka { get; set; }
    }
}
