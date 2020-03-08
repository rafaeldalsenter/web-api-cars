using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace WebApiCars.Domain.Base
{
    public abstract class BaseDomain
    {
        [NotMapped]
        public IList<string> ErrorMessages { get; private set; }

        public void AddError(string message)
        {
            ErrorMessages ??= new List<string>();

            ErrorMessages.Add(message);
        }

        public bool IsValid() => !ErrorMessages?.Any() ?? true;
    }
}