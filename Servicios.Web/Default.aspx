<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Servicios.Web.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>DATOS DEL INVENTARIO</h1>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="InventariosGridView" runat="server" Width="262px">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
