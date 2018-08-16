<%@ Page Title="Profile" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="false" CodeFile="Profile.aspx.vb" Inherits="Account_Profile" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <br />
    <br />
    
    
    <asp:FormView ID="FormView1" runat="server" DataSourceID="ProfileDS" Width="1094px">           
     <ItemTemplate>
    
    <div class="col-md-4">
        <div class="panel panel-default">
            <div class="panel-heading"><asp:Label ID="UserNameLabel1" runat="server" Text='<%# Bind("UserName") %>' />'s Profile Picture&nbsp;<asp:HyperLink ID="hlEditProfileImage" runat="server"  NavigateUrl='<%# Eval("UserName", "ProfileSetting.aspx?UserName={0}") %>'><span class="glyphicon glyphicon-pencil"></span></asp:HyperLink></div>
            <div class="panel-body">  
                    <asp:Image ID="ProfileImage" CssClass="img img-responsive img-rounded img-thumbnail" runat="server" Width="200px" Height="200px" ImageUrl='<%# "data:Image/png;base64," + Convert.ToBase64String(Eval("ProfileImage")) %>'/>
            </div>
        </div>
    </div>
     <div class="col-md-8">
        <div class="panel panel-default">
            <div class="panel-heading"><asp:Label ID="UserNameLabel" runat="server" Text='<%# Bind("UserName") %>' />'s Profile Details
                        &nbsp;<asp:HyperLink ID="hlEdit" runat="server"  NavigateUrl='<%# Eval("UserName", "ProfileSetting.aspx?UserName={0}") %>'><span class="glyphicon glyphicon-pencil"></span></asp:HyperLink></div>
            <div class="panel-body">
                                            
                        UserName:
                        <asp:TextBox ID="UserNameTextBox" runat="server" CssClass="form-control" ReadOnly="true" Width="100%" Text='<%# Bind("UserName") %>' />
                        <br />
                        Name:
                        <asp:TextBox ID="NameTextBox" runat="server" CssClass="form-control" ReadOnly="true" Width="100%" Text='<%# Bind("Name") %>' />
                        <br />
                        Gender:
                        <asp:TextBox ID="GenderTextBox" runat="server" CssClass="form-control" ReadOnly="true" Width="100%" Text='<%# Bind("Gender") %>' />
                        <br />
                        Email:
                        <asp:TextBox ID="EmailTextBox" runat="server" CssClass="form-control" ReadOnly="true" Width="100%" Text='<%# Bind("Email") %>' />
                        <br />
                        Phone Number:
                        <asp:TextBox ID="PhoneNumberTextBox" runat="server" CssClass="form-control" ReadOnly="true" Width="100%" Text='<%# Bind("PhoneNumber") %>' />
                        <br />
                        Date of Birth:
                        <asp:TextBox ID="DobTextBox" runat="server" CssClass="form-control" ReadOnly="true" Width="100%" Text='<%# Bind("Dob") %>' />
                        <br />
                        Education:
                        <asp:TextBox ID="EducationTextBox" runat="server" CssClass="form-control" ReadOnly="true" Width="100%" Text='<%# Bind("Education") %>' />
                        <br />
                        Work Profile:
                        <asp:TextBox ID="WorkProfileTextBox" runat="server" CssClass="form-control" ReadOnly="true" Width="100%" Text='<%# Bind("WorkProfile") %>' />
                        <br />
                        Interest:
                        <asp:TextBox ID="InterestTextBox" runat="server" CssClass="form-control" ReadOnly="true" Width="100%" Text='<%# Bind("Interest") %>' />
                        <br />
                        Status:
                        <asp:TextBox ID="statusTextBox" runat="server" CssClass="form-control" Height="100px" ReadOnly="true" Width="100%" Rows="4" TextMode="MultiLine" Text='<%# Bind("status") %>' />
                        <br />
              </div>
        </div>
    </div>
    
                    </ItemTemplate>
                    
                            
    </asp:FormView>
    <asp:SqlDataSource ID="ProfileDS" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" SelectCommand="SELECT UserName, Name, Gender, Email, PhoneNumber, Dob, Education, WorkProfile, Interest, status, ProfileImage FROM AspNetUsers WHERE (UserName = @UserName)">
                    <SelectParameters>
                        <asp:Parameter DefaultValue="UserName" Name="UserName" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
                
    


</asp:Content>