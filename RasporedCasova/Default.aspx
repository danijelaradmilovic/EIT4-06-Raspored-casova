<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="RasporedCasova._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
   Razred: <asp:DropDownList ID="ddlRazred" runat="server" AutoPostBack="True" 
        onselectedindexchanged="ddlRazred_SelectedIndexChanged">
</asp:DropDownList>
    <br />
   Smena: <asp:DropDownList ID="ddlSmena" runat="server" AutoPostBack="True">
</asp:DropDownList>

<asp:Button ID="btnPrikazi" runat="server" Text="Prikaži raspored" 
        onclick="btnPrikazi_Click" />
<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
    <Columns>
        <asp:BoundField DataField="Dan" HeaderText="Dan" />
        <asp:BoundField DataField="RedniBroj" HeaderText="Redni broj časa" />
        <asp:BoundField  DataField="NazivPredmeta" HeaderText="Naziv predmeta"  />
    </Columns>
</asp:GridView>

</asp:Content>

