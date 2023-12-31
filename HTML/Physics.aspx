﻿<%@ Page Title="" Language="C#" MasterPageFile="~/HTML/PhysiscsMaster.Master" AutoEventWireup="true" CodeBehind="Physics.aspx.cs" Inherits="task_12.HTML.Physics" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Physics</title>
    <link href="..\CSS\StyleSheet1.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="mainContainer">
        <div class="mainPic">
            <img id="einstein" src="../Img/physics.png" alt="Mr. Einshtein" height="400" />
        </div>

        <div class="mainVid" height="350">
            <iframe width="560" height="315" src="https://www.youtube.com/embed/TTHazQeM8v8" title="YouTube video player" frameborder="0"
                allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share" allowfullscreen></iframe>
        </div>
    </div>
</asp:Content>
