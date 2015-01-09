<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeUI.aspx.cs" Inherits="DepartmentEmployeeWebApp.UI.EmployeeUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr>
            <td>
                Department:
            </td>
            <td>
                <asp:DropDownList ID="departmentDropdownList" runat="server" OnSelectedIndexChanged="departmentDropdownList_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                Employee:
            </td>
            <td>
                <asp:DropDownList ID="employeeDropdownList" runat="server"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>

            </td>
            <td>
                <asp:Button ID="confirmButton" runat="server" Text="Confirm" OnClick="confirmButton_Click" />
            </td>
         </tr>        
    </table>
    </div>
    </form>
</body>
</html>
