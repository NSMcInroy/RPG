using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour {

    List<BaseStat> stats = new List<BaseStat>();

    void Start()
    {
        stats.Add(new BaseStat(4, "Power", "Your power level."));
        stats.Add(new BaseStat(6, "Vitality", "Your vitality level."));
    }

    public void AddStatBonus(List<BaseStat> _StatBonuses)
    {
        foreach (BaseStat _Stat in _StatBonuses)
        {
            stats.Find(_Bonus => _Bonus.StatName == _Stat.StatName).AddStatBonus(new StatBonus(_Stat.BaseValue));
        }
    }

    public void RemoveStatBonus(List<BaseStat> _StatBonuses)
    {
        foreach (BaseStat _Stat in _StatBonuses)
        {
            stats.Find(_Bonus => _Bonus.StatName == _Stat.StatName).RemoveStatBonus(new StatBonus(_Stat.BaseValue));
        }
    }
}
