using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotterWS;

public class Olliwanders
{
    private static readonly Random random = new();
    public Wand BuyWand(Wizard wizard)
    {
        int baseLength = random.Nextdouble(20, 26);

        Wand wand = new()
        {
            Name = $"{wizard.Name}s stav",
            Length = baseLength + decimal
        };
    }
}
