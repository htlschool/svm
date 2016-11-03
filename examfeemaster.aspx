<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="examfeemaster.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="content-wrapper">
        <!-- Content Header (Page header) -->
        <section class="content-header">
          <h1>
          Add course
            <small>Preview</small>
          </h1>
          <ol class="breadcrumb">
            <li><a href="DashBoard.aspx"><i class="fa fa-dashboard"></i> Home</a></li>
           
            <li class="active">Add Exam  Fee</li>
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
                  <h3 class="box-title">Enter Details:-</h3>
                </div><!-- /.box-header -->
                <!-- form start -->
              
                  <div class="box-body">
                    <div class="form-group">
                      <label for="exampleInputEmail1">Select Exam : </label>
                        <asp:DropDownList ID ="DropDownList1" runat="server" CssClass="form-control" />
                    </div>
                        <div class="form-group">
                    <label>select class:</label>
                  
                     
                     <asp:DropDownList runat="server" class="form-control" id="DropDownList2" placeholder="Enter course Name"></asp:DropDownList>
                    
                  </div><!-- /.form group -->

                       <div class="form-group">
                    <label>Fee Amount:</label>
                  
                     
                     <asp:TextBox runat="server" class="form-control" id="TextBox1" placeholder="Enter course Name"></asp:TextBox>
                           <br/>
                           <asp:TextBox runat="server" class="form-control" id="TextBox2" Visible="false"></asp:TextBox>

                         
                  </div><!-- /.form group -->

                     
 <div class="form-group">
<asp:Button ID="Button1" CssClass="form-control btn-primary"   runat="server" Text="save" OnClick="Button1_Click"   />
                    </div>

                               <div class="box-body">
                            

                               <asp:GridView ID="GridView1"  class="col-md-12 table" runat="server" AutoGenerateColumns="False" >
            <FooterStyle BackColor="White" ForeColor="#000066" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" Font-Size="Small" />
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                    <Columns>
               <asp:TemplateField HeaderText="ID">
                      <ItemTemplate>
                 
                           <asp:Label ID="lbid" runat="server" Text=' <%# Eval("id") %>'></asp:Label>
                        </ItemTemplate>
                     <EditItemTemplate>
                        <asp:Label ID="label_id" runat="server" Text=' <%# Eval("id") %>'></asp:Label>
                    </EditItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Exam Name">
                    <ItemTemplate>
                  <%# Eval("exam_name") %>
                        </ItemTemplate>
                    <EditItemTemplate>
                       <asp:TextBox ID="txt_name" runat="server" Width="120px" Text='<%# Eval("exam_name") %>'></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>


                <asp:TemplateField HeaderText="Class Name">
                     <ItemTemplate>
                   <%# Eval("class_name") %>
                        </ItemTemplate>
                    <EditItemTemplate>
                      <asp:TextBox ID="txtclass_name" runat="server" Width="120px" Text='<%# Eval("class_name") %>'></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>

                   <asp:TemplateField HeaderText="Exam Fee">
                     <ItemTemplate>
                   <%# Eval("exam_fee") %>
                        </ItemTemplate>
                    <EditItemTemplate>
                      <asp:TextBox ID="txtexam_fee" runat="server" Width="120px" Text='<%# Eval("exam_fee") %>'></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>
                
                
                                             
                 <asp:TemplateField HeaderText="Edit">
                    <ItemTemplate>
                        <asp:Button ID="LinkButton1" runat="server" CssClass="form-control btn-primary" Text="Edit" CommandName="edit"/>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:Button ID="LinkButton2" runat="server" CssClass="form-control btn-primary" Text="Update" CommandName="update"/>
                        <asp:Button ID="LinkButton3" runat="server" CssClass="form-control btn-primary" Text="Cancel" CommandName="cancel"/>
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Delete">
                <ItemTemplate>
                    <asp:Button ID="LinkButton4" runat="server"  CssClass="form-control btn-primary" Text="Delete" CommandName="delete"/>
                </ItemTemplate>
                    </asp:TemplateField>
            </Columns>
        </asp:GridView>
                           

                           </div>

                    </div>
            </div><!--/.col (right) -->
          </div>   <!-- /.row -->
        </section><!-- /.content -->
      </div><!-- /.content-wrapper -->
</asp:Content>

