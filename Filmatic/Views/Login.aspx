<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Filmatic.Views.Session.Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<main class="d-flex justify-content-center align-items-center" style="min-height: 80vh;">
        <div class="card shadow-lg p-4" style="width: 100%; max-width: 400px;">
            <div class="card-body">
                <h2 class="text-center mb-4">Iniciar Sesión</h2>
                
                <asp:Literal ID="ErrorMessage" runat="server" Visible="false" />

                <div class="form-group">
                    <label for="Username">Nombre de Usuario</label>
                    <asp:TextBox ID="Username" runat="server" CssClass="form-control" placeholder="Ingresá tu usuario" required="required"></asp:TextBox>
                </div>
                <div class="form-group mt-3">
                    <label for="Password">Contraseña</label>
                    <asp:TextBox ID="Password" runat="server" TextMode="Password" CssClass="form-control" placeholder="Ingresá tu contraseña" required="required"></asp:TextBox>
                </div>

                <div class="d-grid mt-4">
                    <asp:Button ID="LoginButton" runat="server" Text="Iniciar Sesión" CssClass="btn btn-primary btn-block" OnClick="LoginButton_Click" />
                </div>

                <div class="text-center mt-3">
                    <p class="small">¿Olvidaste tu contraseña? <a href="#">Recuperar</a></p>
                </div>
            </div>
        </div>
    </main>

</asp:Content>
