<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Matrix.aspx.cs" Inherits="Trojan.Matrix" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="AttributeID" DataSourceID="SqlDataSource1" CellPadding="4" CssClass="table table-striped table-bordered">
    <Columns>
        <asp:BoundField DataField="AttributeID" HeaderText="AttributeID" InsertVisible="False" ReadOnly="True" SortExpression="AttributeID"/>
        <asp:CheckBoxField DataField="A1" HeaderText="A1" SortExpression="A1" />
        <asp:CheckBoxField DataField="A2" HeaderText="A2" SortExpression="A2" />
        <asp:CheckBoxField DataField="A3" HeaderText="A3" SortExpression="A3" />
        <asp:CheckBoxField DataField="A4" HeaderText="A4" SortExpression="A4" />
        <asp:CheckBoxField DataField="A5" HeaderText="A5" SortExpression="A5" />
        <asp:CheckBoxField DataField="A6" HeaderText="A6" SortExpression="A6" />
        <asp:CheckBoxField DataField="A7" HeaderText="A7" SortExpression="A7" />
        <asp:CheckBoxField DataField="A8" HeaderText="A8" SortExpression="A8" />
        <asp:CheckBoxField DataField="A9" HeaderText="A9" SortExpression="A9" />
        <asp:CheckBoxField DataField="A10" HeaderText="A10" SortExpression="A10" />
        <asp:CheckBoxField DataField="A11" HeaderText="A11" SortExpression="A11" />
        <asp:CheckBoxField DataField="A12" HeaderText="A12" SortExpression="A12" />
        <asp:CheckBoxField DataField="A13" HeaderText="A13" SortExpression="A13" />
        <asp:CheckBoxField DataField="A14" HeaderText="A14" SortExpression="A14" />
        <asp:CheckBoxField DataField="A15" HeaderText="A15" SortExpression="A15" />
        <asp:CheckBoxField DataField="A16" HeaderText="A16" SortExpression="A16" />
        <asp:CheckBoxField DataField="A17" HeaderText="A17" SortExpression="A17" />
        <asp:CheckBoxField DataField="A18" HeaderText="A18" SortExpression="A18" />
        <asp:CheckBoxField DataField="A19" HeaderText="A19" SortExpression="A19" />
        <asp:CheckBoxField DataField="A20" HeaderText="A20" SortExpression="A20" />
        <asp:CheckBoxField DataField="A21" HeaderText="A21" SortExpression="A21" />
        <asp:CheckBoxField DataField="A22" HeaderText="A22" SortExpression="A22" />
        <asp:CheckBoxField DataField="A23" HeaderText="A23" SortExpression="A23" />
        <asp:CheckBoxField DataField="A24" HeaderText="A24" SortExpression="A24" />
        <asp:CheckBoxField DataField="A25" HeaderText="A25" SortExpression="A25" />
        <asp:CheckBoxField DataField="A26" HeaderText="A26" SortExpression="A26" />
        <asp:CheckBoxField DataField="A27" HeaderText="A27" SortExpression="A27" />
        <asp:CheckBoxField DataField="A28" HeaderText="A28" SortExpression="A28" />
        <asp:CheckBoxField DataField="A29" HeaderText="A29" SortExpression="A29" />
        <asp:CheckBoxField DataField="A30" HeaderText="A30" SortExpression="A30" />
        <asp:CheckBoxField DataField="A31" HeaderText="A31" SortExpression="A31" />
        <asp:CheckBoxField DataField="A32" HeaderText="A32" SortExpression="A32" />
        <asp:CheckBoxField DataField="A33" HeaderText="A33" SortExpression="A33" />
    </Columns>
</asp:GridView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Trojan %>" SelectCommand="SELECT * FROM [MatrixRows]"></asp:SqlDataSource>

</asp:Content>
