using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace CrudA
{
	public partial class WebForm1 : System.Web.UI.Page

	{
		SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString);
		protected void Page_Load(object sender, EventArgs e)
		{
			bindgrid();
			bloodgroup();
			Corsename();
		}
		public void bindgrid()
		{
			con.Open();
			SqlCommand cmd = new SqlCommand("sp_Register_get", con);
			cmd.CommandType = CommandType.StoredProcedure;
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			da.Fill(dt);
			con.Close();
			grid1.DataSource = dt;
			grid1.DataBind();
		}

		public void bloodgroup()
		{
			con.Open();
			SqlCommand cmd = new SqlCommand("select * from bloodgroup", con);
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			da.Fill(dt);
			con.Close();
			rbl1.DataValueField = "bid";
			rbl1.DataTextField = "bname";
			rbl1.DataSource = dt;
			rbl1.DataBind();
		}

		public void Corsename()
		{
			con.Open();
			SqlCommand cmd = new SqlCommand("select * from Course", con);
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			da.Fill(dt);
			con.Close();
			ddl1.DataValueField = "cid";
			ddl1.DataTextField = "cname";
			ddl1.DataSource = dt;
			ddl1.DataBind();
			ddl1.Items.Insert(0,new ListItem("--Select--","0"));

		}


		protected void btnsave_Click(object sender, EventArgs e)
		{
			con.Open();
			SqlCommand cmd = new SqlCommand("sp_Register_insert", con);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("@name", txt1.Text);
			cmd.Parameters.AddWithValue("@bloodgroup", ddl1.SelectedValue);
			cmd.Parameters.AddWithValue("@course", rbl1.SelectedValue);
			cmd.ExecuteNonQuery();
			con.Close();
			bindgrid();
		}
	}
}