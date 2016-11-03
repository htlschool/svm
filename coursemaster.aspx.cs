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
    himachalsikshasamiti.courseprp objprp = new courseprp();
    himachalsikshasamiti.clscourse obj = new clscourse();
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
    private void auto_incriment()
    {

        string qry = "select count(*),Max(id) from tb_course";
        SqlCommand cmd = new SqlCommand(qry, con);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {

            int a = Convert.ToInt32(dr[0].ToString());
            if (a == 0)
            {
                //i = a + 1;
                Textbox3.Text = "C001";
                dr.Close();

            }
            else
            {
                int b = Convert.ToInt32(dr[1].ToString());
                dr.Close();
                //i=a+1;
                int c = b + 1;
                string d = "C00" + c.ToString();
                Textbox3.Text = d;
               
            }


        }
    }
    private void grid_bind()
    {
        List<himachalsikshasamiti.courseprp> k;
        GridView1.DataSource = obj.disp_rec();
        GridView1.DataBind();
    
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        objprp.course_code = Convert.ToString(Textbox3.Text);
        objprp.course_name = TextBox1.Text;
        obj.save_rec(objprp);
        TextBox1.Text = string.Empty;
        TextBox1.Focus();
        grid_bind();
        auto_incriment();
       
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
        Label lb = (Label)GridView1.Rows[e.RowIndex].FindControl("lbcoursecode1");
        objprp.course_code = Convert.ToString(lb.Text);
        obj.delete_rec(objprp);
        grid_bind();
        auto_incriment();
    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        Label lb = (Label)GridView1.Rows[e.RowIndex].FindControl("lbcoursecode");
        TextBox txtname = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtxourse_name");
        objprp.course_code = Convert.ToString(lb.Text);
        objprp.course_name = txtname.Text;
        obj.update_rec(objprp);
      
        GridView1.EditIndex = -1;
        grid_bind();
    }
}