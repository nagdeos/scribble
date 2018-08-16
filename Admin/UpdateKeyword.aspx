<%@ Page Title="Update Keyword" Language="VB" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeFile="UpdateKeyword.aspx.vb" Inherits="Admin_UpdateKeyword" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

 <br />
    <br />
     <div class="col-md-4">
        <div class="panel panel-default">
            <div class="panel-heading">Add New Keyword</div>
            <div class="panel-body">

                <asp:FormView ID="FormView1" runat="server" DataSourceID="KeywordUpdateDS" Width="419px">
                    <ItemTemplate>
                        Keyword Name:
                        <asp:TextBox ID="KeywordNameTextBox" runat="server" Text='<%# Bind("KeywordName") %>' CssClass="form-control" />
                        <asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server"
             ControlToValidate="KeywordNameTextBox"
                ErrorMessage="The Keyword field is required."
                    ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
        
                        <br />
                        Rating:
                        <asp:TextBox ID="RatingTextBox" runat="server" Text='<%# Bind("Rating") %>' CssClass="form-control"/>
                         <asp:RequiredFieldValidator id="RequiredFieldValidator2" runat="server"
             ControlToValidate="RatingTextBox"
                ErrorMessage="The Rating field is required."
                    ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator> </div>
                        <br />
                        <asp:Button ID="btnKeyword" runat="server" CssClass="btn btn-primary" OnClick="btnKeyword_Click" Text="Update Keyword" Width="35%" />
                        <asp:Button ID="btnRedirect" runat="server" OnClick="btnRedirect_Click" CssClass="btn btn-primary" Text="Go back" Width="35%" />
                       
                        
                    </ItemTemplate>
                </asp:FormView>
                <asp:SqlDataSource ID="KeywordUpdateDS" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" SelectCommand="SELECT [KeywordName], [Rating] FROM [AspNetKeywordMaster] WHERE ([KeywordID] = @KeywordID)">
                    <SelectParameters>
                        <asp:Parameter DefaultValue="@KeywordID" Name="KeywordID" Type="Int32" />
                    </SelectParameters>
                </asp:SqlDataSource>
                <br />
                
                <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
            </div>
        </div>
    </div>


    
</asp:Content>
