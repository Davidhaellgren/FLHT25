using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotterWS;

public class Wizard
{
    public string Name { get; set; }
    public bool HasWand { get; set; }
    public Wand? Wand { get; set; } // Den här egenskapen kan vara null = trollkarlen saknar stav

    public int GetNameLength(Wizard wizard)
    {
        int letterCount = 0;

        foreach (char ch in wizard.Name)
        {
            if (char.IsLetter(ch))
            {
                letterCount++;
            }
        }
        return letterCount;
    }
}