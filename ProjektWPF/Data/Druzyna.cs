using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media.Imaging;


namespace ProjektWPF.Data
{
    public class Druzyna : IDataErrorInfo
    {
        public int Id { get; set; }
        public string name;
        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged("DaneDruzyny"); }
        }
        public string country;
        public string Country
        {
            get { return country; }
            set { country = value; OnPropertyChanged("DaneDruzyny"); }
        }
        public string city;
        public string City
        {
            get { return city; }
            set { city = value; OnPropertyChanged("DaneDruzyny"); }
        }
        public string owner;
        public string Owner
        {
            get { return owner; }
            set { owner = value; OnPropertyChanged("DaneDruzyny"); }
        }
        public string sponsors;
        public string Sponsors
        {
            get { return sponsors; }
            set { sponsors = value; OnPropertyChanged("DaneDruzyny"); }
        }
        public string succes;
        public string Succes
        {
            get { return succes; }
            set { succes = value; OnPropertyChanged("DaneDruzyny"); }
        }
        public List<Zawodnik> zawodnicy;
        public List<Zawodnik> Zawodnicy
        {
            get { return zawodnicy; }
            set { zawodnicy = value; OnPropertyChanged("DaneDruzyny"); }
        }
        
        public Druzyna() { }

        public Druzyna(string name,string country,string city,
                        string owner,string sponsors,string succes, List<Zawodnik> lista_zawodnikow)
        {
            Name = name;
            Country = country;
            City = city;
            Owner = owner;
            Sponsors = sponsors;
            Succes = succes;
            lista_zawodnikow = null;
            ImagePath = imagePath;
        }
        public BitmapImage imagePath;
        public BitmapImage ImagePath { get; set; }   

        public void AddZawodnikDoDruzyny(Zawodnik zawodnik)
        {
            zawodnicy.Add(zawodnik);
        }

        public string DaneDruzyny
        {
            get { return Name; }
        }

        public override string ToString()
        {
            return Name;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }

        public string Error
        {
            get { return null; }
        }

        public string this[string columnName]
        {
            get
            {
                if(columnName == "Name")
                {
                    if (Name == null) { return "Nazwę klubu trzeba podać"; }
                }
                if(columnName == "Country")
                {
                    if(Country == null) { return "Kraj trzeba podać"; }  
                }
                if (columnName == "City")
                {
                    if(City == null) { return "Miasto trzeba podać"; }  
                }
                if (columnName == "Owner")
                {
                    if(Owner == null) { return "Właściciela trzeba podać"; } 
                }
                return null;
            }
        }
    }
}
