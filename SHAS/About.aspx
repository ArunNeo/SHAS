<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="SHAS.About" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1><%: Title %>.</h1>
        <h2>Your app description page.</h2>
    </hgroup>

    <article>
        <p>        
            We are  Students doing Masters in  Software Engineering at University of Texas Dallas
        </p>

        <p>        
            This project is to understand all Major concepts in SE
        </p>

        <p>        
            This project is guided by Dr.Rym 
        </p>
    </article>

    <aside>
        <h3>Aside Title</h3>
        <p>        
            
        </p>
        <ul>
            <li><a runat="server" href="~/">Home</a></li>
            <li><a runat="server" href="~/About.aspx">About</a></li>
            <li><a runat="server" href="~/Contact.aspx">Contact</a></li>
        </ul>
    </aside>
</asp:Content>