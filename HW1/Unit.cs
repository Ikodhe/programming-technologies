using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw1
{
    public class Units
    {
        public Guid IdUnits { get; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid IdFactories { get; }
        public Units(string name, string description, Guid factoryId)
        {
            IdUnits = Guid.NewGuid();
            Name = name;
            Description = description;
            if (factoryId == Guid.Empty)
                throw new ArgumentException("FactoryId cannot be empty.");


            IdFactories = factoryId;
        }
        public static Units[] GetUnits(Factories[] factories)
        {
            return new Units[]
            {
                new Units("ГФУ-2", "Газофракционирующая", factories[0].IdFactories),
                new Units("АВТ-6", "Атмосферно-вакуумная трубчатка",  factories[0].IdFactories),
                new Units("АВТ-10", "Атмосферно-вакуумная трубчатка",  factories[1].IdFactories)
            };
        }

    }
}
