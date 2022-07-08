<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StudentsRegistration.aspx.cs" Inherits="StudentInformationCRUDOperation.StudentsRegistration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <div>
            <asp:Label ID="lblMessage" Text="" runat="server" />
        </div>
        <div>
            <asp:Label Text="Name" runat="server" /> <br />
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        </div>
        <br />

         <div>
            <asp:Label Text="Address" runat="server" /> <br />
            <asp:TextBox ID="txtAddrerss" runat="server"></asp:TextBox>
        </div>
        <br />

         <div>
            <asp:Label Text="Email" runat="server" /> <br />
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        </div>
        <br />

         <div>
            <asp:Label Text="Mobile Number" runat="server" /> <br />
            <asp:TextBox ID="txtMobileNumber" runat="server" MaxLength="10"></asp:TextBox>
        </div>
        <br />

         <div>
            <asp:Label Text="Password" runat="server" /> <br />
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
        </div>
        <br />

        <div>
            <asp:Button Text="Save" runat="server" ID="btnSave" OnClick="btnSave_Click" /> &nbsp; &nbsp; &nbsp;
            <asp:Button Text="Reset" runat="server" ID="btnReset" OnClick="btnReset_Click" /> &nbsp; &nbsp; &nbsp;
            <asp:Button Text="Students List" runat="server" ID="btnStdList" OnClick="btnStdList_Click" />
        </div>
    </div>
</asp:Content>
