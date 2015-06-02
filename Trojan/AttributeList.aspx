<%@ Page Title="Attributes" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AttributeList.aspx.cs" Inherits="Trojan.AttributeList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section>
        <div>
            <hgroup>
                <h2><%: Page.Title %></h2>
            </hgroup>

            <asp:ListView ID="attributeList" runat="server" 
                DataKeyNames="AttributeID" GroupItemCount="4"
                ItemType="Trojan.Models.Attribute" SelectMethod="GetAttributes">
                <EmptyDataTemplate>
                    <table >
                        <tr>
                            <td>No data was returned.</td>
                        </tr>
                    </table>
                </EmptyDataTemplate>
                <EmptyItemTemplate>
                    <td/>
                </EmptyItemTemplate>
                <GroupTemplate>
                    <tr id="itemPlaceholderContainer" runat="server">
                        <td id="itemPlaceholder" runat="server"></td>
                    </tr>
                </GroupTemplate>
                <ItemTemplate>
                    <td runat="server">
                        <table>
                            <tr>
                                <td>
                                    <a href="AttributeDetails.aspx?AttributeID=<%#:Item.AttributeID%>">
                                        <img src="/Catalog/Images/Thumbs/<%#:Item.ImagePath%>"
                                            width="100" height="75" style="border: solid" /></a>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <a href="AttributeDetails.aspx?AttributeID=<%#:Item.AttributeID%>">
                                        <span>
                                            <%#:Item.AttributeName%>
                                        </span>
                                    </a>
                                    <br />
                                    <span>
                                        <b>F_in: </b><%#:String.Format("{0:d}", Item.F_in)%>
                                    </span>
                                    <span>
                                        <b>F_out: </b><%#:String.Format("{0:d}", Item.F_out)%>
                                    </span>
                                    <br />
                                    <a href="/AddToDescription.aspx?AttributeID=<%#:Item.AttributeID %>">               
                                        <span class="AttributeListItem">
                                            <b>Add To Virus Description<b>
                                        </span>           
                                    </a>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                        </p>
                    </td>
                </ItemTemplate>
                <LayoutTemplate>
                    <table style="width:100%;">
                        <tbody>
                            <tr>
                                <td>
                                    <table id="groupPlaceholderContainer" runat="server" style="width:100%">
                                        <tr id="groupPlaceholder"></tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td></td>
                            </tr>
                            <tr></tr>
                        </tbody>
                    </table>
                </LayoutTemplate>
            </asp:ListView>
        </div>
    </section>
</asp:Content>