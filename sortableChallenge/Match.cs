using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sortableChallenge
{
    class Match
    {
        private string productName;
        private List<Listing> listings;

        public string ProductName
        {
            get
            {
                return this.productName;
            }
            set
            {
                this.productName = value;
            }
        }

        public List<Listing> Listings
        {
            get
            {
                return this.listings;
            }
            set
            {
                if (this.listings != null)
                {
                    this.listings.Clear();
                    this.listings.AddRange(value);
                }
                else
                {
                    this.listings = new List<Listing>();
                    this.listings.AddRange(value);
                }
            }
        }

        public Match()
        {
            this.Listings = new List<Listing>();
        }
    }
}
