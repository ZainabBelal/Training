<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="CodeBased_7ASP.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>Validations</title>
</head>
<body>
    <form id="form1" runat="server">
   Registration Form
        <br /><br />
    Name : &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Width="160px"></asp:TextBox>

             <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"  

                 ControlToValidate="txtname" ErrorMessage="Name Cannot be Blank" 

                 Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>

             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

             <br />

        Family Name : &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;

            <asp:TextBox ID="TextFamily" runat="server" Width="160px"></asp:TextBox>

             <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 

                 ControlToValidate="TextFamily" ErrorMessage="Family Name Cannot be Blank" 

                 Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>

             <br />

         Address : &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;

            <asp:TextBox ID="TextAddress" runat="server">             

            </asp:TextBox>

             <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 

                 ControlToValidate="TextAddress" ErrorMessage="Address Cannot be Blank" 

                 Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>

             <br />

         City : &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;

            <asp:TextBox ID="TextCity" runat="server">             

            </asp:TextBox>

             <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 

                 ControlToValidate="TextCity" ErrorMessage="City Name Cannot be Blank" 

                 Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>

             <br />

         Zipcode : &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;

            <asp:TextBox ID="TextZip" runat="server">             

            </asp:TextBox>

             <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 

                 ControlToValidate="TextZip" ErrorMessage="Zipcode Cannot be Blank" 

                 Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>

             <br />

        Phone : &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;

            <asp:TextBox ID="TextBox5" runat="server">             

            </asp:TextBox>

             <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 

                 ControlToValidate="txtPhone" ErrorMessage="Phone no. Cannot be Blank" 

                 Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>

             <br />

        Email  : &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;

            <asp:TextBox ID="txtmail" runat="server"></asp:TextBox>

            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtmail" ErrorMessage="Email is required" Font-Bold="True" ForeColor="Red" Display="Dynamic">*</asp:RequiredFieldValidator>

&nbsp;&nbsp;&nbsp;

            <br />
    </form>
</body>
</html>
