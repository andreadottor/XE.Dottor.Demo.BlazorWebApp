<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Counter.ascx.cs" Inherits="Dottor.WebFormCounter.UserControls.Counter" %>

<div class="card">
    <div class="card-body">
        <h5 class="card-title">
            <%: Title %>
        </h5>
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