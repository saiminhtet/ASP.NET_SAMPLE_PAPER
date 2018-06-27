<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ParkingRebateSystem.aspx.cs" Inherits="Sample_Paper.ParkingRebateSystem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Parking Rebate System</h1>
           <table>
               <tr>
                   <td>
                       <asp:Label ID="Label1" runat="server" Text="Vehicle number: "></asp:Label>
                   </td>
                   <td>
                       <asp:TextBox ID="txt_vehicleNo" runat="server" OnTextChanged="txt_vehicleNo_TextChanged"></asp:TextBox>
                   </td>
               </tr>
               <tr>
                   <td>
                       <asp:Label ID="Label5" runat="server" Text="Existing Rebates: "></asp:Label>
                   </td>
                 <td>
                      <asp:TextBox ID="txt_existing_rebates" Enabled="false" runat="server"></asp:TextBox>
                   </td>
               </tr>
           </table>
            <br />
            <h2>Enter receipt information</h2>
            <table>
               <tr>
                   <td>
                       <asp:Label ID="Label2" runat="server" Text="Receipt s/n: "></asp:Label>
                   </td>
                   <td>
                       <asp:TextBox ID="txt_Receipt" runat="server"></asp:TextBox>
                   </td>
               </tr>
                <tr>
                   <td>
                       <asp:Label ID="Label3" runat="server" Text="Shop name: "></asp:Label>
                   </td>
                   <td>
                       <asp:TextBox ID="txt_ShopName" runat="server"></asp:TextBox>
                   </td>
               </tr>
                <tr>
                   <td>
                       <asp:Label ID="Label4" runat="server" Text="Amount: "></asp:Label>
                   </td>
                   <td>
                       <asp:TextBox ID="txt_Amount" runat="server"></asp:TextBox>
                   </td>
               </tr>
           </table>
            <asp:Button ID="btn_addReceipt" runat="server" Text="Add Receipt" OnClick="btn_addReceipt_Click" />
            <br />
            
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            <br />
             <asp:Button ID="btn_applyRebates" runat="server" Text="Apply Rebates" OnClick="btn_applyRebates_Click" />
             <br />
            <br />
        <asp:GridView ID="GridView2" runat="server"></asp:GridView>
            <br />
        </div>
    </form>
</body>
</html>
