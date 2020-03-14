using System;
using WebApiCars.Domain.Base;

namespace WebApiCars.Domain
{
    public class AutoMaker : BaseDomain
    {
        public AutoMaker(Guid id, string name, string country)
        {
            AddId(id);
            AddName(name);
            AddCountry(country);
        }

        public void AddCountry(string country)
        {
            if (string.IsNullOrWhiteSpace(country))
            {
                AddError("Country is invalid");
                return;
            }

            Country = country;
        }

        public void AddId(Guid id)
        {
            if (id == default)
            {
                AddError("Id value is invalid");
                return;
            }

            Id = id;
        }

        public void AddName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                AddError("Name is invalid");
                return;
            }

            Name = name;
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Country { get; private set; }
    }
}