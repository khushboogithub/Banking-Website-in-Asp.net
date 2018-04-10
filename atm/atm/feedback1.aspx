<%@ Page Language="C#" AutoEventWireup="true" CodeFile="feedback1.aspx.designer.cs" Inherits="feedback1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .style2
        {
            font-size: xx-large;
        }
        .style3
        {
            font-size: xx-large;
            font-weight: bold;
            text-align: center;
        }
        .style5
        {
            font-size: xx-large;
            font-weight: bold;
            text-align: center;
            height: 48px;
        }
        .style6
        {
            height: 48px;
        }
        .style7
        {
            color: #00CCFF;
            text-decoration: underline;
            background-color: #FFFFFF;
        }
    </style>
</head>
<body>
       <strong><span class="style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <span class="style7">&nbsp;FEEDBACK</span></span></strong>
    <form id="form1" runat="server">

    <h3>&nbsp;</h3>

    <div">

    <table>

    <tr>

    <td class="style5">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Enter Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>

    <td class="style6"><asp:TextBox ID="txtName" runat="server" Height="32px" 
            Width="180px"></asp:TextBox>
        <br />
        </td>

    </tr>

      <tr>

    <td class="style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Enter Subject&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>

    <td><asp:TextBox ID="txtSubject" runat="server" Height="32px" 
            style="margin-top: 0px" Width="179px"></asp:TextBox>
        <br />
          </td>

    </tr>

      <tr>

    <td valign="top" class="style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; EnterComments</td>

    <td><asp:TextBox ID="txtComment" runat="server" Rows="5" Columns="20" 
            TextMode="MultiLine" Height="136px" Width="226px"></asp:TextBox></td>

    </tr>

      <tr>

    <td>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
          </td>

    <td><asp:Button ID="btnSubmit" runat="server" Text="Submit" 
            OnClick="btnSubmit_click" Height="50px" style="margin-left: 0px" 
            Width="140px" />
        <br />
          </td>

    </tr>

    </table>

    </div>

    <div>

    <asp:Repeater ID="RepterDetails" runat="server">

    <HeaderTemplate>

    <table style="border:1px solid #C0C0C0; width:1500px" cellpadding="0">

    <tr style="background-color: #ADD8E6; color:#000000; font-size: xx-large; font-weight: bold;">

    <td colspan="2">

    <b>Comments</b>

    </td>

    </tr>

    </HeaderTemplate>

    <ItemTemplate>

    <tr style="background-color:#EBEFF0">

    <td>

    <table style="background-color:#EBEFF0;border-top:1px dotted #df5015; width:1500px" >

    <tr>

    <td >

    Subject:

    <asp:Label ID="lblSubject" runat="server" Text='<%#Eval("Subject") %>' Font-Bold="true"/>

    </td>

    </tr>

    </table>

    </td>

    </tr>

    <tr>

    <td>

    <asp:Label ID="lblComment" runat="server" Text='<%#Eval("Comment") %>'/>

    </td>

    </tr>

    <tr>

    <td>

    <table style="background-color:#EBEFF0;border-top:1px dotted #df5015;border-bottom:1px solid #df5015; width:1500px" >

    <tr>

    <td >Post By: <asp:Label ID="lblUser" runat="server" Font-Bold="true" Text='<%#Eval("UserName") %>'/></td>

    <td >Created Date:<asp:Label ID="lblDate" runat="server" Font-Bold="true" Text='<%#Eval("Post_Date") %>'/></td>

    </tr>

    </table>

    </td>

    </tr>

    <tr>

    <td colspan="2">&nbsp;</td>

    </tr>

    </ItemTemplate>

    <FooterTemplate>

    </table>

    </FooterTemplate>

    </asp:Repeater>
   
    
    </div>
    </form>
</body>
</html>
