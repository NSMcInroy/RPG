using System.Collections;
using System.Collections.Generic;


public class BaseStat
{

    public int BaseValue { get; set; }
    public int FinalValue { get; set; }

    public string StatName { get; set; }
    public string StatDescription { get; set; }

    public List<StatBonus> StatBonuses { get; set; }

    public BaseStat(int _BaseValue, string _StatName, string _StatDescription)
    {
        StatBonuses = new List<StatBonus>();
        BaseValue = _BaseValue;
        StatName = _StatName;
        StatDescription = _StatDescription;
    }

    public void AddStatBonus(StatBonus _StatBonus)
    {
        StatBonuses.Add(_StatBonus);
    }

    public void RemoveStatBonus(StatBonus _StatBonus)
    {
        StatBonuses.Remove(_StatBonus);
        //StatBonuses.Remove(StatBonuses.Find(x => x.BonusValue == _StatBonus.BonusValue));

    }

    public int GetCalculatedStatValue()
    {
        FinalValue = 0;
        StatBonuses.ForEach(bonus => FinalValue += bonus.BonusValue);
        FinalValue += BaseValue;
        return FinalValue;
    }
}
