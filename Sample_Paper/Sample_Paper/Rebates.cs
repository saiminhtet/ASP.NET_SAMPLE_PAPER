using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sample_Paper
{
    public class Rebates
    {
        // Class Variables, Properties

        string vehicle;    
        string shop;
        string receipt_sn;
        double amount;

       public string Vehicle
        {
            get { return vehicle; }
        }
        public string Shop
        {
            get { return shop; }
        }

        public string Receipt_Sn
        {
            get { return receipt_sn; }
        }

        public double Amount
        {
            get { return amount; }
        }

        public Rebates(string vehicle, string receipt_sn, string shop, double amount)
        {
            this.vehicle = vehicle;
            this.receipt_sn = receipt_sn;
            this.shop = shop;
            this.amount = amount;
        }

        public Rebates(string vehicle, Rebates rebates)
        {

        }

        public List<Rebates> RebatesList { get; set; }

       public Rebates(string vehicle, ArrayList receiptlist)
        {
            this.vehicle = vehicle;
            
        }

        public Rebates()
        {
            RebatesList = new List<Rebates>();
        }

   


        public const string AddToRebatesNG = "Failed to add Rebates, please try again.";
        public const string AddToRebatesOK = "Added info to Rebates.";

        public void applyRebates(string vehicle, ArrayList receiptlist)
        {

            try
            {               
               
                if (vehicle != null)
                {
                    bool IsExists = false;
                    foreach (Receipt item in receiptlist)
                    {
                       // item.Receipt_Sn;
                    }
                    if (!IsExists)
                    {
                        Rebates rebates = new Rebates();
                        foreach (Receipt item in receiptlist)
                        {
                            rebates.vehicle = vehicle;
                            rebates.receipt_sn = item.Receipt_Sn;
                            rebates.shop = item.Shop;
                            rebates.amount = item.Amount;
                            RebatesList.Add(rebates);
                        }
                       // Session["rebate"] = new Rebates();
                    }
                       

                }
            }
            catch (Exception e)
            {

                
            }
        }

        public List<Rebates> GetRebates()
        {
            try
            {
                if (RebatesList.Count != 0)
                {
                    return RebatesList;
                }
                else
                    return null;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }


}