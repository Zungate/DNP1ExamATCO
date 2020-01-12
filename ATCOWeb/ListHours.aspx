<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListHours.aspx.cs" Inherits="ATCOWeb.WebForm1" %>

    <asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col">
            <label for="Date">Date</label>
            <asp:TextBox ID="Date" class="form-control" runat="server"></asp:TextBox>
        </div>
        <div class="col">
            <asp:Button ID="Check" class="btn btn-warning" runat="server" Text="Check" OnClick="Check_Click" />
        </div>
    </div>


<asp:GridView ID="gridView" runat="server"></asp:GridView>
        </asp:Content>

