using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ProjektWPF.Data
{
    public class Zawodnik
    {
        public int Id { get; set; }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged("Dane"); }
        }
        private string surname;

        public string Surname
        {
            get { return surname; }
            set { surname = value; OnPropertyChanged("Dane"); }
        }

        private int number;

        public int Number
        {
            get { return number; }
            set { number = value; OnPropertyChanged("Dane"); }
        }
        public int Age { get; set; }
            public string Adres { get; set; }
            public string Position { get; set; }
            public bool Leftleg { get; set; }
            public bool Rightleg { get; set; }

        public int Spotkania { get; set; }
        public int Gole { get; set; }
        public int Asysty { get; set; }
        public int Redcard { get; set; }
        public int Yellowcard { get; set; }
        public int Minuty { get; set; }
        public int Strzaly { get; set; }
        public int Nabramke { get; set; }

        // połączenie z drużyną



        public Zawodnik() { }

        public Zawodnik(string name, string surname)
        {
            Name = name;
            Surname = surname;

        }

        public string Dane
        {
            get
            {
                return Name + " " + Surname + " " + Number ;
            }
        }
        public override string ToString()
        {
            return Name + " " + Surname + " " + Number ;
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
