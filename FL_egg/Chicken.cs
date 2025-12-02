using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL_egg;

public class Chicken
{
    public string Name { get; set; } = "Agda";
    public int Id { get; }
    public int EnergyLevel { get; set; }
    public bool IsHungry => EnergyLevel <= 50;
    public bool EnergyIsCriticaly => EnergyLevel <= 10;

    public Chicken(int id)
    {
        EnergyLevel = 100;
        Id = id;
    }

    public void Eat(int energy)
    {
        EnergyLevel += energy;
    }
}
