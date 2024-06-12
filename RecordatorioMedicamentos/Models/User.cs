using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordatorioMedicamentos.Models
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string CorreoUsuario { get; set; }
        public string Contrasena { get; set; }
        public string NombresUsuario { get; set; }

        public DateTime FechaNacimiento { get; set; }
    }
}
