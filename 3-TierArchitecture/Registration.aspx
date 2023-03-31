<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="_3_TierArchitecture.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <style>
        #div {
            width: 500px;
            margin-top: 100px;
        }

        #form1 {
            border: double;
            background-color: hotpink;
            width: 500px;
            height: 400px;
        }

        .auto-style1 {
            margin-left: 2px;
        }
    </style>


    <script src="Scripts/bootstrap.min.js"></script>
    <script type='text/javascript'>

        function notEmpty() {
            var FirstName, LastName, DateOfBirth, Male, Female, Email;
            FirstName = document.getElementById("txtfname").value;
            LastName = document.getElementById("txtlname").value;
            DateOfBirth = document.getElementById("txtdob").value;
            Male = document.getElementById('rbtnmale').checked;
            Female = document.getElementById('rbtnfemale').checked;
            Email = document.getElementById('txtemail').value;



            if (FirstName == '' && LastName == '' && DateOfBirth == '' && Male == '' && Female == '' && Email == '') {
                alert("Please enter your details");
                return false;
            }
            if (FirstName == '') {
                alert("Please Enter First Name");
                return false;
            }
            if (LastName == '') {
                alert("Please Enter LastName");
                return false;
            }

            if (DateOfBirth == "") {
                alert("Please Enter date of birth.");

                return false;
            }
            if ((Male == "") && (Female == "")) {
                alert("Please Select Gender");
                return false;
            }
            var test = /^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$/;
            if ((Email == '') && (test == '')) {
                alert("Please Enter valid   Email");
                Email.value = "";
                return false;
            }


        }
    </script>
</head>
<center>
    <body>
        <div>
            <form id="form1" runat="server">
                <div class="form-group">
                    <h1 align="center">REGISTRATION FORM</h1>
                    Enter FirstName:
           <asp:TextBox ID="txtfname" runat="server"></asp:TextBox><br />
                    <br />
                    Enter LastName:
            <asp:TextBox ID="txtlname" runat="server"></asp:TextBox><br />
                    <br />
                    DateOfBirth:
             <asp:TextBox ID="txtdob" Type="date" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    Gender:
            <asp:RadioButton ID="rbtnmale" GroupName="gender" runat="server" Text="Male" />
                    <asp:RadioButton ID="rbtnfemale" GroupName="gender" runat="server" Text="Female" /><br />
                    <br />
                    E-Mail:
            <asp:TextBox ID="txtemail" runat="server"></asp:TextBox><br />

                    <br />
                    <br />
                    <asp:Button ID="btnsubmit" runat="server" Text="Submit" OnClick="btnsubmit_Click" OnClientClick="return notEmpty()" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
           <asp:Button ID="btnreset" runat="server" Text="Reset" OnClick="btnreset_Click" />



                </div><br /><br /><br /><br /><br /><br />
                <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                

<%--                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="SqlDataSource1" CssClass="auto-style1" Height="182px" Width="372px" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
                        <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
                        <asp:BoundField DataField="DateOfBirth" HeaderText="DateOfBirth" SortExpression="DateOfBirth" />           
                        <asp:BoundField DataField="Gender" HeaderText="Gender" SortExpression="Gender" />
                        <asp:BoundField DataField="EMail" HeaderText="EMail" SortExpression="EMail" />                  
                    </Columns>
                    <FooterStyle BackColor="#990000" ForeColor="White" Font-Bold="True" />
                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                    <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                    <SortedAscendingCellStyle BackColor="#FDF5AC" />
                    <SortedAscendingHeaderStyle BackColor="#4D0000" />
                    <SortedDescendingCellStyle BackColor="#FCF6C0" />
                    <SortedDescendingHeaderStyle BackColor="#820000" />
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:RegisrationDBConnectionString %>" SelectCommand="SELECT [FirstName], [LastName], [DateOfBirth], [Gender], [EMail] FROM [Registration]"></asp:SqlDataSource>--%>

            </form>
        </div>

    </body>

</html>
