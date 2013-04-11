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


    public partial class accountsDisplay : System.Web.UI.Page
    {
        dbUtils utils;
        protected void Page_Load(object sender, EventArgs e)
        {
            utils = new dbUtils();
            hostingView.DataSource = utils.getHostingAccounts();
            hostingView.DataBind();
            managementView.DataSource = utils.getManagementAccounts();
            managementView.DataBind();
            storageView.DataSource = utils.getStorageAccounts();
            storageView.DataBind();
        }
    }


