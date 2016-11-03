using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace himachalsikshasamiti
{
    public interface intsankul
    {

        Int32 id
        {
            get;
            set;

        }
        string sankul_code
        {
            get;
            set;

        }
        string sankul_name
        {
            get;
            set;

        }
    }
    public interface intclass
    {
        Int32 id
        {
            get;
            set;
        }
        string course_code
        {
            get;
            set;
        }
        string class_name
        {
            get;
            set;
        }
        string class_code
        {
            get;
            set;
        }
       

    }
    public interface intclassexam
    {
        Int32 id
        {
            get;
            set;
        }
        string Exam_code
        {
            get;
            set;

        }
        string class_code
        {
            get;
            set;
        }
        float exam_fee
        {
            get;
            set;

        }
        string classexam_code
        {
            get;
            set;
        }

    }
    public interface intschool
    {
        Int32 id
        {
            get;
            set;
        }
        string school_code
        {
            get;
            set;
        }
        string school_name
        {
            get;
            set;
        }
        string school_address
        {
            get;
            set;
        }
        string school_email
        {
            get;
            set;
        }
        string principal_name
        {
            get;
            set;
        }
        string school_session
        {
            get;
            set;

        }

        string sankul_code
        {
            get;
            set;

        }
        string school_affilation
        {
            get;
            set;
        }
        string school_contact
        {
            get;
            set;
        }
        string remark
        {
            get;
            set;

        }

        string school_bckround
        {
            get;
            set;


        }
        string school_logo
        {
            get;
            set;
        }
        string school_status
        {

            get;
            set;

        }
        string school_courses
        {
            get;
            set;

        }
    }
    public interface intcourse
    {
        Int32 id
        {
            get;
            set;
        }
        String course_code
        {
            get;
            set;
        }
        String course_name
        {
            get;
            set;
        }
    }
    public interface intexam
    {
        Int32 id
        {
            get;
            set;
        }
        string exam_code
        {
            get;
            set;
        }
        string exam_name
        {
            get;
            set;
        }
    }
  


    // properties class
    public class clssankulprp : intsankul
    {
        private Int32 sankulidprv;
        private String sankulcodeprv, sankulnameprv;
        public int id
        {

            get
            {
                return sankulidprv;
            }
            set
            {
                sankulidprv = value;
            }
        }

        public string sankul_code
        {
            get
            {
                return sankulcodeprv;
            }
            set
            {
                sankulcodeprv = value;
            }
        }

        public string sankul_name
        {
            get
            {
                return sankulnameprv;
            }
            set
            {
                sankulnameprv = value;
            }
        }
    }
    public class clsclassprp : intclass
    {
        private Int32 classidprv;
        private string coursecodeprv, classnameprv, classcodeprv;
        public int id
        {
            get
            {
                return classidprv;
            }
            set
            {
                classidprv = value;
            }
        }

        public string course_code
        {
            get
            {
                return coursecodeprv;
            }
            set
            {
                coursecodeprv = value;
            }
        }

        public string class_name
        {
            get
            {
                return classnameprv;
            }
            set
            {
                classnameprv = value;
            }
        }

        public string class_code
        {
            get
            {
                return classcodeprv;
            }
            set
            {
                classcodeprv = value;
            }
        }
    }
    public class clsclassexamprp : intclassexam
    {
        private Int32 classexamidprv;
        private string classexamcodeprv, examcodeprv,classcodeprv;
        private float examfeeprv;
        public int id
        {
            get
            {
                return classexamidprv;
            }
            set
            {
                classexamidprv = value;
            }
        }

        public string Exam_code
        {
            get
            {
                return examcodeprv;
            }
            set
            {
                examcodeprv = value;
            }
        }

        public string class_code
        {
            get
            {
                return classcodeprv;
            }
            set
            {
                classcodeprv = value;
            }
        }

        public float exam_fee
        {
            get
            {
                return examfeeprv;
            }
            set
            {
                examfeeprv = value;
            }
        }
        public string classexam_code
        {
            get
            {
                return classexamcodeprv;
            
            }
            set
            {

                classexamcodeprv = value;
            }

        }
    }
    public class clsschoolprp : intschool
    {
        private Int32 schoolidprv;
        private string schoolcodeprv, schoolnameprv, schooladdressprv, schoolemailprv, principalnameprv, schoolsessionprv, sankulcodeprv, schoolaffilationprv, schoolcontactprv, remarkprv, schoolbckroundprv, schoollogoprv, schoolstatusprv ,schoolcoursesprv;
        public int id
        {


            get
            {
                return schoolidprv;
            }
            set
            {
                schoolidprv = value;
            }
        }

        public string school_code
        {
            get
            {
                return schoolcodeprv;
            }
            set
            {
                schoolcodeprv = value;
            }
        }

        public string school_name
        {
            get
            {
                return schoolnameprv;
            }
            set
            {
                schoolnameprv = value;
            }
        }

        public string school_address
        {
            get
            {
                return schooladdressprv;
            }
            set
            {
                schooladdressprv = value;
            }
        }

        public string school_email
        {
            get
            {
                return schoolemailprv;
            }
            set
            {
                schoolemailprv = value;
            }
        }

        public string principal_name
        {
            get
            {
                return principalnameprv;
            }
            set
            {
                principalnameprv = value;
            }
        }

        public string school_session
        {
            get
            {
                return schoolsessionprv;
            }
            set
            {
                schoolsessionprv = value;
            }
        }

        public string sankul_code
        {
            get
            {
                return sankulcodeprv;
            }
            set
            {
                sankulcodeprv = value;
            }
        }

        public string school_affilation
        {
            get
            {
                return schoolaffilationprv;
            }
            set
            {
                schoolaffilationprv = value;
            }
        }

        public string school_contact
        {
            get
            {
                return schoolcontactprv;
            }
            set
            {
                schoolcontactprv = value;
            }
        }

        public string remark
        {
            get
            {
                return remarkprv;
            }
            set
            {
                remarkprv = value;
            }
        }

        public string school_bckround
        {
            get
            {
                return schoolbckroundprv;
            }
            set
            {
                schoolbckroundprv = value;
            }
        }

        public string school_logo
        {
            get
            {
                return schoollogoprv;
            }
            set
            {
                schoollogoprv = value;
            }
        }

        public string school_status
        {
            get
            {
                return schoolstatusprv;
            }
            set
            {
                schoolstatusprv = value;
            }
        }
        public string school_courses
        {
            get
            {
                return schoolcoursesprv;
            }
            set
            {


                schoolcoursesprv = value;
            }
        
        }
    }
    public class courseprp : intcourse
    {
        private Int32 courseidprp;
        private String coursecodeprp, coursenameprp;
        public string course_code
        {
            get
            {
                return coursecodeprp;
            }

            set
            {
                coursecodeprp = value;
            }
        }

        public int id
        {
            get
            {
                return courseidprp;

            }

            set
            {
                courseidprp = value;
            }
        }

        public string course_name
        {
            get
            {
                return coursenameprp;
            }

            set
            {
                coursenameprp = value;
            }
        }
    }
    public class examprp : intexam
    {
        private Int32 examidprp;
        private String examcodeprp, examnameprp;
        public string exam_code
        {
            get
            {
                return examcodeprp;

            }

            set
            {
                examcodeprp = value;
            }
        }

        public int id
        {
            get
            {
                return examidprp;
            }

            set
            {
                examidprp = value;
            }
        }

        public string exam_name
        {
            get
            {
                return examnameprp;

            }

            set
            {
                examnameprp = value;
            }
        }
    }
    public class classprp : intclass
    {
        private Int32 classidprp;
        private string classnameprp, classcodeprp, coursecodeprp;
        public string class_code
        {
            get
            {
                return classcodeprp;
            }

            set
            {
                classcodeprp = value;
            }
        }

        public int id
        {
            get
            {
                return classidprp;
            }

            set
            {
                classidprp = value;
            }
        }

        public string class_name
        {
            get
            {
                return classnameprp;
            }

            set
            {
                classnameprp = value;
            }
        }

        public string course_code
        {
            get
            {
                return coursecodeprp;
            }

            set
            {
                coursecodeprp = value;
            }
        }
    }




    // connection class
    public abstract class clscon
    {
        protected SqlConnection con = new SqlConnection();

        public clscon()
        {

            con.ConnectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;

        }

    }



    //metod
    public class clssankul : clscon
    {
        public void save_rec(clssankulprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            
            }
            SqlCommand cmd = new SqlCommand("inssankul", con);
            cmd.CommandType = CommandType.StoredProcedure;
           // cmd.Parameters.AddWithValue("@sankul_id", p.sankul_id);
            cmd.Parameters.AddWithValue("@cod",p.sankul_code);
            cmd.Parameters.AddWithValue("@name", p.sankul_name);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        
        }
        public void update_rec(clssankulprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("updsankul", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@code", p.sankul_code);
            cmd.Parameters.AddWithValue("@name", p.sankul_name);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        
        }
        public void delete_rec(clssankulprp p)
        {
            if (con.State == ConnectionState.Closed)
            {

                con.Open();
            }
            SqlCommand cmd = new SqlCommand("delsankul", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@code",p.sankul_code);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        
        }
        public List<clssankulprp> disp_rec()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("dispsankul", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clssankulprp> obj = new List<clssankulprp>();
            while(dr.Read())
            {
            clssankulprp k=new clssankulprp();
                k.id=Convert.ToInt32(dr[0]);
                k.sankul_code=dr[1].ToString();
                k.sankul_name=dr[2].ToString();
                obj.Add(k);
            
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
        
        }
        public List<clssankulprp> find_rec(string sankul_code)
        {

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("findsankul", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@code", sankul_code);
            SqlDataReader dr = cmd.ExecuteReader();
            List<clssankulprp> obj = new List<clssankulprp>();
            if (dr.HasRows)
            {
                clssankulprp k = new clssankulprp();
                k.id = Convert.ToInt32(dr[0]);
                k.sankul_code = dr[1].ToString();
                k.sankul_name = dr[2].ToString();
                obj.Add(k);

            
            
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;

        
        }
    }
    public class clsschool : clscon
    {

        public void save_rec(clsschoolprp p)
        {
            if (con.State == ConnectionState.Closed)
            {

                con.Open();
            }
            SqlCommand cmd = new SqlCommand("insschool", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@schoolcode", p.school_code);
            cmd.Parameters.AddWithValue("@schoolname", p.school_name);
            cmd.Parameters.AddWithValue("@schooladdress", p.school_address);
            cmd.Parameters.AddWithValue("@schoolemail", p.school_email);
            cmd.Parameters.AddWithValue("@principal", p.principal_name);
            cmd.Parameters.AddWithValue("@session", p.school_session);
            cmd.Parameters.AddWithValue("@sankulcode", p.sankul_code);
            cmd.Parameters.AddWithValue("@remark", p.remark);
            cmd.Parameters.AddWithValue("@schoolbackround", p.school_bckround);
            cmd.Parameters.AddWithValue("@schoollogo", p.school_logo);
            cmd.Parameters.AddWithValue("@schoolstatus", p.school_status);
            cmd.Parameters.AddWithValue("@schoolaffilated", p.school_affilation);
            cmd.Parameters.AddWithValue("@schoolcontact", p.school_contact);
            cmd.Parameters.AddWithValue("@schoolcourses", p.school_courses);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        
        }
        public void update_rec(clsschoolprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("updschool", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@schoolcode", p.school_code);
            cmd.Parameters.AddWithValue("@schoolname", p.school_name);
            cmd.Parameters.AddWithValue("@schooladdress", p.school_address);
            cmd.Parameters.AddWithValue("@schoolemail", p.school_email);
            cmd.Parameters.AddWithValue("@principal", p.principal_name);
            cmd.Parameters.AddWithValue("@session", p.school_session);
            cmd.Parameters.AddWithValue("@sankulcode", p.sankul_code);
            cmd.Parameters.AddWithValue("@remark", p.remark);
            cmd.Parameters.AddWithValue("@schoolbackround", p.school_bckround);
            cmd.Parameters.AddWithValue("@schoollogo", p.school_logo);
            cmd.Parameters.AddWithValue("@schoolstatus", p.school_status);
            cmd.Parameters.AddWithValue("@schoolaffilated", p.school_affilation);
            cmd.Parameters.AddWithValue("@schoolcontact", p.school_contact);
            cmd.Parameters.AddWithValue("@schoolcourse", p.school_courses);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();



        }
        public void delete_rec(clsschoolprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("delschool", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@schoolcode", p.school_code);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        
        }
        public List<clsschoolprp> disp_rec()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("dispschool",con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsschoolprp> obj = new List<clsschoolprp>();
            while (dr.Read())
            {

                clsschoolprp k = new clsschoolprp();
                k.id = Convert.ToInt32(dr[0]);
                k.school_code = dr[1].ToString();
                k.school_name = dr[2].ToString();
                k.school_address = dr[3].ToString();
                k.school_email = dr[4].ToString();
                k.principal_name = dr[5].ToString();
                k.school_session = dr[6].ToString();
                k.sankul_code = dr[7].ToString();
                k.school_affilation = dr[8].ToString();
                k.school_contact = dr[9].ToString();
                k.remark = dr[10].ToString();
                k.school_bckround = dr[11].ToString();
                k.school_logo = dr[12].ToString();
                k.school_status = dr[13].ToString();
                k.school_courses = dr[14].ToString();
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
        
        }
        public List<clsschoolprp> find_rec(string school_code)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            
            }
            SqlCommand cmd = new SqlCommand("findschool", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@schoolcode", school_code);
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsschoolprp> obj = new List<clsschoolprp>();
            if (dr.HasRows)
            {
                dr.Read();
                clsschoolprp k = new clsschoolprp();
                k.id = Convert.ToInt32(dr[0]);
                k.school_code = dr[1].ToString();
                k.school_name = dr[2].ToString();
                k.school_address = dr[3].ToString();
                k.school_email = dr[4].ToString();
                k.principal_name = dr[5].ToString();
                k.school_session = dr[6].ToString();
                k.sankul_code = dr[7].ToString();
                k.school_affilation = dr[8].ToString();
                k.school_contact = dr[9].ToString();
                k.remark = dr[10].ToString();
                k.school_bckround = dr[11].ToString();
                k.school_logo = dr[12].ToString();
                k.school_status = dr[13].ToString();
                k.school_courses = dr[14].ToString();
                obj.Add(k);
            
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;

        
        }
    }
    public class clsclassexam : clscon
    {
        public void save_rec(clsclassexamprp p)

        {
            if (con.State == ConnectionState.Closed)
            {

                con.Open();
            }
            SqlCommand cmd = new SqlCommand("insclassexamfee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@classexamcode", p.classexam_code);
            cmd.Parameters.AddWithValue("@examcode", p.Exam_code);
            cmd.Parameters.AddWithValue("@classcode", p.class_code);
            cmd.Parameters.AddWithValue("examfee", Convert.ToSingle(p.exam_fee));
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();


            
            
            
            
        
        }
        public void update_rec(clsclassexamprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("updclassexamfee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@classexamcode", p.classexam_code);
            cmd.Parameters.AddWithValue("@examcode", p.Exam_code);
            cmd.Parameters.AddWithValue("@classcode", p.class_code);
            cmd.Parameters.AddWithValue("examfee", Convert.ToSingle(p.exam_fee));
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void delete_rec(clsclassexamprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();

            }
            SqlCommand cmd = new SqlCommand("delclassexamfee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@classexamcode", p.classexam_code);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

            
            
            
        
        }
        public List<clsclassexamprp> disp_rec()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();

            }
            SqlCommand cmd = new SqlCommand("dispclassexamfee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsclassexamprp> obj = new List<clsclassexamprp>();
            while (dr.Read())
            {
                clsclassexamprp k = new clsclassexamprp();
                k.id = Convert.ToInt32(dr[0]);
                k.classexam_code = dr[1].ToString();
                k.Exam_code = dr[2].ToString();
                k.class_code = dr[3].ToString();
                k.exam_fee = Convert.ToSingle(dr[4]);
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;

        
        
        }
        public List<clsclassexamprp> find_rec(string classexam_code)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();

            }
            SqlCommand cmd = new SqlCommand("findclassexamfee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@classexamcode", classexam_code);
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsclassexamprp> obj = new List<clsclassexamprp>();
            if (dr.HasRows)
            {
                dr.Read();
                clsclassexamprp k = new clsclassexamprp();
                  
                k.id = Convert.ToInt32(dr[0]);
                k.classexam_code = dr[1].ToString();
                k.Exam_code = dr[2].ToString();
                k.class_code = dr[3].ToString();
                k.exam_fee = Convert.ToSingle(dr[4]);
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
            
            }

            
            
            
            

        }
    public class clscourse : clscon
    {
        public void save_rec(courseprp p)
        {

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("inscourse", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@coursecode", SqlDbType.VarChar, 10).Value = p.course_code;
            cmd.Parameters.Add("@coursename", SqlDbType.VarChar, 50).Value = p.course_name;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void update_rec(courseprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("updcourse", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@coursecode", SqlDbType.VarChar, 10).Value = p.course_code;
            cmd.Parameters.Add("@coursename", SqlDbType.VarChar, 50).Value = p.course_name;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void delete_rec(courseprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("delcourse", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@coursecode", SqlDbType.VarChar, 10).Value = p.course_code;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public List<courseprp> disp_rec()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("dispcourse", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            List<courseprp> obj = new List<courseprp>();
            while (dr.Read()) 
            {
                courseprp k = new courseprp();
                k.id = Convert.ToInt32(dr[0]);
                k.course_code = dr[1].ToString();
                k.course_name = dr[2].ToString();
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
        }
        public List<courseprp> find_rec(String coursecode)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("findcourse", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@coursecode", SqlDbType.VarChar, 10).Value = coursecode;
            SqlDataReader dr = cmd.ExecuteReader();
            List<courseprp> obj = new List<courseprp>();
            if (dr.HasRows)
            {
                dr.Read();
                courseprp K = new courseprp();
                K.id = Convert.ToInt32(dr[0]);
                K.course_code = dr[1].ToString();
                K.course_name = dr[2].ToString();
                obj.Add(K);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;

        }
    }
    public class clsexam : clscon
    {
        public void save_rec(examprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("insexam", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@examcode", SqlDbType.VarChar, 10).Value = p.exam_code;
            cmd.Parameters.Add("@examname", SqlDbType.VarChar, 50).Value = p.exam_name;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void update_rec(examprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("updexam", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@examcode", SqlDbType.VarChar, 10).Value = p.exam_code;
            cmd.Parameters.Add("@examname", SqlDbType.VarChar, 50).Value = p.exam_name;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void delete_rec(examprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("delexam", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@examcode", SqlDbType.VarChar, 10).Value = p.exam_code;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public List<examprp> disp_rec()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("dispexam", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            List<examprp> obj = new List<examprp>();
            while (dr.Read())
            {
                examprp k = new examprp();
                k.id = Convert.ToInt32(dr[0]);
                k.exam_code = dr[1].ToString();
                k.exam_name = dr[2].ToString();
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
        }
        public List<examprp> find_rec(string examcode)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("findexam", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@examcode", SqlDbType.VarChar, 10).Value = examcode;
            SqlDataReader dr = cmd.ExecuteReader();
            List<examprp> obj = new List<examprp>();
            if (dr.HasRows)
            {
                dr.Read();
                examprp k = new examprp();
                k.id = Convert.ToInt32(dr[0]);
                k.exam_code = dr[1].ToString();
                k.exam_name = dr[2].ToString();
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
        }
    }
    public class clsclass : clscon
    {
        public void save_rec(clsclassprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("insclass", con);
            cmd.CommandType = CommandType.StoredProcedure;
          
            cmd.Parameters.Add("@coursecode", SqlDbType.VarChar, 10).Value = p.course_code;
            cmd.Parameters.Add("@classname", SqlDbType.VarChar, 50).Value = p.class_name;
            cmd.Parameters.Add("@classcode", SqlDbType.VarChar, 10).Value = p.class_code;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void update_rec(classprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("updclass", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@coursecode", SqlDbType.VarChar, 10).Value = p.course_code;
            cmd.Parameters.Add("@classname", SqlDbType.VarChar, 50).Value = p.class_name;
            cmd.Parameters.Add("@classcode", SqlDbType.VarChar, 10).Value = p.class_code;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void delete_rec(classprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("delclass", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@classcode", SqlDbType.VarChar, 10).Value = p.class_code;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public List<classprp> disp_rec()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("dispclass", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            List<classprp> obj = new List<classprp>();
            while (dr.Read())
            {
                classprp k = new classprp();
               // k.id = Convert.ToInt32(dr[0]);
                k.class_code = dr[0].ToString();
                k.course_code = dr[2].ToString();
                k.class_name = dr[1].ToString();
              
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
        }
        public List<classprp> find_rec()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("findclass", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@classcode", SqlDbType.VarChar, 10);
            SqlDataReader dr = cmd.ExecuteReader();
            List<classprp> obj = new List<classprp>();
            if (dr.HasRows)
            {
                classprp k = new classprp();
                dr.Read();
                k.id = Convert.ToInt32(dr[0]);
                k.course_code = dr[1].ToString();
                k.class_name = dr[2].ToString();
                k.class_code = dr[3].ToString();
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;

        }

    }
    
    
    }




	
		
	