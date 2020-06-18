<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="anasayfa.aspx.cs" Inherits="UrunTakipSistemii.anasayfa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 400px">
            <asp:Label ID="Label1" runat="server" BackColor="#CCFFFF" Font-Bold="True" Font-Size="50pt" ForeColor="Blue" Text="MENU"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Menu ID="Menu1" runat="server" BackColor="#00CCFF" Font-Bold="True" Font-Italic="True" Font-Size="30pt">
                <Items>
                    <asp:MenuItem NavigateUrl="~/urunekle.aspx" Text="Ürün Ekle" Value="Ürün Ekle"></asp:MenuItem>
                    <asp:MenuItem NavigateUrl="~/urunduzenle.aspx" Text="Ürün Düzenle" Value="Ürün Düzenle"></asp:MenuItem>
                </Items>
            </asp:Menu>
        </div>
    </form>
</body>
</html>
