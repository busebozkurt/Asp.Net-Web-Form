<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="UIweb.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Telefon Rehberi Web Form</title>
    <link rel="stylesheet" href="style\girisStyle.css">
    <link href="resimler/favicon.png"  rel="Shortcut Icon"  type="image/x-icon"/>
    
</head>
<body>
    <form id="form1" runat="server">
    <div id="girisDiv" align="center"" > 
        <fieldset id="girisField" align="center">
            <legend><h3>Kullanıcı Girişi</h3></legend>
        <table  class="" style="        min-width
: 360px" >
            <tr>                
                <td>
                    <asp:TextBox ID="txt_KullaniciAdi" runat="server" placeholder="Kullanıcı Adı"></asp:TextBox>
                </td>
            </tr>
            <tr>               
                <td>
                    <asp:TextBox ID="txt_sifre" runat="server" placeholder="Şifre" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>               
                <td>
                    <asp:Button ID="btn_giris" runat="server" Text="Giriş" Style="width:100px" OnClick="btn_giris_Click" />
                </td>
            </tr>
                   <tr>               
                <td>
                   
                    <asp:Label ID="mesaj" runat="server"></asp:Label>
                   
                </td>
            </tr>
        </table>
        <br />
            </fieldset>
    
    </div>
    </form>
</body>
</html>
