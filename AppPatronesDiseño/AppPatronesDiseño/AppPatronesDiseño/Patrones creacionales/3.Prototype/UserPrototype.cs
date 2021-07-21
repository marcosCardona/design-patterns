using System;

namespace AppPatronesDiseño.Patrones_creacionales._3.Prototype
{
    [Serializable]
    public class UserPrototype
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Country CountryOfBirth { get; set; }

        [Serializable]
        public class Country
        {
            public string Name { get; set; }
        }

        public string GetDetails()
        {
            return $"Id: {Id} - FullName: {LastName} {FirstName} - Country Of Birth: {CountryOfBirth.Name}";
        }
    }
}
