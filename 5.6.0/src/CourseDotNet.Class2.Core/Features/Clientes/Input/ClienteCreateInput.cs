using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseDotNet.Class2.Features.Clientes.Input
{
    public class ClienteCreateInput
    {
        public string PrimerNombre { get; set; }

        public string Apellido { get; set; }

        public int Edad { get; set; }

        public string Identidad { get; set; }

        public string Direccion { get; set; }

        public string Telefono { get; set; }
    }
}
