<%@ Page Title="Profile" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="ProfileSetting.aspx.vb" Inherits="Account_ProfileSetting" %>




<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


            <br />
             <br />
          <div class="col-md-4">
                          <div class="panel panel-default">
                         <div class="panel-heading">Edit Profile Image</div>
                             <div class="panel-body">

                    
                    <asp:Image ID="ProfileImage" CssClass="img img-responsive img-rounded img-thumbnail" runat="server" Height="200px" Width="200px"  />
                    <br />
                    <br />

                    
                    <asp:FileUpload ID="FileUpload" CssClass="btn btn-default" runat="server" />

                    
                    <br />
                    <asp:Button ID="btnPost" runat="server" OnClick="btnPost_Click" Width="30%" CssClass="btn btn-primary" Text="Post"></asp:Button>
                            
                    <br />
                    <br />

                    <asp:Label ID="lblImageUpload" runat="server"></asp:Label>
                                   </div>
            </div>
         </div>        
      
                
        <div class="col-md-8">
        <div class="panel panel-default">
            <div class="panel-heading">Edit Profile Details</div>
                <div class="panel-body">

                    <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
                    <asp:FormView ID="FormView1" runat="server" DataSourceID="DetailsDS" Width="709px">
                         <ItemTemplate>
                            <br />
                            UserName:
                            <asp:TextBox ID="UserNameTextBox" runat="server" Readonly="true" CssClass="form-control" Text='<%# Bind("UserName") %>'  Width="100%"/>
                            <br />
                            Name:
                            <asp:TextBox ID="NameTextBox" runat="server" CssClass="form-control" Text='<%# Bind("Name") %>' Width="100%" />
                            <br />
                            Email:
                            <asp:TextBox ID="EmailTextBox" runat="server" CssClass="form-control" Text='<%# Bind("Email") %>' Width="100%" />
                            <br />
                            Phone Number:
                            <asp:TextBox ID="PhoneNumberTextBox" runat="server" CssClass="form-control" Text='<%# Bind("PhoneNumber") %>' Width="100%" />
                            <br />
                            Gender:
                            <asp:TextBox ID="GenderTextBox" runat="server" CssClass="form-control" Text='<%# Bind("Gender") %>' Width="100%"/>
                            <br />
                            Date of Birth:
                            <asp:TextBox ID="DobTextBox" runat="server" CssClass="form-control" Text='<%# Bind("Dob") %>' Width="100%"/>
                            
                              <asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server"
             ControlToValidate="DobTextBox"
                ErrorMessage="Date of Birth Field is required."
                    ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator><br />
                            Education:
                            <asp:TextBox ID="EducationTextBox" runat="server" CssClass="form-control" Text='<%# Bind("Education") %>' Width="100%" />
                            <br />
                            Work Profile:
                            <asp:TextBox ID="WorkProfileTextBox" runat="server" CssClass="form-control" Text='<%# Bind("WorkProfile") %>' Width="100%" />
                            <br />
                            Interest:
                            <asp:TextBox ID="InterestTextBox" runat="server" CssClass="form-control" Text='<%# Bind("Interest") %>' Width="100%"/>
                            <br />
                            Status:
                            <asp:TextBox ID="statusTextBox" runat="server" CssClass="form-control" Height="100px" Text='<%# Bind("status") %>' Width="100%" Rows="4" TextMode="MultiLine"/>
                            <br />
                            <br />
                            <asp:Button ID="btnUpdateProfile" runat="server" CssClass="btn btn-primary" OnClick="btnUpdateProfile_Click" Text="Update Profile" Width="20%" />
                            &nbsp; &nbsp; &nbsp;
                            <asp:Button ID="btnRedirect" runat="server" CssClass="btn btn-primary" OnClick="btnRedirect_Click" Text="Go Back" Width="20%" />
                            
                            <br />
                      </ItemTemplate>
                    </asp:FormView>
         </div>        
      </div>
    </div> 
                        
                    <asp:SqlDataSource ID="DetailsDS" runat="server" ConnectionString="<%$ ConnectionStrings:ScribbleDBConnectionString1 %>" SelectCommand="SELECT UserName, Name, Email, PhoneNumber, Gender, Dob, Education, WorkProfile, Interest, status, ProfileImage FROM AspNetUsers WHERE (UserName = @UserName)">
                        <SelectParameters>
                            <asp:Parameter DefaultValue="UserName" Name="UserName" Type="String" />
                        </SelectParameters>
                    </asp:SqlDataSource>

                    <br />
                    
                   

                    
                 

</asp:Content>