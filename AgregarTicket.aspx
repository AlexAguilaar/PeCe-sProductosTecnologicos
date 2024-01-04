<%@ Page Title="" Language="C#" MasterPageFile="~/MPSitio.Master" AutoEventWireup="true" CodeBehind="AgregarTicket.aspx.cs" Inherits="PeCe_sProductosTecnologicos.Agregar_Ticket" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<h1>Información del cliente</h1>
    <table>
    <tr>
        <td><asp:Label ID="lblNombre" runat="server" Text="Ingrese su nombre"/></td>
        <td><asp:TextBox ID="txtNombre" runat="server"/></td>
    </tr>
    <tr>
        <td><asp:Label ID="lblRut" runat="server" Text="Ingrese su Rut" /></td>
        <td><asp:TextBox ID="txtRut" runat="server"/></td>
    </tr>
    <tr>
        <td><asp:Label ID="LabelTelefono" runat="server" Text="Ingrese su Telefono" /></td>
        <td><asp:TextBox ID="TextTelefono" runat="server"/></td>
    </tr>
    <tr>
        <td><asp:Label ID="lblEmail" runat="server" Text="Ingrese su Email"/></td>
        <td><asp:TextBox ID="txtEmail" runat="server" TextMode="Number"/></td>
    </tr>
    <tr>
        <td><asp:Label ID="lblPersonaEmpresa" runat="server" Text="El ticket es para un individuo o organizacion"/></td>
        <td><asp:DropDownList ID="ddlPersonaEmpresa" runat="server"/></td>
    </tr>
    <tr>
        <td><asp:Label ID="lblEsTodoPublico" runat="server" Text="Es para todo público" /></td>
        <td><asp:CheckBox ID="ckbEsTodoPublico" runat="server" Text="Todo público"/></td>
    </tr>
    <tr>
        <td><asp:Label ID="lblEnCartelera" runat="server" Text="Está en cartelera" /></td>
        <td><asp:CheckBox ID="ckbEnCartelera" runat="server" Text="En cartelera"/></td>
    </tr>
    <tr>
        <td><asp:Label ID="lblTieneSubtitulos" runat="server" Text="Tiene subtitulos" /></td>
        <td><asp:CheckBox ID="ckbTieneSubtitulos" runat="server" Text="Subtitulada"/></td>
    </tr>
    <tr>
        <td><asp:Label ID="lblFechaEstreno" runat="server" Text="Seleccione la fecha de estreno"/></td>
        <td><asp:Calendar ID="calFechaEstreno" runat="server" FirstDayOfWeek="Monday" DayNameFormat="Shortest" BackColor="White" BorderColor="#999999" CellPadding="4" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px">
            <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
            <NextPrevStyle VerticalAlign="Bottom" />
            <OtherMonthDayStyle ForeColor="#808080" />
            <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
            <SelectorStyle BackColor="#CCCCCC" />
            <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
            <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
            <WeekendDayStyle BackColor="#FFFFCC" />
            </asp:Calendar>
        </td>
    </tr>
    <tr>
        <td><asp:Button ID="btnAgregarPelicula" runat="server" Text="Agregar pelicula" OnClick="btnAgregarPelicula_Click"/></td>
    </tr>
</table>
</asp:Content>
