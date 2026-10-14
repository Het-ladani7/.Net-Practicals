using System;
using System.Data;
using System.Data.SqlClient;

namespace P8
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string connectionString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;
              Initial Catalog=InventoryDB;
              Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();
            }
        }

        // READ
        private void LoadData()
        {
            using (SqlConnection con =
                   new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Inventory";

                SqlDataAdapter da =
                    new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }

        // CREATE
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection con =
                   new SqlConnection(connectionString))
            {
                string query =
                    "INSERT INTO Inventory " +
                    "(ProductName, Quantity, Price) " +
                    "VALUES (@ProductName, @Quantity, @Price)";

                SqlCommand cmd =
                    new SqlCommand(query, con);

                cmd.Parameters.AddWithValue(
                    "@ProductName", txtName.Text);

                cmd.Parameters.AddWithValue(
                    "@Quantity", Convert.ToInt32(txtQuantity.Text));

                cmd.Parameters.AddWithValue(
                    "@Price", Convert.ToDecimal(txtPrice.Text));

                con.Open();

                cmd.ExecuteNonQuery();
            }

            txtName.Text = "";
            txtQuantity.Text = "";
            txtPrice.Text = "";

            LoadData();
        }
    }
}
