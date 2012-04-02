<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="JavaScript.aspx.cs" Inherits="Web11.JavaScript" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        You have viewed this page <span id="count">an untold number of</span> time(s).
    </p>

    <script>
      addCount(1);
      document.getElementById('count').innerHTML = getCount();
            
      function getCount() {
        var storage = window.localStorage;
        if (!storage.pageLoadCount)
          storage.pageLoadCount = 0;

        return storage.pageLoadCount;
      }
      
      function addCount(value) {          
        window.localStorage.pageLoadCount = parseInt(getCount(), 10) + value;        
      }

      //function testAutoAlign(){
      //var x = "this is a test";
      //}
      
    </script>
</asp:Content>
