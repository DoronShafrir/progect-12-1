<%@ Page Title="" Language="C#" MasterPageFile="~/HTML/PhysiscsMaster.Master" AutoEventWireup="true" CodeBehind="Optics.aspx.cs" Inherits="task_12.HTML.Optics" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Optics</title>
    <link href="..\CSS\StyleSheet1.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="mainContainer">
        <div class="mainPic">
            <img id="einstein" src="../Img/optics.gif" alt="Optics" height="300" />
        </div>
        <div class="mainVid">
            <<iframe width="560" height="315" src="https://www.youtube.com/embed/SUZVp3txZvo" title="&quot;הולוגרמה&quot;"
                frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; 
            web-share" allowfullscreen></iframe>
        </div>
    </div>
</asp:Content>
