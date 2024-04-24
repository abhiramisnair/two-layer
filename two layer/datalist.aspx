<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="datalist.aspx.cs" Inherits="two_layer.datalist" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 26px;
        }
        .auto-style3 {
            width: 106px;
        }
        .auto-style4 {
            width: 106px;
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:DataList ID="DataList1" runat="server" RepeatColumns="2">
                        <ItemTemplate>
                            <table class="auto-style1">
                                <tr>
                                    <td class="auto-style4"></td>
                                    <td class="auto-style2"></td>
                                </tr>
                                <tr>
                                    <td class="auto-style3">
                                        <asp:Label ID="Label4" runat="server" Text="name"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="Label5" runat="server" Text='<%# Eval("name") %>'></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style3">&nbsp;</td>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style3">
                                        <asp:Label ID="Label2" runat="server" Text="age"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="Label6" runat="server" Text='<%# Eval("age") %>'></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style3">&nbsp;</td>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style3">
                                        <asp:Label ID="Label3" runat="server" Text="photo"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Image ID="Image1" runat="server" Height="103px" ImageUrl='<%# Eval("photo") %>' Width="86px" />
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style3">&nbsp;</td>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style3">&nbsp;</td>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style3">&nbsp;</td>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style3">&nbsp;</td>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style3">&nbsp;</td>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style3">&nbsp;</td>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style3">&nbsp;</td>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style3">&nbsp;</td>
                                    <td>&nbsp;</td>
                                </tr>
                            </table>
                        </ItemTemplate>
                    </asp:DataList>
                </td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
