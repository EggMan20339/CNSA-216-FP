<%@ Page Title="Edit Patient" Language="C#" MasterPageFile="main.master" CodeBehind="patEdit.aspx.cs" Inherits="FWA_MAIN.patEdit" %>

<asp:Content runat="server" ContentPlaceHolderID="cph1">
    
    <link type="text/css" href="main.css"/>
    
    <h1 style="text-align: center; font-size: 44px">Edit Patient</h1>
    <div class="patDiv">
    <div class="patDiv">
        <div class="patDiv" style="padding-left: 150px; padding-right: 5px;width: 100px">
            <div class="indivPatDiv" style="text-align: right"><label class="buttonLabel">Patient ID: </label></div>
            <div class="indivPatDiv" style="text-align: right"><label class="buttonLabel">First Name: </label></div>
            <div class="indivPatDiv" style="text-align: right"><label class="buttonLabel">Last Name: </label></div>
            <div class="indivPatDiv" style="text-align: right"><label class="buttonLabel">Middle Initial: </label></div>
            <div class="indivPatDiv" style="text-align: right"><label class="buttonLabel">Weight (lbs): </label></div>
            <div class="indivPatDiv" style="text-align: right"><label class="buttonLabel">Height (Ft): </label></div>
            <div class="indivPatDiv" style="text-align: right"><label class="buttonLabel">Height (In): </label></div>
            <div class="indivPatDiv" style="text-align: right"><label class="buttonLabel">Date of Birth: </label></div>
            <div class="indivPatDiv" style="text-align: right"><label class="buttonLabel">Gender (M/F): </label></div>
        </div>
        <div class="patDiv">
            <div class="indivPatDiv"><asp:TextBox runat="server" CssClass="defaultTXT" ID="txtPatID"></asp:TextBox></div>
            <div class="indivPatDiv"><asp:TextBox runat="server" CssClass="defaultTXT" ID="txtFNAME"></asp:TextBox></div>
            <div class="indivPatDiv"><asp:TextBox runat="server" CssClass="defaultTXT" ID="txtLNAME"></asp:TextBox></div>
            <div class="indivPatDiv"><asp:TextBox runat="server" CssClass="defaultTXT" ID="txtMidInit"></asp:TextBox></div>
            <div class="indivPatDiv"><asp:TextBox runat="server" CssClass="defaultTXT" ID="txtWeight"></asp:TextBox></div>
            <div class="indivPatDiv"><asp:TextBox runat="server" CssClass="defaultTXT" ID="txtHeightFt"></asp:TextBox></div>
            <div class="indivPatDiv"><asp:TextBox runat="server" CssClass="defaultTXT" ID="txtHeightIn"></asp:TextBox></div>
            <div class="indivPatDiv"><asp:TextBox runat="server" CssClass="defaultTXT" ID="txtDOB"></asp:TextBox></div>
            <div class="indivPatDiv"><asp:TextBox runat="server" CssClass="defaultTXT" ID="txtGender"></asp:TextBox></div>
        </div>
    </div>    
    <div class="patDiv">
        <div class="patDiv" style="padding-left: 150px; padding-right: 5px;width: 120px">
            <div class="indivPatDiv" style="text-align: right"><label class="buttonLabel">City: </label></div>
            <div class="indivPatDiv" style="text-align: right"><label class="buttonLabel">Zip Code: </label></div>
            <div class="indivPatDiv" style="text-align: right"><label class="buttonLabel">State: </label></div>
            <div class="indivPatDiv" style="text-align: right"><label class="buttonLabel">Phone Number: </label></div>
        </div>
        <div class="patDiv">
            <div class="indivPatDiv"><asp:TextBox runat="server" CssClass="defaultTXT" ID="txtCity"></asp:TextBox></div>
            <div class="indivPatDiv"><asp:TextBox runat="server" CssClass="defaultTXT" ID="txtZip"></asp:TextBox></div>
            <div class="indivPatDiv"><asp:TextBox runat="server" CssClass="defaultTXT" ID="txtState"></asp:TextBox></div>
            <div class="indivPatDiv"><asp:TextBox runat="server" CssClass="defaultTXT" ID="txtPhoneNum"></asp:TextBox></div>
        </div>
    </div>
    </div>
    <br/>
    <div class="patDiv" style="margin-left: 500px">
        <div style="margin-right: 10px; display: inline-block"><asp:Button runat="server" CssClass="standardbtn" ID="btnSavePat" Text="Save"/></div>
        <div style="display: inline-block"><asp:Button runat="server" CssClass="standardbtn" ID="btnCancelPat" Text="Cancel" OnClick="btnCancelPat_OnClick"/></div>
    </div>
</asp:Content>