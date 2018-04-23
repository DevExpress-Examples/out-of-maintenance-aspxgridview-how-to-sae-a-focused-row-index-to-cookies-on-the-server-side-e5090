using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web.ASPxGridView;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void gridView_FocusedRowChanged(object sender, EventArgs e) {
        ASPxGridView grid = sender as ASPxGridView;
        Response.Cookies[grid.ID]["FocudedIndex"] = grid.FocusedRowIndex.ToString();
        Response.Cookies[grid.ID].Expires = DateTime.Now.AddDays(1d);
    }
    protected void gridView_DataBound(object sender, EventArgs e) {
        ASPxGridView grid = sender as ASPxGridView;
        if(!IsPostBack)
        if (Request.Cookies[grid.ID] != null)
            grid.FocusedRowIndex =Convert.ToInt32(Request.Cookies[grid.ID]["FocudedIndex"]);
    }
}