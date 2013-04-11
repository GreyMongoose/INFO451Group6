using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using System.Web.Configuration;


    public partial class customerDisplay : System.Web.UI.Page
    {
        dbUtils utils;
        protected void Page_Load(object sender, EventArgs e)
        {
            utils = new dbUtils();
            customerView.DataSource = utils.getCustomers();
            customerView.DataBind();
            adminView.DataSource = utils.getAdmins();
            adminView.DataBind();
        }
    }

   