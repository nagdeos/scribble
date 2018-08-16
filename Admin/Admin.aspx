<%@ Page Title="Admin" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Admin.aspx.vb" Inherits="Admin_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <h2>Welcome to Admin Panel <asp:LoginName ID="LoginName1" runat="server" />.<br /></h2>
    <br />
    
     
    <div class="col-md-4">
        <div class="panel panel-default">
            <div class="panel-heading">Keyword Setting</div>
            <div class="panel-body">

                <asp:Button ID="Button1" runat="server" CssClass="btn btn-primary" PostBackUrl="~/Admin/KeywordMaster.aspx" Text="New Keyword" Width="120%" />

            </div>
        </div>
                          
    </div>   

     

    <div class="col-md-8">
        <div class="panel panel-default">
            <div class="panel-heading">Keywords List</div>
                <div class="panel-body">     
                <asp:ListView ID="ListView1" runat="server" DataSourceID="KeywordDS" DataKeyNames="KeywordID">
                        <AlternatingItemTemplate>
                            <li style="background-color: #FFFFFF;color: #284775;">
                               <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# Eval("KeywordID", "UpdateKeyword.aspx?KeywordID={0}") %>'>
                                Keyword Name:
                                <asp:Label ID="KeywordNameLabel" runat="server" Text='<%# Eval("KeywordName") %>' />
                                <br />
                                Rating:
                                <asp:Label ID="RatingLabel" runat="server" Text='<%# Eval("Rating") %>' />
                                <br /></asp:HyperLink>
                            </li>
                        </AlternatingItemTemplate>
                                              <ItemSeparatorTemplate>
<br />
                        </ItemSeparatorTemplate>
                        <ItemTemplate>
                            <li style="background-color: #E0FFFF;color: #333333;">
                                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# Eval("KeywordID", "UpdateKeyword.aspx?KeywordID={0}") %>'>
                                Keyword Name:
                                <asp:Label ID="KeywordNameLabel" runat="server" Text='<%# Eval("KeywordName") %>' />
                                <br />
                                Rating:
                                <asp:Label ID="RatingLabel" runat="server" Text='<%# Eval("Rating") %>' />
                                <br /></asp:HyperLink>
                            </li>
                        </ItemTemplate>
                       </asp:ListView>
                    
                
                </div>
        </div>
                  
                    
                    <asp:SqlDataSource ID="KeywordDS" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" SelectCommand="SELECT * FROM [AspNetKeywordMaster]"></asp:SqlDataSource>
                
                
                </div>
      
    
   
</asp:Content>