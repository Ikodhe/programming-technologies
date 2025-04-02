using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw1
{
    public class Factories
    {
        public Guid IdFactories {get;}
        public string Name { get; set; }
        public string Description { get; set; }

        public Factories(string name, string description)
        {
            IdFactories = Guid.NewGuid();
            Name = name; 
            Description = description; 
        }
        public static Factories [] GetFactories()
        {
            return new Factories []
            {
                new Factories("НПЗ№1", "Первый нефтеперерабатывающийй завод"),
                new Factories("НПЗ№2", "Второй нефтеперерабатывающийй завод")
            };
        }

    }
}
