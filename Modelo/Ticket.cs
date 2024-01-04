using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Ticket
    {


        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Rut { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public Cliente Cliente { get; set; }

        public string PersonaEmpresa { get; set; }
        public bool SoporteTecnico { get; set; }
        public bool Reparacion { get; set; }
        public bool Devolucion { get; set; }
        public string Producto { get; set; }
        public string Descripcion { get; set; }
        public DateTime CreatedAt { get; set; }
    }

}


