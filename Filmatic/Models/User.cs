namespace Filmatic.Models
{
    public class User
    {
        public int Id { get; set; }           // Identificador único del usuario (Primary Key)
        public string NombreUsuario { get; set; }  // Nombre del usuario
        public string Contraseña { get; set; }    // Contraseña del usuario
    }
}