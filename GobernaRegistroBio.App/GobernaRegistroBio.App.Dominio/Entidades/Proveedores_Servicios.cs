using System;
namespace GobernaRegistroBio.App.Dominio
{
    public class Proveedores_Servicios : Persona
    {
        public int Id_proveedores {get; set;}

        public string Servicio_Realizado {get; set;}

        public string Unidad_Servicio {get; set;}
    }
}