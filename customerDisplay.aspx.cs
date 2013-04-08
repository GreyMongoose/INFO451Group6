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
        public class dbUtils
        {
            private readonly String _conString;
            private SqlConnection con;
            SqlCommand cmd = new SqlCommand();

            public dbUtils()
            {
                _conString = WebConfigurationManager.ConnectionStrings["eBizDatabase"].ConnectionString;
                con = new SqlConnection(_conString);
            }

            public DataSet getCategories()
            {
                SqlDataAdapter adpt;
                adpt = new SqlDataAdapter("SELECT * FROM ServiceCategories", _conString);
                DataSet categories = new DataSet();
                using (adpt)
                {
                    adpt.Fill(categories);
                }
                return categories;
            }

            public DataSet getServices(int foreignID) //hosting=1, storage=2, management=3
            {
                SqlDataAdapter adpt;
                adpt = new SqlDataAdapter("SELECT * FROM Services WHERE service_category = 1", _conString);
                if (foreignID == 2)
                    adpt = new SqlDataAdapter("SELECT * FROM Services WHERE service_category = 2", _conString);
                else if (foreignID == 3)
                    adpt = new SqlDataAdapter("SELECT * FROM Services WHERE service_category = 3", _conString);
                DataSet categories = new DataSet();
                using (adpt)
                {
                    adpt.Fill(categories);
                }
                return categories;
            }

            public DataSet getCustomers()
            {
                SqlDataAdapter adpt;
                adpt = new SqlDataAdapter("SELECT * FROM Customers", _conString);
                DataSet categories = new DataSet();
                using (adpt)
                {
                    adpt.Fill(categories);
                }
                return categories;
            }

            public DataSet getAdmins()
            {
                SqlDataAdapter adpt;
                adpt = new SqlDataAdapter("SELECT * FROM Admins", _conString);
                DataSet categories = new DataSet();
                using (adpt)
                {
                    adpt.Fill(categories);
                }
                return categories;
            }

            public DataSet getHostingAccounts()
            {
                SqlDataAdapter adpt;
                adpt = new SqlDataAdapter("SELECT * FROM HostingAccounts", _conString);
                DataSet categories = new DataSet();
                using (adpt)
                {
                    adpt.Fill(categories);
                }
                return categories;
            }

            public DataSet getStorageAccounts()
            {
                SqlDataAdapter adpt;
                adpt = new SqlDataAdapter("SELECT * FROM StorageAccounts", _conString);
                DataSet categories = new DataSet();
                using (adpt)
                {
                    adpt.Fill(categories);
                }
                return categories;
            }

            public DataSet getManagementAccounts()
            {
                SqlDataAdapter adpt;
                adpt = new SqlDataAdapter("SELECT * FROM ManagementAccounts", _conString);
                DataSet categories = new DataSet();
                using (adpt)
                {
                    adpt.Fill(categories);
                }
                return categories;
            }
        }
    }

   