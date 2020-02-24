using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
namespace intra_models
{
    public class Customer : INotifyPropertyChanged
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public string ContactInfo { get; set; }
        public string PicturePath { get; set; }
        public string Info => LastName + ", " + Name; 

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
