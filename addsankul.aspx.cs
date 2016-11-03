using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using himachalsikshasamiti;

public partial class _Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection();

    himachalsikshasamiti.clssankulprp objprp = new himachalsikshasamiti.clssankulprp();
    himachalsikshasamiti.clssankul obj = new himachalsikshasamiti.clssankul();
    
    protected void Page_Load(object sender, EventArgs e)
    {
        con.ConnectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        if (con.State == ConnectionState.Closed)
        {
            con.Open();


        }
        if (!Page.IsPostBack)
        {
           auto_incriment();
           grid_bind();
        }
                
                

    }
    int i;
    private void auto_incriment()
    {

        string qry = "select count(*),Max(id) from tb_sankul";
        SqlCommand cmd = new SqlCommand(qry, con);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
           
            int a = Convert.ToInt32(dr[0].ToString());
            if (a == 0)
            {
                //i = a + 1;
                TextBox1.Text = "S001";
                dr.Close();

            }
            else
            {
                int b = Convert.ToInt32(dr[1].ToString());
                dr.Close();
                //i=a+1;
                int c = b + 1;
                string d = "S00" + c.ToString();
                TextBox1.Text = d;
            }

        
        }
    }
    private void grid_bind()
    {
        List<himachalsikshasamiti.clssankulprp> k;
       GridView1.DataSource = obj.disp_rec();
      
        GridView1.DataBind();
    
    
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        //objprp.sankul_id = i; 
        objprp.sankul_code =Convert.ToString(TextBox1.Text);
        objprp.sankul_name = TextBox2.Text;
        obj.save_rec(objprp);
        grid_bind();
        auto_incriment();
        TextBox2.Text = string.Empty;
        TextBox2.Focus();
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        grid_bind();
    }
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        grid_bind();
    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
 
       Label lb = (Label)GridView1.Rows[e.RowIndex].FindControl("lb2");
        objprp.sankul_code = Convert.ToString(lb.Text);
        obj.delete_rec(objprp);
        grid_bind();
        auto_incriment();
    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        Label lb = (Label)GridView1.Rows[e.RowIndex].FindControl("lbcode");
        TextBox txtname = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtsankul_name");
        objprp.sankul_code = Convert.ToString(lb.Text);
        objprp.sankul_name = txtname.Text;
        obj.update_rec(objprp);
      
        GridView1.EditIndex = -1;
        grid_bind();
    }
}