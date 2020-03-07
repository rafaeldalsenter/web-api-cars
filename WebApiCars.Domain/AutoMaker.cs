using System;
using WebApiCars.Domain.Base;

namespace WebApiCars.Domain
{
    public class AutoMaker : BaseDomain
    {
        public AutoMaker(Guid id, string name)
        {
            AddId(id);
            AddName(name);
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

        public void AddName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                AddError("Modelo não pode ser vazio");
                return;
            }

            Name = name;
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
    }
}