using System;

namespace AppPatronesDiseño.Patrones_creacionales._3.Prototype
{
    public class UserICloneable : ICloneable
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Country CountryOfBirth { get; set; }

        public class Country
        {
            public string Name { get; set; }
        }

        public object Clone()
        {
            return (object)new UserICloneable()
            {
                Id = this.Id,
                FirstName = this.FirstName,
                LastName = this.LastName,
                CountryOfBirth = this.CountryOfBirth
            };
        }

        public string GetDetails()
        {
            return $"Id: {Id} - FullName: {LastName} {FirstName} - Country Of Birth: {CountryOfBirth.Name}";
        }
    }
}