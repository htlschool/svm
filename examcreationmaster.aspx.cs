using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class _Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection();
    
    himachalsikshasamiti.examprp objprp = new himachalsikshasamiti.examprp();
    himachalsikshasamiti.clsexam obj = new himachalsikshasamiti.clsexam();
    protected void Page_Load(object sender, EventArgs e)
    {
        con.ConnectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }

        if (!Page.IsPostBack)
        {

            grid_bind();
            auto_incriment();
        }
    }
    private void grid_bind()
    {
        List<himachalsikshasamiti.clsexam> k;
        GridView1.DataSource = obj.disp_rec();
        GridView1.DataBind();
    
    }
    private void auto_incriment()
    {

        string qry = "select count(*),Max(id) from tb_exam";
        SqlCommand cmd = new SqlCommand(qry, con);

        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            int a = Convert.ToInt32(dr[0].ToString());
            if (a == 0)
            {
                //i = a + 1;
                Textbox3.Text = "EX001";
                dr.Close();
            }
            else
            {
                int b = Convert.ToInt32(dr[1].ToString());
                dr.Close();
                //i=a+1;
                int c = b + 1;
                string d = "EX00" + c.ToString();
                Textbox3.Text = d;
            }
        }
    }
         
    
    
    
    
    protected void Button1_Click(object sender, EventArgs e)
    {
        objprp.exam_code = Textbox3.Text;
        objprp.exam_name = TextBox1.Text;
        obj.save_rec(objprp);
        grid_bind();
        auto_incriment();
        TextBox1.Text = string.Empty;
        TextBox1.Focus();


    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {

        GridView1.EditIndex = e.NewEditIndex;
        grid_bind();
    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        Label lb = (Label)GridView1.Rows[e.RowIndex].FindControl("lbcode");
        TextBox txtname = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtexam_name");
        objprp.exam_code = lb.Text;
        objprp.exam_name = txtname.Text;
        obj.update_rec(objprp);
        grid_bind();
        GridView1.EditIndex = -1;
    }
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        grid_bind();
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Label lb = (Label)GridView1.Rows[e.RowIndex].FindControl("lbexamcode1");
        objprp.exam_code = lb.Text;
        obj.delete_rec(objprp);
        grid_bind();
        auto_incriment();
    }
}