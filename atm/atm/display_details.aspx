<%@ Page Language="C#" AutoEventWireup="true" CodeFile="display_details.aspx.cs" Inherits="display_details" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style3
        {
            font-family: "Lucida Sans";
            font-weight: normal;
        }
        .style4
        {
            text-decoration: underline;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
        SelectCommand="SELECT * FROM [details]"></asp:SqlDataSource>
    <div>
    
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <h1 class="style3">
            <strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <span class="style4">&nbsp;Please Review Your Details</span> </strong>
        </h1>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<table class="style1">
            <tr>
                <td>
                    <h2>
&nbsp;Account Number :</h2>
                </td>
                <td>
                    <h2>
        <asp:Label ID="Label1" runat="server"></asp:Label>
                    </h2>
                </td>
            </tr>
            <tr>
                <td>
                    <h2>
                        Name :</h2>
                </td>
                <td>
                    <h2>
                        <asp:Label ID="Label2" runat="server"></asp:Label>
                    </h2>
                </td>
            </tr>
            <tr>
                <td>
                    <h2>
                        Date Of Birth :
                    </h2>
                </td>
                <td>
                    <h2>
                        <asp:Label ID="Label3" runat="server"></asp:Label>
                    </h2>
                </td>
            </tr>
            <tr>
                <td>
                    <h2>
                        Sex:</h2>
                </td>
                <td>
                    <h2>
                        <asp:Label ID="Label4" runat="server"></asp:Label>
                    </h2>
                </td>
            </tr>
            <tr>
                <td>
                    <h2>
                        Address:</h2>
                </td>
                <td>
                    <h2>
                        <asp:Label ID="Label5" runat="server"></asp:Label>
                    </h2>
                </td>
            </tr>
            <tr>
                <td>
                    <h2>
                        City:</h2>
                </td>
                <td>
                    <h2>
                        <asp:Label ID="Label6" runat="server"></asp:Label>
                    </h2>
                </td>
            </tr>
            <tr>
                <td>
                    <h2>
                        State:</h2>
                </td>
                <td>
                    <h2>
                        <asp:Label ID="Label7" runat="server"></asp:Label>
                    </h2>
                </td>
            </tr>
            <tr>
                <td>
                    <h2>
&nbsp;Pincode:</h2>
                </td>
                <td>
                    <h2>
                        <asp:Label ID="Label8" runat="server"></asp:Label>
                    </h2>
                </td>
            </tr>
            <tr>
                <td>
                    <h2>
                        Email ID</h2>
                </td>
                <td>
                    <h2>
                        <asp:Label ID="Label9" runat="server"></asp:Label>
                    </h2>
                </td>
            </tr>
            <tr>
                <td>
                    <h2>
                        Contact:</h2>
                </td>
                <td>
                    <h2>
                        <asp:Label ID="Label10" runat="server"></asp:Label>
                    </h2>
                </td>
            </tr>
            <tr>
                <td>
                    <h2>
                        Pin:</h2>
                </td>
                <td>
                    <h2>
                        <asp:Label ID="Label11" runat="server"></asp:Label>
                    </h2>
                </td>
            </tr>
            <tr>
                <td>
                    <h2>
                        Current Balance</h2>
                </td>
                <td>
                    <h2>
        <asp:Label ID="Label14" runat="server"></asp:Label>
                    </h2>
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
        <br />
    
    </div>
    <div style="margin-left: 280px">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Height="68px" onclick="Button1_Click" 
            Text="Goto Login" Width="318px" Font-Size="X-Large" />
    &nbsp;</div>
    </form>
</body>
</html>
