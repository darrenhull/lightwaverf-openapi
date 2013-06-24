<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Heating.aspx.cs" MasterPageFile="~/Site.master"  Inherits="LightwaveSite.Heating" %>


<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">

    <p>
        <strong>Boiler Controls:</strong></p>
    <asp:Panel ID="Panel1" runat="server">
        Boiler:
        <asp:RadioButton ID="rbBoilerOn" runat="server" 
    AutoPostBack="True" oncheckedchanged="rbBoilerOn_CheckedChanged" Text="On" />
        <asp:RadioButton ID="rbBoilerOff" runat="server" 
    AutoPostBack="True" oncheckedchanged="rbBoilerOff_CheckedChanged" Text="Off" />
        <br />
        HotWater
        <asp:RadioButton ID="rbHotWaterOn" runat="server" AutoPostBack="True" 
            oncheckedchanged="rbHotWaterOn_CheckedChanged" Text="On" />
        <asp:RadioButton ID="rbHotWaterOff" runat="server" AutoPostBack="True" 
            oncheckedchanged="rbHotWaterOff_CheckedChanged" Text="Off" />
    </asp:Panel>
    <strong>
    <br />
    Radiator Controls:<br />
    </strong>
    <br />
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
    Radiator:<br />
<asp:RadioButton ID="rbOn" runat="server" Text="On" AutoPostBack="True" 
        oncheckedchanged="rbOn_CheckedChanged" />
<asp:RadioButton ID="rbOff" runat="server" Text="Off" AutoPostBack="True" 
        oncheckedchanged="rbOff_CheckedChanged" />
    <br />
    <br />
    Response: 
    <asp:Label ID="lblResponse" runat="server"></asp:Label>
    
</asp:Content>
