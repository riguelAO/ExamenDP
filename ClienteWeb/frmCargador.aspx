<%@ Page Title="" Language="C#" MasterPageFile="~/Examen.Master" AutoEventWireup="true" CodeBehind="frmCargador.aspx.cs" Inherits="ClienteWeb.frmCargador" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <meta charset="utf-8" />
        <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
        <meta name="description" content="" />
        <meta name="author" content="" />
        <!-- Favicon-->
        <link rel="icon" type="image/x-icon" href="Content/assets/favicon.ico" />
        <!-- Font Awesome icons (free version)-->
        <script src="https://use.fontawesome.com/releases/v5.15.3/js/all.js" crossorigin="anonymous"></script>
        <!-- Google fonts-->
        <link href="https://fonts.googleapis.com/css?family=Montserrat:400,700" rel="stylesheet" type="text/css" />
        <link href="https://fonts.googleapis.com/css?family=Lato:400,700,400italic,700italic" rel="stylesheet" type="text/css" />
        <!-- Core theme CSS (includes Bootstrap)-->
        <link href="Content/css/styles.css" rel="stylesheet" />
    <!-- Navigation-->
        <nav class="navbar navbar-expand-lg bg-secondary text-uppercase fixed-top" id="mainNav">
            <div class="container">
                <a class="navbar-brand" href="#page-top">CRUD de la tabla Region </a>
                <button class="navbar-toggler text-uppercase font-weight-bold bg-primary text-white rounded" type="button" data-bs-toggle="collapse" data-bs-target="#navbarResponsive" aria-controls="navbarResponsive" aria-expanded="false" aria-label="Toggle navigation">
                    Menu
                    <i class="fas fa-bars"></i>
                </button>
                <div class="collapse navbar-collapse" id="navbarResponsive">
                    <ul class="navbar-nav ms-auto">
                        <li class="nav-item mx-0 mx-lg-1"><a class="nav-link py-3 px-0 px-lg-3 rounded" href="Default.aspx">Inicio</a></li>
                        <li class="nav-item mx-0 mx-lg-1"><a class="nav-link py-3 px-0 px-lg-3 rounded" href="Empleado.aspx">Empleado</a></li>
                        <li class="nav-item mx-0 mx-lg-1"><a class="nav-link py-3 px-0 px-lg-3 rounded" href="frmCargador.aspx">Cargador</a></li>
                       
                    </ul>
                </div>
            </div>
        </nav>
    <!-- Masthead-->
        <header class="masthead bg-primary text-white text-center">
            <div class="container d-flex align-items-center flex-column">

                <!-- Masthead Heading-->
                <h1 class="masthead-heading text-uppercase mb-0">CRUD</h1>
                <!-- Icon Divider-->
                <div class="divider-custom divider-light">
                    <div class="divider-custom-line"></div>
                    <div class="divider-custom-icon"><i class="fas fa-star"></i></div>
                    <div class="divider-custom-line"></div>
                </div>
                </div>
            <p>
    <h1>CRUD de la tabla Cargador</h1>
    <p>
        Id:<asp:TextBox runat="server" Id="txtId" CssClass="tex"/>
            <style>
                        .tex, select {
                            width: 20%;
                            padding: 12px 20px;
                            margin: 8px 0;
                            display: inline-block;
                            box-sizing: border-box;
                            border: none;
                            background-color: #2C3E50;
                            color: white;
                    </style>/>
    </p>
    <p>
        Nombre de compañia: <asp:TextBox runat="server" Id="txtNombreCom" CssClass="tex"/>
    </p>
    <p>
        Celular: <asp:TextBox runat="server" Id="txtCelular" CssClass="tex"/>
    <p>
        <asp:Button Text="Agregar" runat="server" Id="btnAgregar" OnClick="btnAgregar_Click" CssClass="btn"/>
        <asp:Button Text="Eliminar" runat="server" Id="btnEliminar" OnClick="btnEliminar_Click" CssClass="btn"/>
        <asp:Button Text="Actualizar" runat="server" Id="btnActualizar" OnClick="btnActualizar_Click" CssClass="btn"/>
        <style>
             .btn {
                 background-color: #2C3E50; /* Green */
                 border: none;
                 color: white;
                 padding: 15px 32px;
                 text-align: center;
                 text-decoration: none;
                 display: inline-block;
                 font-size: 16px;
                 margin: 4px 2px;
                 cursor: pointer;
                 -webkit-transition-duration: 0.4s; /* Safari */
                 transition-duration: 0.4s;
             }
             .btn, hover{
                 box-shadow: 0 12px 16px 0 rgba(25,0,0,0.24),0 17px 50px 0 rgba(0,0,0,0.19);
             color: white;
             }
                    </style>
    </p>
    <p>
        Buscar: <asp:TextBox runat="server" ID="txtBuscar" />
        <asp:DropDownList runat="server" ID="ddlCriterio">
            <asp:ListItem Text="Id" />
            <asp:ListItem Text="Nombre de compañia" />
            <asp:ListItem Text="Celular" />
        </asp:DropDownList>
        <asp:Button Text="Buscar" runat="server" ID="btnBuscar" OnClick="btnBuscar_Click" CssClass="btn"/>
    </p>
    <p>
        <asp:GridView runat="server" Id="gvCargador" CssClass="grid "></asp:GridView>
        <style>
            .grid {
                margin: 0 auto;
                font-size: 14px;
                text-align: center;
                color: black;
                width: 80%;
                border: solid 2px black;
                min-width: 80%;
            }
          

           
        </style>
    </p>
    </header>
    </header>
</asp:Content>
