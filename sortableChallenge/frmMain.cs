using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace sortableChallenge
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOpenProductFile_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            txtProductFile.Text = openFileDialog.FileName;
        }

        private void btnOpenListingFile_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            txtListingFile.Text = openFileDialog.FileName;
        }

        private void btnMatch_Click(object sender, EventArgs e)
        {
            //step 1: read products into products collection - done
            //step 2: read listings into listings collection - done
            //step 3: match products to listings by creating the match collection object - done
            //step 4: report objects in the match collection
            
            if ((txtProductFile.Text != string.Empty) &&
                (txtListingFile.Text != string.Empty))
            {
                List<Product> products = readProducts();
                List<Listing> listings = readListings();
                List<Match> matches = matchProducts_with_Listings(products, listings);
                reportMatches(matches, Application.StartupPath + "\\matchCollection" + Convert.ToDouble(nudMinSimScore.Value) + ".txt");
                MessageBox.Show("Macthing between products and listings is completed.");
            }
            else
            {
                MessageBox.Show("Please select product and listing files.");
            }
        }

        private List<Product> readProducts()
        {
            List<Product> products = new List<Product>();
            StreamReader sr_products = new StreamReader(txtProductFile.Text);
            
            string product_line = sr_products.ReadLine();
            while (product_line != null)
            {
                Product product = new Product();
                product.Name = getElement(product_line, "product_name");
                product.Manufacturer = getElement(product_line, "manufacturer");
                product.Model = getElement(product_line, "model");
                product.Family = getElement(product_line, "family");
                product.AnnounceDate = getElement(product_line, "announce-date");
                
                products.Add(product);
                product_line = sr_products.ReadLine();
            }

            sr_products.Close();
            return products;
        }

        private List<Listing> readListings()
        {
            List<Listing> listings = new List<Listing>();
            StreamReader sr_listings = new StreamReader(txtListingFile.Text);

            string listing_line = sr_listings.ReadLine();
            while (listing_line != null)
            {
                Listing listing = new Listing();
                listing.Title = getElement(listing_line, "title");
                listing.Manufacturer = getElement(listing_line, "manufacturer");
                listing.Currency = getElement(listing_line, "currency");
                listing.Price = getElement(listing_line, "price");
                
                listings.Add(listing);
                listing_line = sr_listings.ReadLine();
            }
            
            sr_listings.Close();
            return listings;
        }

        private string getElement(string line, string elementName)
        {
            string element = "";
            string elementName_ = "\"" + elementName.ToLower() + "\"";
            if (line.ToLower().IndexOf(elementName_) > -1)
            {
                int start = line.IndexOf(elementName_) + elementName_.Length + 2;
                int length1 = line.IndexOf("\"", line.IndexOf(elementName_) + elementName_.Length + 3);
                element = line.Substring(start, length1 - start);
            }
            else
                element = null;
            return element;
        }

        private List<Match> matchProducts_with_Listings(List<Product> products, List<Listing> listings)
        {
            rtbConsole.Clear();
            List<Match> matches = new List<Match>();
            int i = 1;
            int f = 1000;
            foreach (Product product in products)
            {
                if (f-- > 0)
                {
                    Match match = new Match();
                    match.ProductName = product.Name;

                    foreach (Listing listing in listings)
                    {
                        if (!listing.Assigned)
                        {
                            if (Preprocessor.pre_process(product.Manufacturer) == Preprocessor.pre_process(listing.Manufacturer))
                            {
                                if (isModelInTitle(product.Model, listing.Title))
                                {
                                    double nlcs_score = LCS.normalized_lcs(Preprocessor.pre_process(product.Name),
                                                       Preprocessor.pre_process(listing.Title));
                                    listing.Score = nlcs_score;
                                    if (nlcs_score >= Convert.ToDouble(nudMinSimScore.Value))// can be found using machine learning techniques
                                    {
                                        match.Listings.Add(listing);
                                        listing.Assigned = true;
                                    }
                                }
                            }
                        }
                    }

                    matches.Add(match);
                    rtbConsole.AppendText("product " + i++.ToString() + " of " + products.Count + "\n");
                    rtbConsole.Focus();
                    Application.DoEvents();
                }
            }
            return matches;
        }

        private bool isModelInTitle(string productModel, string listingTitle)
        {
            bool res = true;
            productModel = Preprocessor.pre_process(productModel);
            listingTitle = Preprocessor.pre_process(listingTitle);

            ArrayList productModelParts = LCS.convert(productModel);
            for (int i = 0; i < productModelParts.Count; i++)
            {
                if (listingTitle.IndexOf(Convert.ToString(productModelParts[i])) == -1)
                {
                    res = false;
                    break;
                }
            }
            return res;
        }

        private void reportMatches(List<Match> matches, string file)
        {
            StreamWriter sw = new StreamWriter(file);
            sw.WriteLine("[");
            int ind = 0;
            foreach (Match match in matches)
            {
                sw.WriteLine("{");
                sw.Write("\"product_name\"" + ": \"" + match.ProductName + "\"");

                if (match.Listings.Count > 0)
                {
                    sw.WriteLine(",");
                    sw.WriteLine("\"listings\": [");
                    int x = 0;
                    foreach (Listing listing in match.Listings)
                    {
                        sw.Write("{\"title\": \"" + listing.Title + "\"");
                        sw.Write(",");
                        sw.Write("\"manufacturer\": \"" + listing.Manufacturer + "\"");
                        sw.Write(",");
                        sw.Write("\"currency\": \"" + listing.Currency + "\"");
                        sw.Write(",");
                        sw.Write("\"price\": \"" + listing.Price + "\"");
                        if (x++ < match.Listings.Count - 1)
                        {
                            sw.WriteLine("},");
                        }
                        else
                        {
                            sw.WriteLine("}]");
                        }
                    }
                }
                else
                {
                    sw.WriteLine("");
                }
                if (ind++ < matches.Count-1)
                    sw.WriteLine("},");
                else
                    sw.WriteLine("}]");
            }

            sw.Flush();
            sw.Close();
        }
    }
}
