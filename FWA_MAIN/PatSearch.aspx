<%@ Page Title="Patients" Language="C#" MasterPageFile="main.master" CodeBehind="~/PatSearch.aspx.cs" Inherits="FWA_MAIN.PatSearch" %>

<asp:Content runat="server" ContentPlaceHolderID="cph1">

    <link type="text/css" href="main.css"/>

    <script type="text/javascript">
        document.addEventListener('DOMContentLoaded', function () {
            var inputElements = document.getElementsByTagName('input');
            for (var i = 0; i < inputElements.length; i++) {
                var input = inputElements[i];
                if (input.type === 'text') {
                    input.addEventListener('keydown', function (event) {
                        if (event.keyCode === 13) { // 13 is the Enter key
                            event.preventDefault(); // Prevent the default action
                            document.getElementById('<%= btnPatSearch.ClientID %>').click(); // Trigger button click
                        }
                    });
                }
            }
        });
    </script>


    
    <h1 style="text-align: center; font-size: 44px">
        Patients
    </h1>
    <div class="patDiv" style="padding-left: 400px">
        <div class="patDiv" style="width: 100px; margin-right: 5px">
            <div class="indivPatDiv" style="text-align: right;">
                <label for="txtFNAME" class="buttonLabel">First Name: </label>
            </div>
            <br/>
            <div class="indivPatDiv" style="text-align: right;">
                <label for="txtLNAME" class="buttonLabel">Last Name: </label>
            </div>
            <br/>
            <div class="indivPatDiv" style="text-align: right;">
                <label for="txtPatID" class="buttonLabel">Patient ID: </label>
            </div>
            <br/>
        </div>

        <div class="patDiv" style="width: 400px">
            <div class="indivPatDiv">
                <asp:TextBox runat="server" CssClass="defaultTXT" id="txtFNAME"></asp:TextBox>
            </div>
            <br/>
            <div class="indivPatDiv">
                <asp:TextBox runat="server" CssClass="defaultTXT" id="txtLNAME"></asp:TextBox>
            </div>
            <br/>
            <div class="indivPatDiv">
                <asp:TextBox runat="server" CssClass="defaultTXT" id="txtPatID"></asp:TextBox>
            </div>
            <br/>
        </div>
        <br/>
        <asp:Button runat="server" ID="btnPatSearch" Text="Search" CssClass="btnPatSearch" OnClick="btnPatSearch_OnClick" />

    </div>

    <asp:GridView runat="server" ID="gvPatient" BorderColor="white" AutoGenerateColumns="False" OnSelectedIndexChanged="gvPatient_OnSelectedIndexChanged"
                  OnRowDataBound="gvPatient_OnRowDataBound">
        <Columns>
            <asp:BoundField DataField="Patient_id" HeaderText="Patient ID" ItemStyle-Width="100px"/>
            <asp:BoundField DataField="FirstName" HeaderText="First Name" ItemStyle-Width="100px"/>
            <asp:BoundField DataField="LastName" HeaderText="Last Name" ItemStyle-Width="100px"/>
            <asp:BoundField DataField="DOB" HeaderText="Date of Birth" ItemStyle-Width="100px"/>
            <asp:BoundField DataField="PhoneNumber" HeaderText="Phone Number" ItemStyle-Width="100px"/>
            <asp:BoundField DataField="Gender" HeaderText="Gender" ItemStyle-Width="100px"/>
        </Columns>
    </asp:GridView>
    

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
            <li>
                <a href="patNew.aspx">New</a>
            </li>
            <li>
                <a href="patEdit.aspx">Edit</a>
            </li>
            <li>
                <a href="#">Delete</a>
            </li>

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
<script type="text/javascript">
    window.onload = function() {
        var grid = document.getElementById("<%= gvPatient.ClientID %>");
        var rows = grid.getElementsByTagName("tr");
        for (var i = 0; i < rows.length; i++) {
            rows[i].onclick = function() {
                // Assuming the first cell in every row contains the unique ID
                var id = this.cells[0].innerText;
                __doPostBack('Select$', id);
            };
        }
    };
</script>
</asp:Content>