using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sample_Paper
{
    public partial class ParkingRebateSystem : System.Web.UI.Page
    {
        static Receipt myreceipt;  
        static Rebates myrebate;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //getting the session variables
                myreceipt = (Receipt)Session["receipt"];
                myrebate = (Rebates)Session["rebate"];

                //Binding data to the grid view
                BindGrid();
                BindGrid2();
            }
        }

        public void BindGrid()
        {
            //Binding Receipts List to the GridView
            GridView1.DataSource = myreceipt.GetReceipts();
            GridView1.DataBind();

        }

        public void BindGrid2()
        {
            
            //getting the session variables
            myrebate = (Rebates)Session["rebate"];

            //Binding Rebates List to the GridView
            GridView2.DataSource = myrebate.GetRebates();
            GridView2.DataBind();
        }

        protected void btn_addReceipt_Click(object sender, EventArgs e)
        {
            string receipt_sn = txt_Receipt.Text;
            string shopname = txt_ShopName.Text;
            double amount = double.Parse(txt_Amount.Text);
            Receipt receipt = new Receipt(receipt_sn, shopname, amount);

            //Calling the AddReceipt Method form the receipt class
            string temp = myreceipt.AddReceipt(receipt);

            //Saving the receipt list to session variable
            Session["receipt"] = myreceipt;

            BindGrid();
        }

        protected void btn_applyRebates_Click(object sender, EventArgs e)
        {
            string vehicle = txt_vehicleNo.Text;

            //get the receipt lists from the session variable
            myreceipt = (Receipt)Session["receipt"];


            //converting to the List<Receipt> to ArrayList because the given applyRebates(string vehicle, ArrayList receipts) Method 
            //is only can access the Arrayist parameter
            ArrayList receiptlist = new ArrayList();
            foreach (var item in myreceipt.ReceiptList)
            {
                receiptlist.Add(item);
            }

            try
            {
                Rebates rebates = new Rebates();
                rebates.applyRebates(vehicle, receiptlist);
                
                //Save the Rebate List to session variable
                Session["rebate"] = rebates;
                BindGrid2();
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void txt_vehicleNo_TextChanged(object sender, EventArgs e) //when the shopper's vehicle number is entered
        {
            string vehicle = txt_vehicleNo.Text;
            double ExistingRebates = findExistingRebates(vehicle);
            txt_existing_rebates.Text = ExistingRebates.ToString();
        }


        
        public double findExistingRebates(string vehicle) //this method is using for displaying existing rebates only using for testing purpose
        {
            return 10;
        }
    }
}