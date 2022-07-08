<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StudentsList.aspx.cs" Inherits="StudentInformationCRUDOperation.StudentsList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    
    <br />
    
    <div>
        <asp:GridView ID="GridView1" runat="server" Width="500" HeaderStyle-BackColor="#3AC0F2"
        HeaderStyle-ForeColor="White" RowStyle-BackColor="#A1DCF2" AlternatingRowStyle-BackColor="White"
        RowStyle-ForeColor="#3A3A3A" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="Name" HeaderText="Name" />
                <asp:BoundField DataField="Address" HeaderText="Address" />
                <asp:BoundField DataField="MobileNumber" HeaderText="Email" />
                <asp:BoundField DataField="Email" HeaderText="Mobile Number" />
                <asp:TemplateField >
                    <ItemTemplate>
                        <asp:LinkButton ID="ikbtnEdit" runat="server" Text="Edit" CommandArgument='<%# Eval("Id") %>' OnClick="ikbtnEdit_Click" />
                        <asp:LinkButton ID="ikbtnDelete" runat="server" Text="Delete" CommandArgument='<%# Eval("Id") %>' OnClick="ikbtnDelete_Click" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
    <br />
    <br />
    <asp:Button Text="Register" runat="server" ID="btnRegStud" OnClick="btnRegStud_Click" />
</asp:Content>
