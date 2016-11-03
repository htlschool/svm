using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using himachalsikshasamiti;



public partial class _Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection();
  
    himachalsikshasamiti.examprp objprp = new examprp();
    himachalsikshasamiti.clsexam obj = new clsexam();
    protected void Page_Load(object sender, EventArgs e)
    {
        con.ConnectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
       
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }
        
    if(!Page.IsPostBack)

        {

            exam_bind();
            class_bind();
        }
    }
    private void exam_bind()
    {
        himachalsikshasamiti.examprp objprp = new examprp();
        himachalsikshasamiti.clsexam obj = new clsexam();
        List<himachalsikshasamiti.classprp> k;
        DropDownList1.DataTextField = "exam_name";
        DropDownList1.DataValueField = "exam_code";
        DropDownList1.DataSource = obj.disp_rec();
        DropDownList1.DataBind();
        DropDownList1.Items.Insert(0, new ListItem("select Exam", "0"));


    
    }
    private void class_bind()
    {
        himachalsikshasamiti.clsclassprp objprp = new clsclassprp();
        himachalsikshasamiti.clsclass obj = new clsclass();
        List<himachalsikshasamiti.clsclassprp> k;
    
        DropDownList2.DataTextField = "class_name";
        DropDownList2.DataValueField = "class_code";
        DropDownList2.DataSource = obj.disp_rec();
        DropDownList2.DataBind();
        DropDownList2.Items.Insert(0, new ListItem("select class", "0"));
    
    
    }
    private void auto_incriment()
    {

        string qry = "select count(*),Max(id) from tb_school";
        SqlCommand cmd = new SqlCommand(qry, con);

        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            int a = Convert.ToInt32(dr[0].ToString());
            if (a == 0)
            {
                //i = a + 1;
                TextBox2.Text = "CEX01";
                dr.Close();
            }
            else
            {
                int b = Convert.ToInt32(dr[1].ToString());
                dr.Close();
                //i=a+1;
                int c = b + 1;
                string d = "CEX0" + c.ToString();
                TextBox2.Text = d;
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        objprp.exam_code = DropDownList1.SelectedValue;

    }
}