<%@ Page Title="" Language="C#" MasterPageFile="~/HTML/PhysiscsMaster.Master" AutoEventWireup="true" CodeBehind="Dynamics.aspx.cs" Inherits="task_12.HTML.Dynamics" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta charset="utf-8" />
    <link href="..\CSS\StyleSheet1.css" rel="stylesheet" />
    <title>Dynamics</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h1>Dynamics</h1>
    <div class="page-title">
        <p>
            dynamics, branch of physical science and subdivision of mechanics that is concerned with the motion of material objects<br />
            in relation to the physical factors that affect them: force, mass, momentum, and energ.
        </p>
    </div>
    <div class="mainPic">
        <img src="..\Img\dynamics.jpg" height="300" />
    </div>
    <div class="backwards">
        <a href="..\Physics.aspx">
            <img src="..\Img\backwards arrow.jpeg" alt="backwords arrow" width="75" />
        </a>
    </div>
</asp:Content>
