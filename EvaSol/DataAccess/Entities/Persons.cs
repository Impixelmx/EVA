using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    class Persons
    {
        public Guid IdPersona { get; set; } 
        public string Nombre { get; set; } 
        public string ApellidoPaterno { get; set; } 
        public string ApellidoMaterno { get; set; }
        public string UserId { get; set; } 
        public string Celular { get; set; } 
        public string LadaCel { get; set; } 
        public string EMail { get; set; } 
        public DateTime? FechaNacimiento { get; set; } 
        public string Nacionalidad { get; set; } 
        public string TelefonoOficina { get; set; } 
        public string TelefonoCasa { get; set; } 
        public string LadaCasa { get; set; } 
        public string Calle { get; set; } 
        public string NumExt { get; set; } 
        public string NumInt { get; set; } 
        public string Colonia { get; set; } 
        public string Municipio { get; set; } 
        public string CP { get; set; } 
        public string Ciudad { get; set; } 
        public Guid? IdTipoPais { get; set; } 
        public Guid? IdTipoEstado { get; set; } 
        public string Estado { get; set; }


    }
}
