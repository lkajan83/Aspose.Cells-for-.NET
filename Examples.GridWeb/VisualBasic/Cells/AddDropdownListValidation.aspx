﻿<%@ Page Title="Add Dropdown List Validation - Aspose.Cells Grid Suite Examples" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master"
     CodeBehind="AddDropdownListValidation.aspx.vb" Inherits="Aspose.Cells.GridWeb.Examples.VisualBasic.Cells.AddDropdownListValidation" %>

<%@ Register TagPrefix="acw" Namespace="Aspose.Cells.GridWeb" Assembly="Aspose.Cells.GridWeb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeaderContent" runat="server">
</asp:Content>
<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <table class="componentDescriptionTxt" border="0" cellpadding="0" cellspacing="0"
        style="text-align: center; width: 100%; font-family: Arial; font-size: small;">
        <tbody>
            <tr>
                <td style="width: 19; vertical-align: top;">
                    <img alt="" height="41" src="/Common/images/heading_lft.jpg" width="19" />
                </td>
                <td class="demos-heading-bg" style="width: 100%;">
                    <h2 class="demos-heading-bg">
                       Add Dropdown List Validation - Aspose.Cells Grid Suite Examples
                    </h2>
                </td>
                <td style="width: 19; vertical-align: top;">
                    <img alt="" height="41" src="/Common/images/heading_rt.jpg" width="19" />
                </td>
            </tr>
        </tbody>
    </table>
    <div style="text-align: left; font-family: Arial; font-size: small;" class="componentDescriptionTxt">
        <p>
          Click <b>Add Dropdown List Validation</b> to add dropdown list based validation to GridWeb cells.
        </p>
        <br />
        <div>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" ></asp:Label> <br />
                        <asp:Button ID="btnAddDropDownListValidation" runat="server" Text="Add DropDown List Validaiton" OnClick="btnAddDropDownListValidation_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <acw:GridWeb ID="GridWeb1" runat="server" ForceValidation="true">
                        </acw:GridWeb>
                    </td>
                </tr>
            </table>
            <br />
        </div>
    </div>
</asp:Content>
