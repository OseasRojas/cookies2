using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cookies2_4700237
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            Response.Redirect
                (
                "WebForm2.aspx" +
                "?ddlCategory=" + ddlCategory.SelectedValue +
                "&ddlSupplier=" + ddlSupplier.SelectedValue +
                "&strProduct=" + strProduct.Text +
                "&strDescription=" + strDescription.Text +
                "&strImage=" + strImage.Text +
                "&decPrice=" + decPrice.Text +
                "&bytNumberInStock=" + bytNumberInStock.Text +
                "&bytNumberOnOrder=" + bytNumberOnOrder.Text +
                "&bytReorderLevel=" + bytReorderLevel.Text);
        }
    }
}