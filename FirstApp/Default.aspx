<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FirstApp.Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h2 style="text-align: center">Employee Info</h2>

    <table class="nav-justified">
        <tr>
            <td class="modal-sm" style="width: 292px">Employee Id</td>
            <td>
                <asp:TextBox ID="TBId" runat="server" Height="22px" Width="168px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 292px">Employee Name</td>
            <td>
                <asp:TextBox ID="TBName" runat="server" Width="167px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 292px">Employee Email</td>
            <td>
                <asp:TextBox ID="TBEmail" runat="server" Width="168px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 292px">&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 292px">&nbsp;</td>
            <td>
                <asp:Button ID="ButtonInsert" runat="server" OnClick="Button1_Click" Text="Insert" /> &nbsp;
                <asp:Button ID="ButtonUpdate" runat="server" OnClick="Button3_Click" Text="Update" /> &nbsp;
                <asp:Button ID="ButtonDelete" runat="server" OnClick="Button4_Click" Text="Delete" /> &nbsp;
                <asp:Button ID="ButtonSelect" runat="server" OnClick="Button5_Click" Text="Select" /> &nbsp;
                <asp:Button ID="ButtonClear" runat="server" Text="Clear" OnClick="ButtonClear_Click" />
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 292px">&nbsp;</td>
            <td>
                <asp:Label ID="LInfo" runat="server"></asp:Label>
            </td>
        </tr>
    </table>



</asp:Content>
