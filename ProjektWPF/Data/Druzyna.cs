using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media.Imaging;


namespace ProjektWPF.Data
{
    public class Druzyna : IDataErrorInfo
    {
        public int Id { get; set; }
        public string nazwa;
        public string Nazwa
        {
            get { return nazwa; }
            set { nazwa = value; OnPropertyChanged("DaneDruzyny"); }
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

        public Collection<Zawodnik> lista_zawodnikow { get; } = new ObservableCollection<Zawodnik>();
        
        public Druzyna() { }

        public Druzyna(string name,string country,string city,
                        string owner,string sponsors,string succes)
        {
            Nazwa = name;
            Country = country;
            City = city;
            Owner = owner;
            Sponsors = sponsors;
            Succes = succes;
            ImagePath = Nazwa;
        }
        public string ImagePath { get; set; }   

        public void AddZawodnikDoDruzyny(Zawodnik zawodnik)
        {
            lista_zawodnikow.Add(zawodnik);
        }

        public string DaneDruzyny
        {
            get { return Nazwa; }
        }

        public override string ToString()
        {
            return Nazwa;
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
                if(columnName == "Nazwa")
                {
                    if (Nazwa == null) { return "Nazwę klubu trzeba podać"; }
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
