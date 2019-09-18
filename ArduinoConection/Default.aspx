<%@ Page  Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ArduinoConection._Default" %>

<!DOCTYPE html>
 
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>RGB Arduino</title>
    <style type="text/css">
        .Panel
        {
            margin-left: 2%;
            margin-top: 2%;
            border-color: khaki;
            border-width: 20px;
        }
        .Header
        {
            font-family: "Segoe UI";
            font-size: xx-large;
            font-weight: normal;
            font-style: italic;
            font-variant: normal;
            text-transform: none;
            color: #DC143C;
        }
        .Sub
        {
            font-family: "Segoe UI";
            font-size: x-large;
            font-weight: normal;
            font-style: normal;
            font-variant: normal;
            text-transform: none;
            color: #666666;
        }
        </style>
</head>
<body bgcolor="#CCCCCC">
    <form id="form1" runat="server">
      <asp:Panel ID="Panel1" runat="server" BackColor="White" BorderStyle="Solid"
            Width="571px" CssClass="Panel">
        <div style="width: 578px">
        <span class="Header">Control Led RGB con Arduino.<br /> </span>
        <span class="Sub">Seleccionar Color.<asp:Panel ID="Panel2" runat="server">
            </asp:Panel>
            <asp:Label ID="Label1" runat="server" Height="30px" Text="RGB" Width="200px"></asp:Label>
            <asp:Button ID="Button66" runat="server" Height="19px" Text="Guardar" Width="70px" />
            <br /> </span>
        
            

            <asp:Button ID="Button54" runat="server" BackColor="Red" Height="67px" OnClick="Button54_Click" Width="183px" 
                
                />
            <asp:Button ID="Button55" runat="server" BackColor="#005500" Height="67px" OnClick="Button55_Click" Width="183px" />
            <asp:Button ID="Button56" runat="server" BackColor="Blue" Height="67px" OnClick="Button56_Click" Width="183px" />
            <asp:Button ID="Button57" runat="server" BackColor="MediumSpringGreen" Height="67px" OnClick="Button57_Click" Width="183px" />
            <asp:Button ID="Button58" runat="server" BackColor="Chartreuse" Height="67px" OnClick="Button58_Click" Width="183px" />
            <asp:Button ID="Button59" runat="server" BackColor="Turquoise" Height="67px" OnClick="Button59_Click" Width="183px" />
            <asp:Button ID="Button60" runat="server" BackColor="DarkOrange" Height="67px" OnClick="Button60_Click" Width="183px" />
            <asp:Button ID="Button61" runat="server" BackColor="Khaki" Height="67px" OnClick="Button61_Click" Width="183px" />
            <asp:Button ID="Button62" runat="server" BackColor="Maroon" Height="67px" OnClick="Button62_Click" Width="183px" />
            <asp:Button ID="Button63" runat="server" BackColor="Gold" Height="67px" OnClick="Button63_Click" Width="183px" />
            <asp:Button ID="Button64" runat="server" BackColor="DeepPink" Height="67px" OnClick="Button64_Click" Width="183px" />
            <asp:Button ID="Button65" runat="server" BackColor="LightCoral" Height="67px" OnClick="Button65_Click" Width="183px" />
        
            

        </div>
      </asp:Panel>
    </form>
</body>
</html>
