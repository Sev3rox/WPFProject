using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ProjektWPF.Data
{
    public class Zawodys : IDataErrorInfo
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public int Id { get; set; }
        public string nazwa { get; set; }
        public DateTime DataStart { get; set; }
        public DateTime DataStop { get; set; }
        public string rodzaj { get; set; }
        public string Error
        {
            get { return null; }
        }
        public void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this,
                new PropertyChangedEventArgs(property));
        }
        public string this[string columnName]
        {
            get
            {
                if (columnName == "Nazwa")
                {
                    if(nazwa==null)
                     return "Nazwę trzeba podać";
                }
                if (columnName == "DataStart")
                {
                    if(DataStart==null)
                    return "Datę rozpoczęcia trzeba podać";
                }
                if (columnName == "DataStop")
                {
                    if(DataStop==null)
                    return "Datę zakończenia trzeba podać";
                }
                if (columnName == "Rodzaj")
                {if(rodzaj==null)
                    return "Rodzaj trzeba podać";
                }

                return null;
            }
        }
        public string Dane
        {
            get
            {
                return nazwa + DataStart.Year; //tu druzyny
            }
        }
        public override string ToString()
        {
            return nazwa+DataStart.Year; //tu druzyny
        }
    }
}
