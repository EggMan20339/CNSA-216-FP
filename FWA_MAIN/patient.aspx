<%@ Page Title="Patients" Language="C#" MasterPageFile="main.master" CodeBehind="patient.aspx.cs" Inherits="FWA_MAIN.patient" %>

<asp:Content runat="server" ContentPlaceHolderID="cph1">
    
    
    <h1 style="text-align: center;"> 
            Welcome to Pharmacy. 
        </h1> 
        <h1 style="text-align: center;"> 
            Hi, We are creating a  
            custom context menu here. 
        </h1> 
        <script type="text/javascript"> 
            document.oncontextmenu = rightClick; 
      
            function rightClick(clickEvent) { 
                clickEvent.preventDefault(); 
                // return false; 
            } 
        </script>
    
    <div id="contextMenu" class="context-menu" 
        style="display: none"> 
        <ul> 
            <li><a href="patNew.aspx">New</a></li>
            <li><a href="#">Edit</a></li>
            <li><a href="#">Delete</a></li>
            
            <%-- <asp:Button runat="server" Text="New" OnClick="btnNew_OnClick" /> --%>
        </ul> 
    </div> 
    <script> 
        document.onclick = hideMenu; 
        document.oncontextmenu = rightClick; 
          
        function hideMenu() { 
            document.getElementById("contextMenu") 
                    .style.display = "none" 
        } 
      
        function rightClick(e) { 
            e.preventDefault(); 
      
            if (document.getElementById("contextMenu").style.display == "block") 
                hideMenu(); 
            else{ 
                var menu = document.getElementById("contextMenu") 
      
                menu.style.display = 'block'; 
                menu.style.left = e.pageX + "px"; 
                menu.style.top = e.pageY + "px"; 
            } 
        } 
    </script> 
    <style type="text/css"> 
        .context-menu { 
            position: absolute; 
            text-align: center; 
            background: lightgray; 
            border: 1px solid black; 
        } 
      
        .context-menu ul { 
            padding: 0px; 
            margin: 0px; 
            min-width: 150px; 
            list-style: none; 
        } 
      
        .context-menu ul li { 
            padding-bottom: 7px; 
            padding-top: 7px; 
            border: 1px solid black; 
        } 
      
        .context-menu ul li a { 
            text-decoration: none; 
            color: black; 
        } 
      
        .context-menu ul li:hover { 
            background: darkgray; 
        } 
    </style> 
    
</asp:Content>