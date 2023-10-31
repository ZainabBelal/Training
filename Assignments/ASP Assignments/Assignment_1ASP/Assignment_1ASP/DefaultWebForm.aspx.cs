using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Assignment_1ASP
{
    using System;

    public partial class DefaultWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               
                imageItem.ImageUrl = "Imgs/Stationery.jpg";
            }
        }

        protected void listItems_SelectedIndexChanged(object sender, EventArgs e)
        { 

            string selectedItem = listItems.SelectedValue;
            imageItem.ImageUrl = $"Imgs/{selectedItem}";

            
        }
        protected void getItemCost(object sender, EventArgs e)
        {
            string selectedItem =listItems.SelectedValue;

           
            var Costs = new Dictionary<string, decimal>
            {
                {"Notebook.jpg", 200.00m },
                {"Pen.jpg", 50.00m },
                {"Colorpencils.jpg", 100.00m },
                {"Eraser.jpg", 12.00m },
                {"Whitener.jpg",60.00m},
                //{"Stapler.webp",},
            };
            
            if (Costs.ContainsKey(selectedItem))
            {
                ItemCost.Text = $"Cost: Rs {Costs[selectedItem]}";
            }
            else
            {
                ItemCost.Text = "Sorry for the Incovinience......Item currently out of Stock.........";
            }
        }
        protected void getItemDetails(object sender, EventArgs e)
        {
            string selectedItem = listItems.SelectedValue;

             
            var Details = new Dictionary<string, string>
            {
                {"Notebook.jpg","Notebooks serve as a medium to remeber things.With these notebook you get premium quality pages and more pages in less cost!!! " },
                {"Pen.jpg","Use this pen to dot down your favourite memories!!!" },
                {"Colorpencils.jpg","Add Colours to your life and drawings using these amazing color pencils!!!" },
                {"Eraser.jpg","Make mistakes....Erase them....Correct your mistakes!!!" },
                {"Whitener.jpg","Use whitener to remove mistakes which can not be erased!!!"},
                //{"Stapler.webp",},
            };

            if (Details.ContainsKey(selectedItem))
            {
                ItemCost.Text = $"{Details[selectedItem]}";
            }
            else
            {
                ItemCost.Text = "Sorry for the Incovinience......Item currently out of Stock.........";
            }
        }




        //public void getpricebyname(string itemname)
        //{
        //    SqlConnection con = new SqlConnection("Data Source=ICS-LT-4KBDR73;" +
        //       "Initial Catalog=INFINITE_DB;Integrated Security=true");
        //    SqlDataAdapter sda = new SqlDataAdapter("getpricebyname", con);
        //    sda.SelectCommand.CommandType = CommandType.StoredProcedure;

        //    SqlParameter sqlp = new SqlParameter();
        //    sqlp.ParameterName = "@itemname";
        //    sqlp.Value = itemname;
        //    sda.SelectCommand.Parameters.Add(sqlp);
        //}

        



    }

}