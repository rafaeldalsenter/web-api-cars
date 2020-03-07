using System;

namespace WebApiCars.Domain.Builder
{
    public class CarBuilder : ICarBuilder
    {
        private Guid _id;
        private string _model;
        private short _year;
        private string _features;

        public Car Build() => new Car(_id, _model, _year, _features);

        public ICarBuilder WithFeatures(string features)
        {
            _features = features;
            return this;
        }

        public ICarBuilder WithId(Guid id)
        {
            _id = id;
            return this;
        }

        public ICarBuilder WithModel(string model)
        {
            _model = model;
            return this;
        }

        public ICarBuilder WithYear(short year)
        {
            _year = year;
            return this;
        }
    }
}