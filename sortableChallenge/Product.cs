using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sortableChallenge
{
    class Product
    {
        private string name;
        private string manufacturer;
        private string model;
        private string family;
        private string announcedDate;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                this.manufacturer = value;
            }
        }
        
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }
        
        public string Family
        {
            get
            {
                return this.family;
            }
            set
            {
                this.family = value;
            }
        }

        public string AnnounceDate
        {
            get
            {
                return this.announcedDate;
            }
            set
            {
                this.announcedDate = value;
            }
        }

        public Product()
        {
        }

        public Product(string _name, string _manufacturer, string _model, string _family, string _announceDate)
        {
            this.name = _name;
            this.manufacturer = _manufacturer;
            this.model = _model;
            this.family = _family;
            this.announcedDate = _announceDate;
        }
    }
}
