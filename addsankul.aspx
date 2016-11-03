<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="addsankul.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <div class="content-wrapper">
        <!-- Content Header (Page header) -->
        <section class="content-header">
          <h1>
          Add Sankul
            <small>Preview</small>
          </h1>
          <ol class="breadcrumb">
            <li><a href="DashBoard.aspx"><i class="fa fa-dashboard"></i> Home</a></li>
           
            <li class="active">Add Sankul</li>
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
                      <label for="exampleInputEmail1">Sankul Code : </label>
                     <asp:TextBox runat="server" class="form-control" id="TextBox1" placeholder="Enter Sankul Code"></asp:TextBox>
                    </div>

                       <div class="form-group">
                    <label>sankul Name:</label>
                  
                     
                     <asp:TextBox runat="server" class="form-control" id="TextBox2" placeholder="Enter Sankul Name"></asp:TextBox>
                    
                  </div><!-- /.form group -->

                     
 <div class="form-group">
<asp:Button ID="btn_save" CssClass="form-control btn-primary" name="btn_save"  runat="server" Text="save" OnClick="Button1_Click"  />
                    </div>

                               <div class="box-body">
                            

                               <asp:GridView ID="GridView1"  class="col-md-12 table" runat="server" AutoGenerateColumns="False" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowEditing="GridView1_RowEditing" OnRowDeleting="GridView1_RowDeleting" OnRowUpdating="GridView1_RowUpdating"  >
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

                <asp:TemplateField HeaderText="Sankul code">
                    <ItemTemplate>
                        <asp:Label ID="lb2" runat="server" Text='<%# Eval("sankul_code") %>' />
               
                        </ItemTemplate>
                    <EditItemTemplate>
                     <%--  <asp:TextBox ID="txtsankul_code" runat="server" Width="120px" Text='<%# Eval("sankul_code") %>'></asp:TextBox>--%>
                            <asp:Label ID="lbcode" runat="server" Text=' <%# Eval("sankul_code") %>'></asp:Label>
                    </EditItemTemplate>
                </asp:TemplateField>


                <asp:TemplateField HeaderText="Sankul Name">
                     <ItemTemplate>
                   <%# Eval("sankul_name") %>
                        </ItemTemplate>
                    <EditItemTemplate>
                      <asp:TextBox ID="txtsankul_name" runat="server" Width="120px" Text='<%# Eval("sankul_name") %>'></asp:TextBox>
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
                    <asp:Button ID="LinkButton4" runat="server" CssClass="form-control btn-primary" Text="Delete" CommandName="delete"/>
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




