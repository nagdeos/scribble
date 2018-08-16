<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="EditStory.aspx.vb" Inherits="Account_EditStory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

  <br />
             <br />
          <div class="col-md-4">
                          <div class="panel panel-default">
                         <div class="panel-heading">Edit Story</div>
                             <div class="panel-body">

                    <asp:ListView ID="lv" runat="server" DataSourceID="StoryDS" DataKeyNames="StoryID">
                                
                                
                                <ItemTemplate>
                                
                    <asp:Image ID="ProfileImage" CssClass="img img-responsive img-rounded img-thumbnail" runat="server" Height="200px" Width="200px" ImageUrl='<%#"data:Image/png;base64," + Convert.ToBase64String((Eval("Story"))) %>' />
                    <br />
                    <br />
                    <br /><asp:TextBox ID="CaptionTextBox" CssClass="form-control"  Rows="4" Height="50px" Width="100%" TextMode="MultiLine" runat="server" Text='<%# Eval("Caption") %>' /><br />
                    Opinion: <asp:Label ID="OpinionLabel" runat="server" Text='<%# Eval("Opinion") %>' /><br />
                                
                    
                     </ItemTemplate>
                        </asp:ListView>
                                <asp:SqlDataSource ID="StoryDS" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" SelectCommand="SELECT AspNetUsers.Name, AspNetStory.StoryID, AspNetStory.Story, AspNetStory.Caption, AspNetStory.Opinion FROM AspNetUsers INNER JOIN AspNetStory ON AspNetUsers.UserName = AspNetStory.UserName WHERE ([StoryID] = @StoryID)">
                                    <SelectParameters>
                                        <asp:QueryStringParameter Name="StoryID" QueryStringField="StoryID" Type="Int32" />
                                    </SelectParameters>
                                </asp:SqlDataSource>
                    <asp:FileUpload ID="FileUpload" CssClass="btn btn-default" runat="server" />

                    
                    <br />
                    <asp:Button ID="btnPost" runat="server" OnClick="btnPost_Click" Width="30%" CssClass="btn btn-primary" Text="Post"></asp:Button>
                            
                    <br />
                    <br />

                    <asp:Label ID="lblImageUpload" runat="server"></asp:Label>
                    
                                    </div>

            </div>
         </div>      
        
         

</asp:Content>

