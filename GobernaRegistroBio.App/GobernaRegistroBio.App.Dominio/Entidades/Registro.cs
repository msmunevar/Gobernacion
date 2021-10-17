using System;
namespace GobernaRegistroBio.App.Dominio
{
    public class Registro
    {
        public int Id {get; private set;}

        public string Fecha_Diagnostico {get; set;}

        public string Sintomas {get; set;}

        public string Tiempo_Aislamiento {get; set;}

        public string Autoriza_Ingreso {get; set;}

        public Persona persona {get; set;}

        

    }
}