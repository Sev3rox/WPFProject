using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;


namespace ProjektWPF.Data
{
    public class Wynik : IDataErrorInfo
    {
        public int Id { get; set; }
        public Rozgrywka? Rozgrywka;
        public int? RozgrywkaId { get; set; }
        public string wynik1;
        public string wynik2;
        public event PropertyChangedEventHandler PropertyChanged;
        public string Rozgryweczka { get; set; }
        public void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this,
                new PropertyChangedEventArgs(property));
        }
        public string Error
        {
            get { return null; }
        }
        public string Wynik1
        {
            get { return wynik1; }
            set { wynik1 = value; OnPropertyChanged("DaneDruzyny"); }
        }
        public string Wynik2
        {
            get { return wynik2; }
            set { wynik2 = value; OnPropertyChanged("DaneDruzyny"); }
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "Wynik1")
                {
                    if (wynik1 == null) { return "Wynik1 trzeba podać"; }
                }
                if (columnName == "Wynik2")
                {
                    if (wynik2 == null) { return "Wynik2 trzeba podać"; }
                }
                return null;
            }
        }
        public override string ToString()
        {
            return Rozgryweczka+" "+ Wynik1+":"+Wynik2; //tu druzyny
        }
    }
}
