<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeFile="ForgetChangePin.aspx.cs" Inherits="_Default" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style22
        {
            font-size: x-large;
        }
.VeryPoorStrength
{
background: Red;
color:White;
font-weight:bold;
}
.WeakStrength
{
background: Gray;
color:White;
font-weight:bold;
}
.AverageStrength
{
background: orange;
color:black;
font-weight:bold;
}
.GoodStrength
{
background: blue;
color:White;
font-weight:bold;
}
.ExcellentStrength

{
background: Green;
color:White;
font-weight:bold;
}
.BarBorder
{
border-style: solid;
border-width: 1px;
width: 180px;
padding:2px;
}
    .style24
    {
        font-size: x-large;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="background-image: url('photos/rekk.jpg'); background-repeat: no-repeat; background-attachment: scroll">


    <p>
        &nbsp;</p>
    <p>
        <span class="style24"><strong>Account Number:&nbsp; </strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </span>
        <asp:Label ID="lbl_acc" runat="server" CssClass="style24"></asp:Label>
    </p>
    <p>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    </p>
    <p>
        <span class="style24"><strong>New Pin:</strong></span><span class="style22">&nbsp;</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txt_pin" runat="server" Height="23px" Width="148px" 
            TextMode="Password"></asp:TextBox>
        <cc1:PasswordStrength ID="txt_pin_PasswordStrength" runat="server" 
            TargetControlID="txt_pin"
            StrengthIndicatorType="BarIndicator"
                     PrefixText="Strength:"
                      HelpStatusLabelID="lbl_pinStren" 
                      PreferredPasswordLength="8"
                       MinimumNumericCharacters="1" 
                       MinimumSymbolCharacters="1" 
                       BarBorderCssClass="BarBorder"
                        TextStrengthDescriptionStyles="VeryPoorStrength;WeakStrength;AverageStrength;GoodStrength;ExcellentStrength">
        </cc1:PasswordStrength>
    </p>
    <p style="margin-left: 160px">
        <asp:Label ID="lbl_pinStren" runat="server"></asp:Label>
&nbsp;&nbsp;
    <asp:RequiredFieldValidator ID="RequiredFieldValidator17" runat="server" 
                ControlToValidate="txt_pin" ErrorMessage="Field should not be empty" 
                ForeColor="Red"></asp:RequiredFieldValidator>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        <strong>
        <span class="style24">Confirm Pin:</span><span class="style22">&nbsp;</span></strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txt_conPin" runat="server" Height="23px" Width="147px" 
            TextMode="Password"></asp:TextBox>
&nbsp;
   
    
    </p>
    <p style="margin-left: 160px">
   
    <asp:RequiredFieldValidator ID="RequiredFieldValidator18" runat="server" 
                ControlToValidate="txt_conPin" ErrorMessage="Field should not be empty" 
                ForeColor="Red"></asp:RequiredFieldValidator>
                

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:CompareValidator ID="CompareValidator1" runat="server" 
            ControlToCompare="txt_pin" ControlToValidate="txt_conPin" 
            ErrorMessage="Password ain't matching" ForeColor="Red"></asp:CompareValidator>
        &nbsp;</p>
    <p>
        <asp:Label ID="lbl_disp" runat="server"></asp:Label>
    </p>
    <p style="margin-left: 160px">
        <asp:Button ID="OK" runat="server" Height="36px" onclick="OK_Click" 
            Text="OK" Width="144px" style="font-size: x-large" />
    </p>
    <p>
        &nbsp;</p>
        </div>
</asp:Content>

