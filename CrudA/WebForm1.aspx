<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CrudA.WebForm1" %>

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
					<td>Name:</td>
					<td><asp:TextBox ID="txt1" runat="server"></asp:TextBox></td>

				</tr>
				<tr>
					<td>Blood Group:</td>
					<td><asp:RadioButtonList ID="rbl1" runat="server" RepeatColumns="7">
					

					    </asp:RadioButtonList></td>

				</tr>
				<tr>
					<td>Course:</td>
					<td><asp:DropDownList ID="ddl1" runat="server">
						
					    </asp:DropDownList></td>

				</tr>
				<tr>
					<td></td>
					<td>
						<asp:Button ID="btnsave" runat="server" Text="save" OnClick="btnsave_Click" />
					</td>
				</tr>

				<tr>
					<td></td>
					<td>
						<asp:GridView ID="grid1" runat="server"></asp:GridView>
					</td>

				</tr>
			</table>
        </div>
    </form>
</body>
</html>
