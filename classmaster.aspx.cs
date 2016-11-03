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
    himachalsikshasamiti.clsclassprp objprp = new clsclassprp();
    himachalsikshasamiti.clsclass obj = new clsclass();
 
    protected void Page_Load(object sender, EventArgs e)
    {
        con.ConnectionString=ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }
        if (!Page.IsPostBack)
        {
            course_bind();
            auto_incriment();
            grid_bind();
        }
    }

    private void course_bind()
    {
        himachalsikshasamiti.courseprp ppp = new courseprp();
        himachalsikshasamiti.clscourse pp = new clscourse();
        List<himachalsikshasamiti.courseprp> k;
        ddlcourse.DataTextField = "course_name";
        ddlcourse.DataValueField = "course_code";
        ddlcourse.DataSource = pp.disp_rec();
        ddlcourse.DataBind();
        ddlcourse.Items.Insert(0,new ListItem("Select Course","0"));
    
    }
    private void auto_incriment()
    {

        string qry = "select count(*),Max(id) from tb_class";
        SqlCommand cmd = new SqlCommand(qry, con);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {

            int a = Convert.ToInt32(dr[0].ToString());
            if (a == 0)
            {
                //i = a + 1;
                txtclasscode.Text = "Cls01";
                dr.Close();

            }
            else
            {
                int b = Convert.ToInt32(dr[1].ToString());
                dr.Close();
                //i=a+1;
                int c = b + 1;
                string d = "Cls0" + c.ToString();
                txtclasscode.Text = d;

            }


        }
    }
    private void grid_bind()
    {
        List<himachalsikshasamiti.clsclassprp> k;
        GridView1.DataSource = obj.disp_rec();
        GridView1.DataBind();
    
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        objprp.course_code = ddlcourse.SelectedValue;
        objprp.class_code = txtclasscode.Text;
        objprp.class_name = txtclass.Text;
        obj.save_rec(objprp);
        grid_bind();
        auto_incriment();
        ddlcourse.SelectedIndex = 0;
        txtclass.Text = string.Empty;
        txtclass.Focus();





    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {

    }
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        grid_bind();

    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        grid_bind();
    }
}
