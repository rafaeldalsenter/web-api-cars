using System;

namespace WebApiCars.Domain.Builder
{
    public interface IAutoMakerBuilder
    {
        AutoMaker Build();

        IAutoMakerBuilder WithId(Guid id);

        IAutoMakerBuilder WithName(string name);
    }
}