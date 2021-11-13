<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>简书小工具集</h1>
        <p class="lead">简书小工具集，通过简单的操作与可视化，让技术工具更平常。</p>
        <p><a href="#" class="btn btn-primary btn-lg">了解简书小工具集 &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>用户资产查询工具</h2>
            <p>
                用户资产查询工具，可以根据用户的简书Url地址，方便的查询用户的资产情况。<br><strong>请注意：含有FP(简书钻)与FTN(简书贝)的信息。</strong>
            </p>
            <p>
                <a class="btn btn-default" href="/Tools/UserAssetsViewer.aspx">使用这个工具&raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Get more libraries</h2>
            <p>
                NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Web Hosting</h2>
            <p>
                You can easily find a web hosting company that offers the right mix of features and price for your applications.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
            </p>
        </div>
    </div>


</asp:Content>
