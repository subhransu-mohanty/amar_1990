<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeDetails.aspx.cs" Inherits="Asp3TireAppDemo.EmployeeDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Employee Details</title>
     <script type="text/javascript">

         function DeleteConfirm() {
             var Ans = confirm("Do you want to Delete Selected Employee Record?");
             if (Ans) {
                 return true;
             }
             else {
                 return false;
             }
         }
</script>  
    
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1 style="color:gray">Employee Details</h1>
<%--        <table style="border:5px solid red;width:100%">
            <tr >
                <td style="float:left;width:100px">
                    Searchby
                    <br />
                    <asp:DropDownList ID="drpSearch" runat="server">
                        <asp:ListItem Value="1">UserName</asp:ListItem>
                        <asp:ListItem Value="2">Salary</asp:ListItem>
                        <asp:ListItem Value="3">Age</asp:ListItem>
                        <asp:ListItem Value="4">Emailid</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td style="float:left;width:150px;">
                    Select Condition<br />
                    <asp:DropDownList ID="drpcondition" runat="server" width="110px">
                        <asp:ListItem Value="1">Contain In</asp:ListItem>
                        <asp:ListItem Value="2">Equal</asp:ListItem>
                        <asp:ListItem Value="3">Greater Than</asp:ListItem>
                        <asp:ListItem Value="4">Less Than</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td style="float:left;width:300px">
                    Search Text<br />
                <asp:TextBox ID="txtSearch" runat="server" Width="250px" style="border-radius:2px 4px;"></asp:TextBox>
                </td>
                <td style="float:left;width:300px">
                    <asp:Button ID="btnSubmit" CssClass="button" Text="Show" Height="40px" Width="100px"  runat="server" />
        
                </td>
            </tr>
        </table>--%>
    <asp:GridView ID="grdemp" runat="server" AutoGenerateColumns="false" DataKeyNames="EmpId"  Width="100%" >
        <Columns>
              <asp:TemplateField HeaderText="Delete">
                <ItemTemplate>
                    <asp:CheckBox ID="chkDel" runat="server" /> 
                    
                </ItemTemplate>
            </asp:TemplateField>
           <asp:TemplateField HeaderText="Emp id" Visible="false" >
               <ItemTemplate>   <%# Eval("Empid")%></ItemTemplate>
           </asp:TemplateField>
           <asp:TemplateField HeaderText="User Name">
               <ItemTemplate><%# Eval("UserName")%></ItemTemplate>
           </asp:TemplateField>
            <asp:TemplateField HeaderText="Email Id">
               <ItemTemplate><%# Eval("Emailid")%></ItemTemplate>
           </asp:TemplateField>
            <asp:TemplateField HeaderText="Address">
               <ItemTemplate><%# Eval("Address")%></ItemTemplate>
           </asp:TemplateField>
            <asp:TemplateField HeaderText="Age">
               <ItemTemplate><%# Eval("Age")%></ItemTemplate>
           </asp:TemplateField>
            <asp:TemplateField HeaderText="MobileNo">
               <ItemTemplate><%# Eval("MobileNo")%></ItemTemplate>
           </asp:TemplateField>
            <asp:TemplateField HeaderText="Salary">
               <ItemTemplate><%# Eval("Salary")%></ItemTemplate>
           </asp:TemplateField>
            <asp:TemplateField HeaderText="Company Name">
               <ItemTemplate><%# Eval("CompanyName")%></ItemTemplate>
           </asp:TemplateField>
            <asp:TemplateField HeaderText="Edit">
                <ItemTemplate>
                    <center>
                        <a href="Registration.aspx?mode=edit&empid=<%# Eval("EmpId")%> &status=Update" title="Edit">Edit</a>
                    </center>
                </ItemTemplate>
            </asp:TemplateField>
          
        </Columns>

        </asp:GridView>
        <br/ />
        <asp:Button ID="btnNew" runat="server" Text="New Registration" OnClick="btnNew_Click"  />
        <asp:Button ID="btndelete" runat="server" Text="Delete" OnClick="btndelete_Click" style="height: 26px"  />

    </div>
    </form>
</body>
</html>

