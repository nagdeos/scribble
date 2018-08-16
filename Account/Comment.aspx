<%@ Page Title="Comment" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="Comment.aspx.vb" Inherits="Account_Comment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

    

    <br />
    <br />
                                    <div class="col-md-4">
                                         <div class="panel panel-default">
                 
                                <asp:ListView ID="FormView1" runat="server" DataSourceID="StoryDS" DataKeyNames="StoryID">
                                
                                
                                <ItemTemplate>
                                <div class="panel-heading"><%# Eval("Name") %>'s Story</div>
                                <div class="panel-body">
                                <asp:Image ID="StoryLabel" runat="server" Height="200px" Width="200px" CssClass="img img-responsive img-rounded img-thumbnail" ImageUrl='<%#"data:Image/png;base64," + Convert.ToBase64String((Eval("Story"))) %>' /><br />
                                <br /><asp:TextBox ID="CaptionLabel" Readonly="true" CssClass="form-control"  Rows="4" Height="50px" Width="100%" TextMode="MultiLine" runat="server" Text='<%# Eval("Caption") %>' /><br />
                                Opinion: <asp:Label ID="OpinionLabel" runat="server" Text='<%# Eval("Opinion") %>' /><br />
                                   

                                </span>
                                    </div>
                                </ItemTemplate>
                                </asp:ListView><asp:SqlDataSource ID="StoryDS" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" SelectCommand="SELECT AspNetUsers.Name, AspNetStory.StoryID, AspNetStory.Story, AspNetStory.Caption, AspNetStory.Date, AspNetStory.Opinion FROM AspNetUsers INNER JOIN AspNetStory ON AspNetUsers.UserName = AspNetStory.UserName WHERE ([StoryID] = @StoryID)">
                                    <SelectParameters>
                                        <asp:QueryStringParameter Name="StoryID" QueryStringField="StoryID" Type="Int32" />
                                    </SelectParameters>
                                </asp:SqlDataSource>
                                    <div class="panel-body">
                                    <asp:TextBox ID="txtComment" Placeholder="Comment" CssClass="form-control" Height="100px" Rows="4" TextMode="MultiLine" Width="100%" runat="server"></asp:TextBox>
                                    <br />
                                    <asp:Button ID="btnAddComment" Cssclass="btn btn-primary" runat="server" onClick="btnAddComment_Click" Width="50%" Text="Post Comment" />
                                    <br />
                                   <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
                                    </div>
            </div>
        </div>
    
       

    <div class="col-md-8">
        <div class="panel panel-default">
            <div class="panel-heading">Comment Slate</div>
            <div class="panel-body">   


                <asp:ListView ID="ListView2" runat="server" DataSourceID="CommentDS">
                    <AlternatingItemTemplate>
                        <span style="background-color: #FFF8DC;">
                        
                        <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
                        <br />
                        
                        
                        
                        <asp:Label ID="CommentLabel" runat="server" Text='<%# Eval("Comment") %>' />
                        <br />
                        <br /></span>
                    </AlternatingItemTemplate>
                    <ItemTemplate>
                        <span style="background-color: #DCDCDC;color: #000000;">
                       
                        <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
                        <br />
                         <asp:Label ID="CommentLabel" runat="server" Text='<%# Eval("Comment") %>' />
                        <br />
<br /></span>
                    </ItemTemplate>
                </asp:ListView>
                <asp:SqlDataSource ID="CommentDS" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" SelectCommand="SELECT AspNetUsers.Name, AspNetComment.Comment FROM AspNetUsers INNER JOIN AspNetComment ON AspNetUsers.UserName = AspNetComment.CommentedBy WHERE ([StoryID] = @StoryID) ORDER BY [CommentID]">
                    <SelectParameters>
                        <asp:QueryStringParameter Name="StoryID" QueryStringField="StoryID" Type="Int32" />
                    </SelectParameters>
                </asp:SqlDataSource>


                </div>
            </div>
        </div>




</asp:Content>

