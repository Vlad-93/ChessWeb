<%@ Page Title="Правила игры" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="ChessRules.aspx.cs" Inherits="Chess1.ChessRules" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Правила игры в шахматы
    </h2>
    <p>
        Шахматные армии выстраиваются на поле боя лицом к лицу. Силы сторон перед сражением абсолютно равны и результат битвы зависит только от таланта и знаний полководцев.
        Впереди каждой армии выстраиваются пешки.        
    </p>
        <asp:Image ID="ImagePawn" runat="server" ImageUrl="Images/Pawn.png" ImageAlign="Middle" />
    <p>У белых 8 пешек по второй горизонтали и 8 пешек у черных по седьмой горизонтали. За спиной у пешек выстраиваются фигуры.</p>
    <p>по углам доски становятся ладьи:</p>
        <asp:Image ID="Image1" runat="server" ImageUrl="Images/Rook.png" ImageAlign="Middle" />
    <p>рядом с ладьями встают кони:</p>
        <asp:Image ID="Image2" runat="server" ImageUrl="Images/Knight.png" ImageAlign="Middle" />
    <p>рядом с конями — слоны:</p>
        <asp:Image ID="Image3" runat="server" ImageUrl="Images/Bishop.png" ImageAlign="Middle" />
    <p>по центру, за пешечной фалангой, становится ферзь:</p>
        <asp:Image ID="Image4" runat="server" ImageUrl="Images/Queen.png" ImageAlign="Middle" />
    <p>и около него король:</p>
        <asp:Image ID="Image5" runat="server" ImageUrl="Images/King.png" ImageAlign="Middle" />
    <p>Чтобы не перепутать местами ферзя и короля следует запомнить простое правило «Ферзь любит свой цвет«. Таким образом белого ферзя следует ставить на белое поле, а черного — на черное. Та сторона доски где в начальной стоят короли называется королевский фланг, а где ферзи — ферзевой.</p>
    <p></p>
    <p>Начальное расположение фигур изображено на картинке:</p>
        <asp:Image ID="Image7" runat="server" ImageUrl="Images/StartPosition.png" ImageAlign="Middle" />
</asp:Content>
