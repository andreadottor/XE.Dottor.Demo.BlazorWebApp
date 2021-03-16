<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Dottor.WebFormCounter._Default" %>

<%@ Register Src="~/UserControls/Counter.ascx" TagPrefix="uc" TagName="Counter" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <uc:Counter runat="server" Title="DEMO counter con Web Form" StartValue="42" />


</asp:Content>
