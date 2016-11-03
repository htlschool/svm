<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="schoolmaster.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

        <div class="content-wrapper">
        <!-- Content Header (Page header) -->
        <section class="content-header">
          <h1>
            Add New School
            <small>Preview</small>
          </h1>
          <ol class="breadcrumb">
            <li><a href="DashBoard.aspx"><i class="fa fa-dashboard"></i> Home</a></li>
           
            <li class="active">New School</li>
          </ol>
        </section>

        <!-- Main content -->
        <section class="content">
          <div class="row">
            <!-- left column -->
            <div class="col-md-12">
              <!-- general form elements -->
              <div class="box box-primary">

                <div class="box-header with-border">
                  <h3 class="box-title">Add New School</h3>
                </div><!-- /.box-header -->
                <!-- form start -->
              
                  <div class="box-body">
                    <div class="form-group">
                      <label for="exampleInputEmail1">School  Name</label>
                     <asp:TextBox runat="server" class="form-control" id="txtname" placeholder="Enter School Name"></asp:TextBox>
                                      </div>
                      <div class="form-group">
                      <label for="exampleInputEmail1">Address</label>
                     <asp:TextBox runat="server" class="form-control" id="txtaddress" placeholder="Enter Address" TextMode="MultiLine" ></asp:TextBox>
                                           </div>
                      <div class="form-group">
                      <label for="exampleInputEmail1">Email Id</label>
                     <asp:TextBox runat="server" class="form-control" id="txtemail" placeholder="Enter valid Email" ></asp:TextBox>
                                           </div>

                      <div class="form-group">
                      <label for="exampleInputEmail1">school Contact NO</label>
                     <asp:TextBox runat="server" class="form-control" id="txtcontact" placeholder="Enter MobileNo Number" ></asp:TextBox>
                                           </div>

                        <div class="form-group">
                      <label for="exampleInputEmail1">Principal Name</label>
                     <asp:TextBox runat="server" class="form-control" id="txtprincipal" placeholder="Enter Principal Name" ></asp:TextBox>
                                           </div>






                        <div class="form-group">
                      <label for="exampleInputEmail1">School Affilation Details:</label>
                     <asp:TextBox runat="server" class="form-control" id="txtaffiled" placeholder=" School Affilation Details" ></asp:TextBox>
                           </div>
                        
                      
                       <div class="form-group">
                      <label for="exampleInputEmail1">School Code</label>
                     <asp:TextBox runat="server" class="form-control" id="txtcode" placeholder="Enter School Code" ></asp:TextBox>
                 </div>
                           <div class="form-group">
                      <label for="exampleInputEmail1">Sankul/Exam center</label>
                   <asp:DropDownList ID="ddlexam" CssClass="form-control" runat="server"></asp:DropDownList>
                 </div>
                     
                       <div class="form-group">
                      <label for="exampleInputEmail1">School Course</label>
                   <asp:DropDownList ID="ddlcourse" CssClass="form-control" runat="server"></asp:DropDownList>
                 </div>
                    <div class="form-group">
                      <label for="exampleInputEmail1">School session start</label>
                   <asp:DropDownList ID="ddlstart"  runat="server" >
                       <asp:ListItem>2016</asp:ListItem>
                       <asp:ListItem>2017</asp:ListItem>
                       <asp:ListItem>2018</asp:ListItem>
                       <asp:ListItem>2019</asp:ListItem>
                       <asp:ListItem>2020</asp:ListItem>
                        </asp:DropDownList> &nbsp;&nbsp;   <label for="exampleInputEmail1">School session End</label>
                   <asp:DropDownList ID="ddlend"  runat="server">
                       <asp:ListItem>2016</asp:ListItem>
                       <asp:ListItem>2017</asp:ListItem>
                       <asp:ListItem>2018</asp:ListItem>
                       <asp:ListItem>2019</asp:ListItem>
                       <asp:ListItem>2020</asp:ListItem>
                       <asp:ListItem></asp:ListItem>
                        </asp:DropDownList>
                 </div>    &nbsp;&nbsp;  
                    
                  
                      <div class="form-group">
                      <label for="exampleInputEmail1">Remarks</label>
                     <asp:TextBox runat="server" class="form-control" id="txtremark" placeholder="Enter Remarks"></asp:TextBox>
                    </div>
                      <div class="form-group">
                      <label for="exampleInputEmail1">Upolad school picure</label>

                           <asp:FileUpload ID="img_upload" CssClass="form-control" runat="server"  />
