using System ; 

namespace GobernaRegistroBio.App.Dominio
{
public class Persona{

        public int Id {get; set;}

        public string Nombre {get; set;}

        public string Apellidos {get; set;}

        public string Identificacion {get; set;}

        public string Edad {get; set;}

        public string Estado {get; set;}

        public string Direccion {get; set;}

        public string Telefono {get; set;}
        
        public string Rol {set; get;}

        public Genero Genero {set; get;}
    }
}