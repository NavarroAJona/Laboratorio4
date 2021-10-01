using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Planetario.Models
{
    public class FuncionarioModel
    {
        public long NumeroIdentificacion { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Correo { get; set; }
        public string Pais { get; set; }
        public string Telefono { get; set; }
        public string Descripcion { get; set; }
        public string TituloAcademico { get; set; }
        public string Ocupacion { get; set; }
        public string Genero { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public List<string> Idiomas { get; set; }

        public FuncionarioModel()
        {

        }
    }
}