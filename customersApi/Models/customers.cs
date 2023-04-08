using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customersApi.Models
{
    public class customers
    {
        public int? id { get; set; }
        public string email { get; set; }
        public DateTime fecha { get; set; }
        public string apellido { get; set; }
        public string nombre { get; set; }

    }
}
