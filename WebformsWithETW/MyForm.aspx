<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MyForm.aspx.cs" Inherits="WebformsWithETW.MyForm" %>

<%@ Register Src="~/MyControl.ascx" TagPrefix="wfwetw" TagName="mycontrol" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <wfwetw:mycontrol runat="server" />
    <div>
        My form's content
    </div>
    <wfwetw:mycontrol runat="server" />
</asp:Content>
