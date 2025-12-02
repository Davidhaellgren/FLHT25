using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL_egg;

public class Coupe
{
    public int Capacity { get; }
    public bool IsFull => Chickens.Count >= Capacity;
    public bool HasCapacityLeft => !IsFull;
    public List<Chicken> Chickens { get; set; } = new();

    public Coupe(int capacity)
    {
        Capacity = capacity;
    }

    public bool TryAddChicken(Chicken chicken)
    {
        if (!IsFull)
        {
            Chickens.Add(chicken);
            return true;
        }
        return false;
    }
}
