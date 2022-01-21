using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ListViewApp.Models
{
    public class Faculty : INotifyPropertyChanged
    {
        private string name;
        private string specialty;
        private string rank;
        private string imageUri;
        public string Name 
        { 
            get
            {
                return name;
            } 
            
            set
            {
                if(value != name)
                {
                    name = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Name));
                }
            }
        }
        public string Specialty
        {
            get { return specialty; }
            set
            {
                if (value != specialty)
                {
                    specialty = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Specialty));
                }
            }
        }
        public string Rank
        {
            get { return rank; }
            set
            {
                if (value != rank)
                {
                    rank = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Rank));
                }
            }
        }
        public string ImageUri {
            get { return imageUri; }
            set
            {
                if (value != imageUri)
                {
                    imageUri = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(ImageUri));
                }
            }
        }

        public override string ToString()
        {
            return Name;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
