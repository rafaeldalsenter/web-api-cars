using System;

namespace WebApiCars.Domain.Builder
{
    public interface ICarBuilder
    {
        Car Build();

        ICarBuilder WithId(Guid id);

        ICarBuilder WithModel(string model);

        ICarBuilder WithYear(short year);

        ICarBuilder WithFeatures(string features);
    }
}