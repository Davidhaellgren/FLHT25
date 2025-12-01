using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotterWS;

public class Hogwarts
{
    public List<Wizard> Wizards { get; set; } = new();

    // Skapa en metod som hämtar ut alla trollkarlar
    // som äger en stav som är mellan 22 och 23,5 cm lång

    public bool IsWandLongEnough()
    {
        foreach (Wizard wizard in Wizards)
        {
            if (wizard.Wand.Length >= 22 && wizard.Wand.Length <= 23.5)
            {
                return true;
            }
        }
        return false;
    }
}
