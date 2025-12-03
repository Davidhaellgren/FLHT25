using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapleScrollSim;

public class Equipment
{
    public string Name { get; set; }
    public int UpgradeCount { get; set; }
    public int MaxSlots { get; set; }
    public bool IsDestroyed { get; set; } = false;
    public Dictionary<string, int> Stats { get; set; } = new();
    public string PrimaryStatName { get; set; }
    public int PrimaryStat { get; set; }

    // public void Print();

    public Equipment(string name, int maxSlots, string primaryStatName, int primaryStat)
    {
        Name = name;
        MaxSlots = maxSlots;
        PrimaryStatName = primaryStatName;
        PrimaryStat = primaryStat;
        IsDestroyed = false;
    }

}
