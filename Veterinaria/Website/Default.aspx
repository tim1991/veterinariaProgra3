<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Website._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<header class="hero">
            <div class="container">
            <div class="topbar">
                <ul class="contact">
                    <li>
                        <a href="mailto:info@mundoanimal.com">info@mundoanimal</a>
                    </li>
                    <li>
                        <a href="tel:50688888888">8888-8888</a>
                    </li>
                </ul>
                <ul class="social">
                    <li>
                        <a href="#">Facebook</a>
                    </li>
                    <li>
                        <a href="#">Instagram</a>
                    </li>
                </ul>
            </div>
            <nav>
                <img src="dist/images/logo.png" class="logo" alt="">
                <ul>
                    <li>
                        <a href="#">Inicio</a>
                    </li>
                    <li>
                        <a href="#">Nosotros</a>
                    </li>
                    <li>
                        <a href="#">Agendar cita</a>
                    </li>
                    <li>
                        <a href="#">Tienda</a>
                    </li>
                </ul>
            </nav>
            <div class="captionHero">
                <p>// Lorem ipsum amed //</p>
                <h2>Mantenemos felices <br> a tus mascotas.</h2>
                <a class="btn btn-pink">Reservar una cita</a>
                <a class="btn btn-green">Tienda</a>
            </div>
        </div>
    </header>
    <section class="container">
        <div class="row">
            <div class="col-12 col-md-6">
                <img class="img-fluid" src="dist/images/img01.png" alt="">
            </div>
            <div class="col-12 col-md-6">
                <h3>Titulo </h3>
                <p>Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit..."
                    "There is no one who loves pain itself, who seeks after it and wants to have it, simply because it
                    is pain...</p>
            </div>
        </div>
    </section>
<form id="form1" runat="server">
    <section class="container-fluid bg-pink">
        <div class="container">
            <div class="row">
                <div class="col-col-12 col-md-6">
                    <h3>Agendar una cita</h3>
                </div>
                <div class="col-col-12 col-md-6">
                    <div class="form-group">
                        <label for="">Tipo de servicio</label>
                        <asp:TextBox ID="txtServicio" class="form-control" runat="server" OnTextChanged="txtServicio_TextChanged"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="">Fecha</label>
                        <asp:TextBox ID="txtFecha" class="form-control" runat="server" OnTextChanged="txtServicio_TextChanged"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="">Cliente</label>
                        <asp:TextBox ID="txtCliente" class="form-control" runat="server" OnTextChanged="txtServicio_TextChanged"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Button ID="Button1" class="btn btn-success"  runat="server" Text="Agendar" OnClick="Button1_Click1" />
                    </div>
                   

                </div>
            </div>
        </div>
    </section>
        <div>
            &nbsp;</div>
     <section class="container-fluid" style="background: #90c424;padding-top:20px;padding-bottom:20px">
     <div class="container" >
         <div class="row">
                <div class="col-12 col-md-6">
                <h2>Consultar citas</h2>
                 <p>
                     
                     <asp:TextBox class="form-control" ID="txtCedula" runat="server"></asp:TextBox>
                     <asp:Button ID="btnBuscar" class="btn btn-info" runat="server" OnClick="btnBuscar_Click" Text="Consultar citas por cédula" />
                 </p>
           </div>
               <div class="col-12 col-md-6">
                   <h2>Mis citas</h2>
                     <ul class="list-group">
                         <% foreach (var cita in misCitas){ %>
                         <li class="list-group-item" ><%= cita.fechacita %> <%= cita.servicio %> <%= cita.nombrePersona %></li>

                         <% } %>
                     </ul>
                </div>
         </div>
         </div>
     </section>
    </form>
     </asp:Content>
