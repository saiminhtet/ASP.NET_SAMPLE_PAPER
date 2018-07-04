using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sample_Paper
{
    public class Receipt
    {


        // Class Variables, Properties

        string shop;
        string receipt_sn;
        double amount;

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


        //Constructor
       

        public Receipt(string receipt_sn, string shop, double amount)
        {
            this.receipt_sn = receipt_sn;
            this.shop = shop;
            this.amount = amount;
        }

        public Receipt()  
        {
            ReceiptList = new List<Receipt>();   //this is use to store session data
        }



        // Class Variables, Properties
        public List<Receipt> ReceiptList { get; set; }

        public const string AddToReceiptNG = "Failed to add receipt, please try again.";
        public const string AddToReceipttOK = "Added info to receipt.";


       

        //Methods
        public string AddReceipt(Receipt receipt)
        {
            try
            {
                if (receipt != null)
                {
                    bool IsExists = false;
                    foreach (var i in ReceiptList)
                    {
                        if (i.receipt_sn == receipt.receipt_sn)
                        {
                            i.amount += receipt.amount; IsExists = true; break;
                        }
                    }
                    if (!IsExists) ReceiptList.Add(receipt);
                    return AddToReceipttOK;
                }
                else
                    return AddToReceiptNG;
            }
            catch(Exception e)
            {
                return AddToReceiptNG;
            }
        }



        public List<Receipt> GetReceipts()
        {
            try
            {
                if (ReceiptList.Count > 0)
                {
                    return ReceiptList;
                }
                else
                    return null;
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}