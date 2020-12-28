using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ProjektWPF.Data
{
    public class Rozgrywka
    {
        public int Id { get; set; }
        public string Place { get; set; }

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
        public string Tournament { get; set; }

     public string Opis { get; set; }
     public string Sedziaglowny { get; set; }
     public string Sedziapom1 { get; set; }
     public string Sedziapom2 { get; set; }
     public string Sedziatechniczny { get; set; }


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
                return Date.ToString()+" "+Hour.ToString(); //tu druzyny
            }
        }
        public override string ToString()
        {
            return Date.ToString() + " " + Hour.ToString();  //tu druzyny
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this,
                new PropertyChangedEventArgs(property));
        }


    }
    
}
