using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sortableChallenge
{
    class Listing
    {
        private string title;
        private string manufacturer;
        private string currency;
        private string price;
        private bool assigned;
        private double score;

        public string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                this.title = value;
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

        public string Currency
        {
            get
            {
                return this.currency;
            }
            set
            {
                this.currency = value;
            }
        }
        
        public string Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }

        public bool Assigned
        {
            get
            {
                return this.assigned;
            }
            set 
            {
                this.assigned = value;
            }
        }

        public double Score
        {
            get
            {
                return this.score;
            }
            set
            {
                this.score = value;    
            }
        }

        public Listing()
        {
        }

        public Listing(string _title, string _manufacturer, string _currency, string _price)
        {
            this.title = _title;
            this.manufacturer = _manufacturer;
            this.currency = _currency;
            this.price = _price;
        }
    }
}