<asp:Image ID="picschool" runat="server" Width="150px" Height="150px" Visible="false" />
                                        </div>
                       <div class="form-group">
                      <label for="exampleInputEmail1">Upolad school logo</label>

                           <asp:FileUpload ID="FileUpload1" CssClass="form-control" runat="server"  />
<asp:Image ID="Image1" runat="server" Width="150px" Height="150px" Visible="false" />
                                        </div>

                       

 <div class="form-group">
<asp:Button ID="Button1" CssClass="form-control btn-primary"   runat="server" Text="Save" OnClick="Button1_Click" />
                    </div>
                    </div>
                  </div>
            </div><!--/.col (right) -->
          </div>   <!-- /.row -->
             <div class="row">
            <!-- left column -->
            <div class="col-md-12">
              <!-- general form elements -->
              <div class="box box-primary">
                <div class="box-header with-border">
                  <h3 class="box-title">School Details</h3>
                </div><!-- /.box-header -->
                <!-- form start -->
                    <div class="box-body">
                            

                               <asp:GridView ID="GridView1"  class="col-md-12 table" runat="server" AutoGenerateColumns="false" OnRowUpdating="GridView1_RowUpdating" OnRowDeleting="GridView1_RowDeleting">
            <FooterStyle BackColor="White" ForeColor="#000066" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" Font-Size="Small" />
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                    <Columns>
               <asp:TemplateField HeaderText="ID">
                      <ItemTemplate>
                 
                           <asp:Label ID="lb1" runat="server" Text=' <%# Eval("id") %>'></asp:Label>
                        </ItemTemplate>
                     <EditItemTemplate>
                        <asp:Label ID="label_id" runat="server" Text=' <%# Eval("id") %>'></asp:Label>
                    </EditItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="School_code">
                    <ItemTemplate>
               <asp:Label ID="lbschoolcode1" runat="server" Text='<%# Eval("school_code") %>' />
                        </ItemTemplate>
                    <EditItemTemplate>
                     <%--  <asp:TextBox ID="txtxourse_code" runat="server" Width="120px" Text='<%# Eval("course_code") %>'></asp:TextBox>--%>
                        <asp:Label ID="lbcode" runat="server" Text='<%# Eval("school_code") %>' />
                    </EditItemTemplate>
                </asp:TemplateField>


                <asp:TemplateField HeaderText="School Name">
                     <ItemTemplate>
                   <%# Eval("school_name") %>
                        </ItemTemplate>
                          </asp:TemplateField>
               <asp:TemplateField HeaderText="Contact No.">
                     <ItemTemplate>
                   <%# Eval("school_contact") %>
                        </ItemTemplate>
                          </asp:TemplateField>
                                         <asp:TemplateField HeaderText="Address">
                     <ItemTemplate>
                   <%# Eval("school_address") %>
                        </ItemTemplate>
                          </asp:TemplateField>
                
                                             
                 <asp:TemplateField HeaderText="Edit">
                    <ItemTemplate>
                        <asp:Button ID="LinkButton1" runat="server" CssClass="form-control btn-primary" Text="Edit" CommandName="update"/>
                    </ItemTemplate>
                   
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Delete">
                <ItemTemplate>
                    <asp:Button ID="LinkButton4" runat="server" CssClass="form-control btn-primary" Text="Delete" CommandName="delete"/>
                </ItemTemplate>
                    </asp:TemplateField>

            </Columns>
        </asp:GridView>
                           

                           </div>







              
            <%--      <div class="box-body">
                    <div class="form-group">
                         <div class="form-group">
                      <label for="exampleInputEmail1">School Name</label>
                     <asp:TextBox runat="server" class="form-control"  id="txt_edit_for_mobile" placeholder="Enter phone no"></asp:TextBox>
                
                              </div>
                         <div class="form-group">
          <asp:Button ID="Button2" CssClass="form-control btn-primary"    runat="server" Text="Edit"  />
                    </div>

                        </div>
                      </div>--%>
                  </div>
                </div>
                 </div>
            
        </section><!-- /.content -->
      </div><!-- /.content-wrapper -->
</asp:Content>

