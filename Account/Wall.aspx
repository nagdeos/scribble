<%@ Page Title="Wall" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="Wall.aspx.vb" Inherits="Account_Wall" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" Runat="Server">

    <br />
    <br />

    <div class="col-md-4">
                        <div class="panel panel-default">
                            <div class="panel-heading">Add Story</div><div class="panel-body">
                                

                                <asp:Image ID="Image" runat="server" CssClass="img img-responsive img-" Height="100px" Width="100px" />
                                <br /><asp:TextBox ID="txtCaption" runat="server" Placeholder="Caption" Height="50px" CssClass="form-control" Rows="4" TextMode="MultiLine" Width="100%"></asp:TextBox><br />
                                <asp:FileUpload ID="FileUpload" runat="server" CssClass="btn btn-default" /><br />
                                <asp:Button ID="btnPost" runat="server" CssClass="btn btn-primary" Width="100%" Text="Post" />
                                <br />
                                <br />
                                <asp:Label ID="lblResult" runat="server"></asp:Label>

  </div></div></div>
                    
 <div class="col-md-8">
        <div class="panel panel-default">
            <div class="panel-heading">Slate</div><div class="panel-body">     
                                <asp:ListView ID="ListView2" runat="server" DataSourceID="StoryDS">
                                
                                <ItemTemplate>
                                <span style="background-color: #FFFFFF;color: #284775;">
                                <asp:Label ID="NameLabel" runat="server" Font-Bold="true" Text='<%# Eval("Name") %>' /><br />
                                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# Eval("StoryID", "Comment.aspx?StoryID={0}") %>'><asp:Image ID="StoryLabel" runat="server" Height="200px" Width="200px" CssClass="img img-responsive img-rounded img-thumbnail" ImageUrl='<%#"data:Image/png;base64," + Convert.ToBase64String((Eval("Story"))) %>' /><br /></asp:HyperLink>
                                <asp:Label ID="CaptionLabel" Font-Bold="true" runat="server" Text='<%# Eval("Caption") %>' /><br />
                                <asp:Label ID="DateLabel" runat="server" Text='<%# Eval("Date") %>' /><br />
                                Opinion: <asp:Label ID="OpinionLabel" Font-Bold="true" runat="server" Text='<%# Eval("Opinion") %>' /><br />
                                <br /></span>
                                </ItemTemplate>
                                </asp:ListView><asp:SqlDataSource ID="StoryDS" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" SelectCommand="SELECT AspNetUsers.Name, AspNetStory.StoryID, AspNetStory.Story, AspNetStory.Caption, AspNetStory.Date, AspNetStory.Opinion FROM AspNetUsers INNER JOIN AspNetStory ON AspNetUsers.UserName = AspNetStory.UserName">
                                </asp:SqlDataSource></div>

        </div>

 </div>

</asp:Content>