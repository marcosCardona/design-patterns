using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPatronesDiseño.Patrones_creacionales._2.Factory._1.Factory
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Constructor, la idea es deprecar este constructor
        /// </summary>
        private User(int id, string name, DateTime creationDate)
        {
            Id = id;
            Name = name;
            CreationDate = creationDate;
        }

        /// <summary>
        /// Subclase para la asignacion de valores dependiendo de la regla de negocios
        /// </summary>
        public static class Factory
        {
            public static User AddWithoutDate(int id, string name)
            {
                return new User(id, name, DateTime.MinValue);
            }

            public static User AddWithoutName(int id, DateTime creationDate)
            {
                return new User(id, "", creationDate);
            }
        }
    }
}