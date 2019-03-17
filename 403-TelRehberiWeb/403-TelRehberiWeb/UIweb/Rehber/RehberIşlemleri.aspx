<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RehberIşlemleri.aspx.cs" Inherits="UIweb.Rehber.RehberIşlemleri" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Rehber işlemleri bu sayfada gerçekleştirilecek</h1>
    </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" HeaderText="İşlemler" />
                <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" SortExpression="ID"  Visible="false" />
                <asp:BoundField DataField="Isim" HeaderText="İsim" SortExpression="Isim" />
                <asp:BoundField DataField="Soyisim" HeaderText="Soyisim" SortExpression="Soyisim" />
                <asp:BoundField DataField="TelefonNumarasi" HeaderText="Telefon Numarasi" SortExpression="TelefonNumarasi" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TelefonRehberiConnectionString %>" DeleteCommand="DELETE FROM [Rehber] WHERE [ID] = @ID" InsertCommand="INSERT INTO [Rehber] ([ID], [Isim], [Soyisim], [TelefonNumarasi]) VALUES (@ID, @Isim, @Soyisim, @TelefonNumarasi)" SelectCommand="SELECT * FROM [Rehber] ORDER BY [Isim]" UpdateCommand="UPDATE [Rehber] SET [Isim] = @Isim, [Soyisim] = @Soyisim, [TelefonNumarasi] = @TelefonNumarasi WHERE [ID] = @ID">
            <DeleteParameters>
                <asp:Parameter Name="ID" Type="Object" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="ID" Type="Object" />
                <asp:Parameter Name="Isim" Type="String" />
                <asp:Parameter Name="Soyisim" Type="String" />
                <asp:Parameter Name="TelefonNumarasi" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Isim" Type="String" />
                <asp:Parameter Name="Soyisim" Type="String" />
                <asp:Parameter Name="TelefonNumarasi" Type="String" />
                <asp:Parameter Name="ID" Type="Object" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </form>
</body>
</html>
