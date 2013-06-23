<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="LightwaveSite._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    Room:
<asp:DropDownList ID="cmbRoom" runat="server" AutoPostBack="True" 
        onselectedindexchanged="cmbRoom_SelectedIndexChanged">
    <asp:ListItem>0</asp:ListItem>
    <asp:ListItem>1</asp:ListItem>
    <asp:ListItem>2</asp:ListItem>
    <asp:ListItem>3</asp:ListItem>
    <asp:ListItem>4</asp:ListItem>
    <asp:ListItem>5</asp:ListItem>
    <asp:ListItem>6</asp:ListItem>
    <asp:ListItem>7</asp:ListItem>
</asp:DropDownList>
<br />
Device:<asp:DropDownList ID="cmbDevice" runat="server" 
    onselectedindexchanged="cmbDevice_SelectedIndexChanged" AutoPostBack="True">
    <asp:ListItem>0</asp:ListItem>
    <asp:ListItem>1</asp:ListItem>
    <asp:ListItem>2</asp:ListItem>
    <asp:ListItem>3</asp:ListItem>
    <asp:ListItem>4</asp:ListItem>
    <asp:ListItem>5</asp:ListItem>
    <asp:ListItem>6</asp:ListItem>
    <asp:ListItem>7</asp:ListItem>
</asp:DropDownList>
<br />
<asp:RadioButton ID="rbOn" runat="server" Text="On" AutoPostBack="True" 
        oncheckedchanged="rbOn_CheckedChanged" />
<asp:RadioButton ID="rbOff" runat="server" Text="Off" AutoPostBack="True" 
        oncheckedchanged="rbOff_CheckedChanged" />
<asp:RadioButton ID="rbOpen" runat="server" Text="Open" AutoPostBack="True" 
        oncheckedchanged="rbOpen_CheckedChanged" />
<asp:RadioButton ID="rbClose" runat="server" Text="Close" AutoPostBack="True" 
        oncheckedchanged="rbClose_CheckedChanged" />
<asp:RadioButton ID="rbStop" runat="server" Text="Stop" AutoPostBack="True" 
        oncheckedchanged="rbStop_CheckedChanged" />
    <br />
    Dim: 
    <asp:DropDownList ID="cmbDim" runat="server" 
    onselectedindexchanged="cmbDim_SelectedIndexChanged" AutoPostBack="True">
    <asp:ListItem>0</asp:ListItem>
    <asp:ListItem>10</asp:ListItem>
    <asp:ListItem>20</asp:ListItem>
    <asp:ListItem>30</asp:ListItem>
    <asp:ListItem>40</asp:ListItem>
    <asp:ListItem>50</asp:ListItem>
    <asp:ListItem>60</asp:ListItem>
    <asp:ListItem>70</asp:ListItem>
        <asp:ListItem>80</asp:ListItem>
        <asp:ListItem>90</asp:ListItem>
        <asp:ListItem>100</asp:ListItem>
</asp:DropDownList>
    <br />
    <br />
    Response: 
    <asp:Label ID="lblResponse" runat="server"></asp:Label>
    <br />
</asp:Content>
