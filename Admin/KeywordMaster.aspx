<%@ Page Title="KeywordMaster" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="KeywordMaster.aspx.vb" Inherits="Admin_KeywordMaster" %>

<asp:Content ID="pKeywordMaster" ContentPlaceHolderID="MainContent" runat="server">
   
    <br />
    <br />
     <div class="col-md-4">
        <div class="panel panel-default">
            <div class="panel-heading">Add New Keyword</div>
            <div class="panel-body">

                
    <div class="form-group">
                        <asp:Label runat="server" CssClass="col-md-2 control-label">Keyword</asp:Label>
                        <asp:TextBox ID="TxtKeyword" runat="server" CssClass="form-control"></asp:TextBox>
        <asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server"
             ControlToValidate="TxtKeyword"
                ErrorMessage="The Keyword field is required."
                    ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                        
         </div>                      
                        
                    
    <div class="form-group">
                <asp:Label runat="server" CssClass="col-md-2 control-label">Rating</asp:Label>
                 
                 <asp:TextBox ID="TxtRating" runat="server" CssClass="form-control" ></asp:TextBox>
        <asp:RequiredFieldValidator id="RequiredFieldValidator2" runat="server"
             ControlToValidate="TxtRating"
                ErrorMessage="The Rating field is required."
                    ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator> </div>  
    <div class="form-group">
                       
                        &nbsp;<asp:Button ID="btnAdd" runat="server" CssClass="btn btn-primary" Text="Add" Width="35%" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnRedirect" runat="server" CssClass="btn btn-primary" Text="Go back" Width="35%" />
                        <br />
                        <br />
                        <asp:Label ID="lblResult" runat="server"></asp:Label>
    </div>
            </div>
        </div>
                          
    </div>        
                
</asp:Content>