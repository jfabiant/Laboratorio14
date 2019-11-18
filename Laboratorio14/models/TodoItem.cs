using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio14.models
{
    public class TodoItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
