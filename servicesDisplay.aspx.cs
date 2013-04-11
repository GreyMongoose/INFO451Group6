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


    public partial class servicesDisplay : System.Web.UI.Page
    {
        dbUtils utils;
        protected void Page_Load(object sender, EventArgs e)
        {
            utils = new dbUtils();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            categoriesView.DataSource = utils.getCategories();
            categoriesView.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            serviceView.DataSource = utils.getServices(1);
            serviceView.DataBind();
            Label1.Text = "Hosting Services";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            serviceView.DataSource = utils.getServices(2);
            serviceView.DataBind();
            Label1.Text = "Storage Services";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            serviceView.DataSource = utils.getServices(3);
            serviceView.DataBind();
            Label1.Text = "Management Services";
        }
    }
