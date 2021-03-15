<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Dottor.WebFormCounter._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="card">
        <div class="card-body">
            <h5 class="card-title">DEMO Counter Web Form</h5>
            <p class="card-text">
                <asp:Literal runat="server" ID="lblCounter" />
            </p>
            <asp:Button runat="server"
                ID="btnIncrement"
                CssClass="btn btn-primary"
                Text="+ 1"
                OnClick="btnIncrement_Click" />
            <asp:Button runat="server"
                ID="btnDecrement"
                CssClass="btn btn-primary"
                Text="- 1"
                OnClick="btnDecrement_Click" />
        </div>
    </div>


</asp:Content>
