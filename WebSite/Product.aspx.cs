using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using BE;

public partial class Product : System.Web.UI.Page
{
    public string GraphValue { get; set; }

    protected void Page_Load(object sender, EventArgs e)
    {   
        CalcPriceGraphValues();
    }

    protected void CalcPriceGraphValues()
    {
        GraphValue = "2017";
        //GraphValue[1] = @"01/2017','02/2017','03/2017','04/2017','05/2017','06/2017','07/2017','08/2017','09/2017','10/2017','11/2017','12/2017'";
        //GraphValue[2] = "5.34, 5.15, 5.05, 5.38, 5.34, 5.15, 6.05, 5.38, 5.34, 5.15, 5.05, 5.38";
    }
}