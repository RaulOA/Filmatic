using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Filmatic.Data; // Aquí hacemos referencia a nuestro DbContext

namespace Filmatic.Views.Session
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Esta lógica se ejecuta cuando se carga la página
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            string username = Username.Text.Trim();  // Obtenemos el nombre de usuario ingresado
            string password = Password.Text.Trim();  // Obtenemos la contraseña ingresada

            try
            {
                using (var context = new FilmaticContext())  // Usamos el DbContext para conectarnos a la BD
                {
                    // Llamamos al método del contexto que ejecuta el SP para verificar el usuario
                    bool isValidUser = context.VerificaUsuario(username, password);

                    if (isValidUser)
                    {
                        // Si el login es exitoso, redirigimos a la página principal
                        Response.Redirect("~/Home.aspx");
                    }
                    else
                    {
                        // Si las credenciales son incorrectas, mostramos un mensaje de error
                        ErrorMessage.Text = "Usuario o contraseña incorrectos.";
                        ErrorMessage.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejamos cualquier error que ocurra durante la autenticación
                ErrorMessage.Text = "Ocurrió un error al intentar iniciar sesión. Inténtalo de nuevo.";
                ErrorMessage.Visible = true;
                // Aquí podrías loggear el error
                Console.WriteLine(ex.Message);
            }
        }
    }
}
