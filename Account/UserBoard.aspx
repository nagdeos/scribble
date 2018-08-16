<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="UserBoard.aspx.vb" Inherits="Account_UserBoard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">


    <br />
    <br />
    <div  class="col-md-8">
        <div class="panel panel-default">
            <div class="panel-heading">User Board</div>
            <div class="panel-body">

                 <asp:ListView ID="ListView1" runat="server" DataSourceID="UserDS">
                    <AlternatingItemTemplate>
                        <span style="background-color: #FFFFFF;color: #284775;">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# Eval("UserName", "Profile.aspx?UserName={0}") %>'><asp:Label ID="NameLabel" runat="server" Font-Bold="true" Text='<%# Eval("Name") %>' />
                        <br /><asp:Image ID="ProfileImage" runat="server" CssClass="img img-responsive img-rounded img-thumbnail" Height="50px" Width="50px"  ImageUrl='<%# "data:Image/png;base64," + Convert.ToBase64String(Eval("ProfileImage")) %>' />
                       </asp:HyperLink> <br />
                        <h5>Status:</h5><asp:Label ID="statusLabel" Font-Bold="true" runat="server" Text='<%# Eval("status") %>' />
                        <br />
<br /></span>
                    </AlternatingItemTemplate>
                    <ItemTemplate>
                        <span style="background-color: #E0FFFF;color: #333333;">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# Eval("UserName", "Profile.aspx?UserName={0}") %>'><asp:Label ID="NameLabel" runat="server" Font-Bold="true" Text='<%# Eval("Name") %>' />
                        <br /><asp:Image ID="ProfileImage" CssClass="img img-responsive img-rounded img-thumbnail" runat="server" Height="50px" Width="50px" ImageUrl='<%# "data:Image/png;base64," + Convert.ToBase64String(Eval("ProfileImage")) %>' />
                       </asp:HyperLink> <br />
                        <h5>Status:</h5><asp:Label ID="statusLabel" runat="server" Font-Bold="true" Text='<%# Eval("status") %>' />
                        <br />
<br /></span>
                    </ItemTemplate>
                </asp:ListView>
                <asp:SqlDataSource ID="UserDS" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" SelectCommand="SELECT [UserName], [Name], [ProfileImage], [status] FROM [AspNetUsers]"></asp:SqlDataSource>

               
                
            </div>
        </div>
                          
    </div>   


</asp:Content>

