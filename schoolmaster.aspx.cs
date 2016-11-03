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
   himachalsikshasamiti.clsschoolprp objprp = new clsschoolprp();
    himachalsikshasamiti.clsschool obj = new clsschool();
   // himachalsikshasamiti.clsschoolprp objprp = new himachalsikshasamiti.clsschoolprp();
    himachalsikshasamiti.clssankulprp ppp = new clssankulprp();
    himachalsikshasamiti.clssankul pp = new clssankul();
    himachalsikshasamiti.courseprp prp = new courseprp();
    himachalsikshasamiti.clscourse obje = new clscourse();
    protected void Page_Load(object sender, EventArgs e)
    {
        con.ConnectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }
        if (!Page.IsPostBack)
        {
            sankul_bind();
            auto_incriment();
            school_course();
            grid_bind();
        }
    }
    private void sankul_bind()
    {
        List<himachalsikshasamiti.clssankulprp>k ;
      //  k = pp.disp_rec();
        ddlexam.DataTextField = "sankul_name";
        ddlexam.DataValueField = "sankul_code";
        ddlexam.DataSource = pp.disp_rec();
        ddlexam.DataBind();
        ddlexam.Items.Insert(0, new ListItem("select Exam Center", "0"));

    
    }
    private void school_course()
    {
        List<himachalsikshasamiti.courseprp> k;
        ddlcourse.DataTextField = "course_name";
        ddlcourse.DataValueField = "course_code";
        ddlcourse.DataSource = obje.disp_rec();
        ddlcourse.DataBind();
        ddlcourse.Items.Insert(0, new ListItem("Select Course", "0"));
    
    }
    private void grid_bind()
    {

        List<himachalsikshasamiti.clsschoolprp> k;
        GridView1.DataSource = obj.disp_rec();
        GridView1.DataBind();
    
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
                txtcode.Text = "SCH001";
                dr.Close();
            }
            else
            {
                int b = Convert.ToInt32(dr[1].ToString());
                dr.Close();
                //i=a+1;
                int c = b + 1;
                string d = "SCH00" + c.ToString();
                txtcode.Text = d;
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        

        string a = ddlstart.SelectedValue;
        string b = ddlend.SelectedValue;
         string  c = a + "-" + b;
         if (Button1.Text == "update")
         {
             objprp.school_code = txtcode.Text;
             objprp.school_name = txtname.Text;
             objprp.school_address = txtaddress.Text;
             objprp.school_email = txtemail.Text;
             objprp.school_session = c;
             objprp.sankul_code = ddlexam.SelectedValue;
             objprp.school_affilation = txtaffiled.Text;
             objprp.school_contact = txtcontact.Text;
             objprp.remark = txtremark.Text;
             objprp.principal_name = txtprincipal.Text;
             objprp.school_bckround = img_upload.PostedFile.FileName;
             objprp.school_logo = FileUpload1.PostedFile.FileName;
             objprp.school_courses = ddlcourse.SelectedValue;
             objprp.school_status = "1";
             obj.update_rec(objprp);
             grid_bind();
             clear_rec();

             

         }
         else
         {
             objprp.school_name = txtname.Text;
             objprp.school_address = txtaddress.Text;
             objprp.school_email = txtemail.Text;
             objprp.school_contact = txtcontact.Text;
             objprp.principal_name = txtprincipal.Text;
             objprp.sankul_code = ddlexam.SelectedValue;
             objprp.school_session = c;
             objprp.school_code = txtcode.Text;
             objprp.school_affilation = txtaffiled.Text;
             objprp.remark = txtremark.Text;
             objprp.school_status = "1";
             objprp.school_courses = ddlcourse.SelectedValue;
             objprp.school_bckround = img_upload.PostedFiles.ToString();
             objprp.school_logo = FileUpload1.PostedFiles.ToString();
             obj.save_rec(objprp);
             grid_bind();
             auto_incriment();
             clear_rec();

         }
    }

    private void clear_rec()
    {
        txtname.Text = string.Empty;
        txtaddress.Text = string.Empty;
        txtemail.Text = string.Empty;
        txtcontact.Text = string.Empty;
        txtprincipal.Text = string.Empty;
        ddlexam.SelectedIndex = 0;
        txtaffiled.Text = string.Empty;
        txtremark.Text = string.Empty;
        txtname.Focus();
    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        string id = string.Empty;
        id = ((Label)GridView1.Rows[e.RowIndex].FindControl("lbschoolcode1")).Text;
        List<himachalsikshasamiti.clsschoolprp> k;
        k = obj.find_rec(id);
        txtname.Text = k[0].school_name;
        txtaddress.Text = k[0].school_address;
        txtemail.Text = k[0].school_email;
        txtcode.Text = k[0].school_code;
        txtprincipal.Text = k[0].principal_name;
        ddlstart.SelectedItem.Text = k[0].school_session;
        ddlend.SelectedItem.Text = k[0].school_session;
        ddlexam.SelectedValue = k[0].sankul_code;
        txtaffiled.Text = k[0].school_affilation;
        txtcontact.Text = k[0].school_contact;
        ddlcourse.SelectedValue  = k[0].school_courses;
        txtremark.Text = k[0].remark;
        //img_upload.PostedFile.FileName = k[0].school_bckround;
        //FileUpload1.PostedFile.FileName = k[0].school_logo;
        Button1.Text = "update";
        

    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string id = string.Empty;
        id = ((Label)GridView1.Rows[e.RowIndex].FindControl("lbschoolcode1")).Text;
        objprp.school_code = id;
        obj.delete_rec(objprp);
        grid_bind();
        auto_incriment();
    }
}