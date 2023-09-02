<%@ Page Title="" Language="C#" MasterPageFile="~/HTML/PhysiscsMaster.Master" AutoEventWireup="true" CodeBehind="AdminCounters.aspx.cs" Inherits="task_12.HTML.Log" ClientIDMode="Static" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta charset="utf-8" />
    <title></title>
    <link href="../CSS/AdminStyleSheet.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Counters</h1>
    <div class="counters">
        <div class="groupCounters">
            <div class="counter">
                <h3>Users open application from day one</h3>
                <h2 id="mainCounter" class="counterDisplay" runat="server"></h2>
            </div>
            <div class="counter">
                <h3>Users Loged In from day one</h3>
                <h2 id="mainCounterLogedIn" class="counterDisplay" runat="server"></h2>
            </div>
        </div>

        <div class="groupCounters">
            <div class="counter">
                <h3>Current number of open application NOW</h3>
                <h2 id="currentCounter" class="counterDisplay" runat="server"></h2>
            </div>
            <div class="counter">
                <h3>Loged In  users cureently in the system  NOW</h3>
                <h2 id="currentCounterLogedIn" class="counterDisplay" runat="server"></h2>
            </div>
        </div>
    </div>
</asp:Content>
