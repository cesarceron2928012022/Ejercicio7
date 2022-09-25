<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio7.aspx.cs" Inherits="Ejercicio7.Ejercicio7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" style="display:flex;justify-content:center;">
        <div style="width:250px;margin:0 0 0 1rem">
            <asp:Panel ID="Panel1" runat="server"></asp:Panel>            
        </div>
        <div style="width:50%;margin:10px 0 0 50px">
            <asp:Label ID="LblData" runat="server" Text="Label" Visible="False"></asp:Label>
        </div>        
    </form>    
</body>
</html>
