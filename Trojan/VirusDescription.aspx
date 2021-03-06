﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VirusDescription.aspx.cs" Inherits="Trojan.VirusDescription" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="VirusDescriptionTitle" runat="server" class="ContentHead"><h1>Virus Description</h1></div>
    <asp:GridView ID="DescriptionList" runat="server" AutoGenerateColumns="False" ShowFooter="True" GridLines="Vertical" CellPadding="4"
        ItemType="Trojan.Models.Virus_Item" SelectMethod="GetVirusDescriptionItems" 
        CssClass="table table-striped table-bordered" >   
        <Columns>
        <asp:BoundField DataField="AttributeID" HeaderText="ID" SortExpression="AttributeID" />        
        <asp:BoundField DataField="Attribute.AttributeName" HeaderText="Name" />        
        <asp:BoundField DataField="Attribute.CategoryName" HeaderText="Category" />
        <asp:BoundField DataField="Attribute.F_in" HeaderText="F_in" />
        <asp:BoundField DataField="Attribute.F_out" HeaderText="F_out" />     
        <asp:TemplateField   HeaderText="Select Attribute">            
                <ItemTemplate>
                    <asp:CheckBox id="On_Off_CheckBox" runat="server"></asp:CheckBox>
                </ItemTemplate>        
        </asp:TemplateField >
        <asp:TemplateField HeaderText="On/Off">
            <ItemTemplate>
                <asp:Label ID ="Attrib_OnOff" runat="server" Text='<%#Item.On_Off ? "On" : "Off" %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Remove Item">            
                <ItemTemplate>
                    <asp:CheckBox id="Remove" runat="server"></asp:CheckBox>
                </ItemTemplate>        
        </asp:TemplateField>    
        </Columns>    
    </asp:GridView>
    <div>
        <p></p>
        <strong>
            <asp:Label ID="LabelTotalText" runat="server" Text="Total Attributes: "></asp:Label>
            <asp:Label ID="lblTotal" runat="server" EnableViewState="false"></asp:Label>
        </strong>
    </div>
    <div>
        <strong>
            <asp:Label ID="LabelTotalF_in" runat="server" Text="Total F_in: "></asp:Label>
            <asp:Label ID="lblTotalF_in" runat="server" EnableViewState="false"></asp:Label>
        </strong>
    </div>
    <div>
        <strong>
            <asp:Label ID="LabelTotalF_out" runat="server" Text="Total F_out: "></asp:Label>
            <asp:Label ID="lblTotalF_out" runat="server" EnableViewState="false"></asp:Label>
        </strong>
    </div>
    <br />
    <table> 
    <tr>
      <td>
        <asp:Button ID="UpdateBtn" runat="server" Text="Update" OnClick="UpdateBtn_Click" />
      </td>
      <td>
          <asp:ImageButton ID="CheckoutImageBtn" runat="server" ImageUrl="https://www.paypal.com/en_US/i/btn/btn_xpressCheckout.gif" Width="145" AlternateText="Check out with PayPal" 
                      OnClick="CheckoutBtn_Click" 
                      BackColor="Transparent" BorderWidth="0" />
      </td>
    </tr>
    </table>
</asp:Content>