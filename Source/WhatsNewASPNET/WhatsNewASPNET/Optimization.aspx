<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Optimization.aspx.cs" Inherits="Web11.Optimization" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <link href="Styles/CSS" rel="stylesheet" type="text/css" />
    <script src="Scripts/custom/JS"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <ul>
        <li>
            <h2><a href="Styles/CSS">CSS Bundle</a></h2>
        </li>
        <li>
            <h2><a href="Scripts/custom/JS">JS Bundle</a></h2>
        </li>
        <li>
            <h2><a href="StaticBundle">Static JS Bundle</a></h2>
        </li>
        <li>
            <h2><a href="Scripts/bundle/Coffee">Dynamic JS Bundle</a></h2>
        </li>
    </ul>
</asp:Content>
