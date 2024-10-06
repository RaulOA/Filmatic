using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;

namespace Filmatic.Data
{
    public class FilmaticContext : DbContext
    {
        public FilmaticContext() : base("name=FilmaticDB") // Usa la cadena de conexión del Web.config
        {
        }

        // Este método llama al Stored Procedure para verificar el usuario
        public bool VerificaUsuario(string nombreUsuario, string contraseña)
        {
            var resultado = Database.SqlQuery<bool>(
                "sp_VerificaUsuario @NombreUsuario, @Contraseña",
                new SqlParameter("@NombreUsuario", nombreUsuario),
                new SqlParameter("@Contraseña", contraseña)).SingleOrDefault();

            return resultado;
        }
    }
}
