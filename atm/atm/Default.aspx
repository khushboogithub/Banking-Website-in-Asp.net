<%@ Page Title="" Language="C#" MasterPageFile="~/abc.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />
        <asp:TreeView ID="TreeView1" runat="server" DataSourceID="SiteMapDataSource1">
            <DataBindings>
                <asp:TreeNodeBinding Text="abc" Value="abc" />
                <asp:TreeNodeBinding Text="abcd" Value="abcd" />
            </DataBindings>
        </asp:TreeView>
        <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />
    </p>
    <p>
    </p>
</asp:Content>

