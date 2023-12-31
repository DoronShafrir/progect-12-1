﻿<%@ Page Title="" Language="C#" MasterPageFile="~/HTML/PhysiscsMaster.Master" AutoEventWireup="true" CodeBehind="Energy.aspx.cs" Inherits="task_12.HTML.Energy" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <meta charset="utf-8" />
    <link href="..\CSS\StyleSheet1.css" rel="stylesheet" />
    <title>Energy</title>   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h1>Energy</h1>
    <div class="page-title">
        <p>
            Circular motion is described as a movement of an object while rotating along a circular path. Circular motion can be either uniform or non-uniform. <br />
            During uniform circular motion, the angular rate of rotation and speed will be constant, while during non-uniform motion the rate of rotation keeps changing.
        </p>
    </div>
    <div class="mainPic">
        <img src="../Img/energy.png" height="300" />
        </div>
        <div class="backwards">
            <a href="Physics.aspx">
                <img src="..\Img\backwards arrow.jpeg" alt="backwords arrow" width="75" />
            </a>
        </div>
</asp:Content>
