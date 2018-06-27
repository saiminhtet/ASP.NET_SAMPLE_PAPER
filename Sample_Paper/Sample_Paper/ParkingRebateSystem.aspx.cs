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
                myreceipt = (Receipt)Session["receipt"];
                myrebate = (Rebates)Session["rebate"];
                BindGrid();
            }
        }

        public void BindGrid()
        {
            GridView1.DataSource = myreceipt.GetReceipts();
            GridView1.DataBind();
            
        }

        public void BindGrid2()
        {
            myrebate = (Rebates)Session["rebate"];
            GridView2.DataSource = myrebate.GetRebates();
            GridView2.DataBind();
        }

        protected void btn_addReceipt_Click(object sender, EventArgs e)
        {
            string receipt_sn = txt_Receipt.Text;
            string shopname = txt_ShopName.Text;
            double amount = double.Parse(txt_Amount.Text);
            Receipt receipt = new Receipt(receipt_sn, shopname, amount);
            string temp = myreceipt.AddReceipt(receipt);
            Session["receipt"] = myreceipt;
            BindGrid();
        }

        protected void btn_applyRebates_Click(object sender, EventArgs e)
        {
            string vehicle = txt_vehicleNo.Text;
              myreceipt = (Receipt)Session["receipt"];


            ArrayList receiptlist = new ArrayList();
         
            foreach (var item in myreceipt.ReceiptList)
            {
                receiptlist.Add(item);
            }

            try
            {
               Rebates rebates = new Rebates();
               rebates.applyRebates(vehicle, receiptlist);
                Session["rebate"] = rebates;
                BindGrid2();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}