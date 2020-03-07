using System;
using WebApiCars.Domain.Base;

namespace WebApiCars.Domain
{
    public class Car : BaseDomain
    {
        public Car(Guid id, string model, short year, string features)
        {
            AddId(id);
            AddModel(model);
            AddYear(year);
            AddFeatures(features);
        }

        public string Features { get; private set; }
        public Guid Id { get; private set; }
        public string Model { get; private set; }
        public short Year { get; private set; }

        public void AddFeatures(string features)
        {
            Features = features;
        }

        public void AddId(Guid id)
        {
            if (id == default)
            {
                AddError("Faltou preencher o valor Id");
                return;
            }

            Id = id;
        }

        public void AddModel(string model)
        {
            if (string.IsNullOrWhiteSpace(model))
            {
                AddError("Modelo não pode ser vazio");
                return;
            }

            Model = model;
        }

        public void AddYear(short year)
        {
            if (year <= 1700 || year > DateTime.Now.AddYears(1).Year)
            {
                AddError("Ano do modelo inválido");
                return;
            }

            Year = year;
        }
    }
}