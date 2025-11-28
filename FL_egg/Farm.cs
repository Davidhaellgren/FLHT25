using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL_egg;
// I den här klassen lägger vi all kod som stur logiken
public class Farm
{
    private List<Egg> _eggs = new();
    public Farm()
    {
        //BuyEgg(100); // köper 100 ägg när farmen startar
    }

    public void BuyEgg(int count)
    {
        for (int i = 0; i <= count; i++)
        {
            Egg egg = new(i);
            _eggs.Add(egg);
        }
    }

    public Chicken HatchEgg(Egg egg)
    {
        Chicken chicken = egg.Hatch();
        _eggs.Remove(egg);
        return chicken;
    }

    public List<Egg> GetFertileEgg()
    {
        List<Egg> fertiles = new();
        // uppdrag. Plocka fram alla fertila ägg
        foreach (Egg egg in _eggs)
        {
            // om ägget är IsFertile
            if (egg.IsFertile)
            {
                fertiles.Add(egg);
            }
        }
        return fertiles;
    }
}
