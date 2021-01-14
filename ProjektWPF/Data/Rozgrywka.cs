using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ProjektWPF.Data
{
    public class Rozgrywka : IDataErrorInfo
    {
        public int Id { get; set; }
        public string Place { get; set; }

        public Wynik? Wynik;
        public int? WynikId { get; set; }

        private DateTime date;
        public DateTime Date
        {
            get { return date; }
            set {date = value; OnPropertyChanged("DaneRoz"); }
        }

        private int hour;
        public int Hour
        {
            get { return hour; }
            set { hour = value; OnPropertyChanged("DaneRoz"); }
        }


     public string Opis { get; set; }
     public string Sedziaglowny { get; set; }
     public string Sedziapom1 { get; set; }
     public string Sedziapom2 { get; set; }
     public string Sedziatechniczny { get; set; }

    public string Turniej { get; set; }

        //tu drużyny


        public Rozgrywka() { }

        public Rozgrywka(DateTime date)
        {
            Date = date;

        }

        public string DaneRoz
        {
            get
            {
                string pom1 =Date.Day.ToString();
                if (Date.Day < 10)
                {
                    var pom11 = "0"+pom1;
                    pom1 = pom11;
              
                }
                var pom2 = Date.Month.ToString();
                if (Date.Month < 10)
                {
                    var pom22 = "0" + pom2;
                    pom2 = pom22;

                }
                var pom3 = Date.Year.ToString();
                if (Date.Year < 10)
                {
                    var pom33 = "000" + pom3;
                    pom3 = pom33;

                }
                var pom4 = Hour.ToString();
                if (Hour < 10)
                {
                    var pom44 = "0" + pom4;
                    pom4 = pom44;

                }

                return pom1+"."+pom2+"."+pom3+" "+pom4+":00"; //tu druzyny
            }
        }
        public override string ToString()
        {
            string pom1 = Date.Day.ToString();
            if (Date.Day < 10)
            {
                var pom11 = "0" + pom1;
                pom1 = pom11;

            }
            var pom2 = Date.Month.ToString();
            if (Date.Month < 10)
            {
                var pom22 = "0" + pom2;
                pom2 = pom22;

            }
            var pom3 = Date.Year.ToString();
            if (Date.Year < 10)
            {
                var pom33 = "000" + pom3;
                pom3 = pom33;

            }
            var pom4 = Hour.ToString();
            if (Hour < 10)
            {
                var pom44 = "0" + pom4;
                pom4 = pom44;

            }

            return pom1 + "." + pom2 + "." + pom3 + " " + pom4 + ":00"; //tu druzyny
        }


        public event PropertyChangedEventHandler PropertyChanged;
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

        public string this[string columnName]
        {
            get
            {
                if (columnName == "Hour")
                {
                    if (Hour <= 0)
                        return "Godzina musi być większa od 0";
                    if (Hour >= 24)
                        return "Godzina musi być mniejsza od 24";

                }
                if (columnName == "Date")
                {
                    if (Date == null||Date< DateTime.UtcNow)
                        return "Data musi być podana";
     
                }
                if (columnName == "Sedziaglowny")
                {
                    if (Sedziaglowny == null)
                        return "Obowiązkowe";

                }
                if (columnName == "Place")
                {
                    if (Place == null)
                        return "Miejsce musi być podane";

                }
                return null;
            }
        }


    }
    
}
