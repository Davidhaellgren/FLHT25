using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL_egg;

public class Egg
{
    private static readonly Random _random = new();
    public int Id { get; }

    public bool IsFertile { get; private set; } = false;         // Vi sätter startvärdet till False

    public override string ToString()
    {
        string result = "är fertilt";
        
        if (!IsFertile)
        {
            result = "är inte fertilt";
        }

        return $"Ägg {Id} {result} ";
    }

    public Chicken Hatch()
    {
        // kolla om  ägget är fetilt
        // om så, kläck och kyckling

        if (IsFertile)
        {
            return new Chicken(Id);
        }
        return null;
    }

    public Egg(int eggId)
    {
        Id = eggId;
        IsEggFertile();
    }

    private void IsEggFertile()
    {
        // Smart kod för att göra ägget ruttet eller inte
        double probability = _random.NextDouble();
        if (probability < 0.9)
        {
            IsFertile = true;
        }
        else
        {
            IsFertile = false;
        }
    }
}
