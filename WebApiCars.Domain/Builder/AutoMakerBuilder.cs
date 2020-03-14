using System;

namespace WebApiCars.Domain.Builder
{
    public class AutoMakerBuilder : IAutoMakerBuilder
    {
        private Guid _id;
        private string _name;
        private string _country;

        public AutoMaker Build() => new AutoMaker(_id, _name, _country);

        public IAutoMakerBuilder WithCountry(string country)
        {
            _country = country;
            return this;
        }

        public IAutoMakerBuilder WithId(Guid id)
        {
            _id = id;
            return this;
        }

        public IAutoMakerBuilder WithName(string name)
        {
            _name = name;
            return this;
        }
    }
}