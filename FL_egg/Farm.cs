using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Converters;

namespace FL_egg;
// I den här klassen lägger vi all kod som stur logiken
public class Farm
{
    private List<Egg> _eggs = new();
    public List<Chicken> Chickens { get; set; } = new();
    public List<Coupe> Coupes { get; set; } = new();

    public Farm()
    {
        InitializeCoupes();
        BuyEgg(123);
        HatchAllEggs();
        MoveChickensIntoHouses();
    }

    private void InitializeCoupes()
    {
        Coupes = new Coupe(2);
        Coupes = new Coupe(34);
        Coupes = new Coupe(50);

    }

    private void MoveChickensIntoHouses()
    {
        foreach (Chicken chicken in Chickens)
        {
            foreach (Coupe coupe in Coupes)
            {
                coupe.TryAddChicken(chicken);
            }
        }

    }

    public void BuyEgg(int count)
    {
        for (int i = 0; i <= count; i++)
        {
            Egg egg = new(i);
            _eggs.Add(egg);
        }
    }

    public List<Chicken> HatchAllEggs(int count = 10)
    {
        if (count > _eggs.Count)
        {
            count = _eggs.Count;
        }
        for (int i = 0; i < count; i++)
        //foreach (Egg egg in _eggs.ToList())
        {
            Egg egg = _eggs[i];
            Chicken? chicken = egg.Hatch();
            if (chicken != null)
            {
                Chickens.Add(chicken);
            }

            _eggs.Remove(egg);
        }

        return Chickens;
    }

    public Chicken? HatchEgg(Egg egg)
    {
        Chicken? chicken = egg.Hatch();
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
