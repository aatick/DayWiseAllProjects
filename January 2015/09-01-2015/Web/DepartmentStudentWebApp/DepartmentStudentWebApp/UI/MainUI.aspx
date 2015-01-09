<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainUI.aspx.cs" Inherits="DepartmentEmployeeWebApp.UI.MainUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="StyleSheet.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr>
            <td>
                Department
            </td>
            <td>
                <asp:DropDownList ID="departmentDropdownList" runat="server"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                First Name
            </td>
            <td>
                <asp:TextBox ID="firstnameTextBox" runat="server" OnTextChanged="firstnameTextBox_TextChanged"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Address
            </td>
            <td>
                <asp:TextBox ID="addressTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Phone Number
            </td>
            <td>
                <asp:TextBox ID="phoneTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>        
    </table>
        <ul id="menu" style="list-style-type:none;">
            <li style="display:inline">
                <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" />
            </li>
            <li style="display:inline">
                <asp:Button ID="makeConfirmation" runat="server" Text="Make Confirmation" OnClick="makeConfirmation_Click" />
            </li>
        </ul>
    </div>
    </form>
</body>
</html>
