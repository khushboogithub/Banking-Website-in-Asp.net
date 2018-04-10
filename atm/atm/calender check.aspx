<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="calender check.aspx.cs" Inherits="atm.calender_check" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server" style="height: 22px"></asp:TextBox>
        <cc1:CalendarExtender ID="TextBox1_CalendarExtender" runat="server" 
            TargetControlID="TextBox1">
        </cc1:CalendarExtender>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    
    </div>
    </form>
</body>
</html>
