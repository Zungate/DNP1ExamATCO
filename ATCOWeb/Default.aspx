<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ATCOWeb._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col">
            <label for="Name">Name</label>
            <asp:TextBox ID="Name" class="form-control" runat="server"></asp:TextBox>
        </div>
        <div class="col">
            <label for="Id">Id</label>
            <asp:TextBox ID="Id" class="form-control" runat="server"></asp:TextBox>
        </div>
        <div class="col">
            <label for="CertId">Cert Id</label>
            <asp:TextBox ID="CertId" class="form-control" runat="server"></asp:TextBox>
        </div>
         </div>
        <div class="row">
            <div class="col">
                <asp:Button ID="Add" class="btn btn-warning" runat="server" Text="Add" OnClick="Add_Click" />
            </div>
        </div>
   
</asp:Content>
