<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128535261/13.2.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E5090)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
<!-- default file list end -->
# ASPxGridView - How to sae a focused row index to cookies on the server side
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e5090/)**
<!-- run online end -->


<p>The ASPxGridView does not save a focused row in cookies. However, you can add this capability by saving and restoring a focused row index to/from the cookies manually. If the ProcessFocusedRowChangedOnServer property is "true", changing of the focused row is processed on the server side. Thus, it is necessary to save and restore the focused index on the server side:</p>

```cs
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
```

<p> </p><p><strong>See</strong><strong> </strong><strong>Also:</strong><strong><br />
</strong><a href="https://www.devexpress.com/Support/Center/p/E5089">ASPxGridView - How to store a focused row index in cookies</a></p>

<br/>


