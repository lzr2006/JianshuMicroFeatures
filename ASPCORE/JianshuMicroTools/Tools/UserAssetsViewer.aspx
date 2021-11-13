<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserAssetsViewer.aspx.cs" Inherits="Tools_UserAssetsViewer" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
        <script language="javascript" type="text/javascript">
        function getEmployeecode(empid)
        {
            alert("员工编号："+empid);
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        	<h1 id="用户资产查询工具" style="box-sizing: border-box; margin: 24px 0px 16px; font-weight: 600; line-height: 1.25; font-size: 2em; padding-bottom: 0.3em; border-bottom: 1px solid rgb(234, 236, 239); color: rgb(36, 41, 46); font-family: -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Helvetica, Arial, sans-serif, &quot;Apple Color Emoji&quot;, &quot;Segoe UI Emoji&quot;; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; letter-spacing: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial;">用户资产查询工具</h1>
        </div>
		<p>
			输入用户的Url：</p>
		<asp:TextBox ID="TextBox1" runat="server" Font-Names="Agency FB" Font-Size="Large" Height="21px" Width="366px"></asp:TextBox>
    	<asp:Button ID="Button1" runat="server" Height="27px" OnClick="Button1_Click" Text="确认" Width="83px" />


        <p>
            &nbsp;</p>

    <h2>
        该用户的资产信息</h2>


        <asp:Label ID="Label_FP" runat="server" Text="他的简书钻："></asp:Label>
        <p>
            <asp:Label ID="Label_FTN" runat="server" Text="他的简书贝："></asp:Label>
        </p>
        <asp:Chart ID="Chart_Info" runat="server" Width="311px">
          <%--  <borderskin skinstyle="Emboss"></borderskin>--%>
            <Series>
                <asp:Series Name="Series1"  ChartType="Pie" MarkerSize="8" MarkerStyle="Circle">
                </asp:Series>
            </Series>
            <ChartAreas>
                <asp:ChartArea Name="ChartArea1" >
                </asp:ChartArea>
            </ChartAreas>
        </asp:Chart>

        <asp:Chart ID="Chart1" runat="server">
            <series>
                <asp:Series Name="Series1">
                </asp:Series>
            </series>
            <chartareas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </chartareas>
        </asp:Chart>
    </form>

    
</body>
</html>
