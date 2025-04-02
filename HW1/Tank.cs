using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hw1;

namespace Hw1
{
    public class Tank
    {
        public Guid IdTank { get; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Volume { get; set; }
        public int MaxVolume { get; set; }
        public Guid IdUnits { get; }
        public Tank(string name, string description, int volume, int maxVolume, Guid unitsId)
        {
            IdTank = Guid.NewGuid();
            Name = name;
            Description = description;
            Volume = volume;
            MaxVolume = maxVolume;
            if (unitsId == Guid.Empty)
                throw new ArgumentException("UnitsId cannot be empty.");

            IdUnits = unitsId;
        }
        public static Tank[] GetTanks(Units[] units)
        {
            return new Tank[]
            {
                new Tank("Резервуар 1", "Надземный-вертикальный", 1500, 2000,units[0].IdUnits),
                new Tank("Резервуар 1", "Надземный-вертикальный", 2500, 3000,units[0].IdUnits),
                new Tank("Резервуар 1", "Надземный-вертикальный", 3000, 3000,units[1].IdUnits),
                new Tank("Резервуар 1", "Надземный-вертикальный", 3000, 3000,units[1].IdUnits),
                new Tank("Резервуар 1", "Надземный-вертикальный", 4000, 5000,units[1].IdUnits),
                new Tank("Резервуар 1", "Надземный-вертикальный", 500, 500,units[2].IdUnits)
            };
        }
    }
}
