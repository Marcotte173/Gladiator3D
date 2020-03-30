using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

[Serializable]
public class CharacterAttribute
{
    //The base, unmodified value of the attribute
    public float baseValue;
    //The total value after all modifiers
    public float value { get { return CalculateTotal(); } }

    //A list of modifiers to add to the base stat
    private readonly List<StatModifier> _statModifiers;
    public readonly ReadOnlyCollection<StatModifier> statModifiers;

    //constructor
    public CharacterAttribute()
    {
        _statModifiers = new List<StatModifier>();
        statModifiers = _statModifiers.AsReadOnly();
    }

    //Another constructor, but this one takes a value to set the base value of the stat.
    public CharacterAttribute(float value) : this()
    {
        baseValue = value;
    }

    //Add a stat modifier to the list. 
    public void AddModifier(StatModifier mod)
    {
        _statModifiers.Add(mod);
    }

    //Removes a modifier from the list.
    public bool RemoveModifier(StatModifier mod)
    {
        return _statModifiers.Remove(mod);
    }

    //removes all of the modifiers provided by a single source from the list of modifiers. 
    public bool RemoveAllModifiersFromSource(object source)
    {
        bool didRemove = false;

        for (int i = _statModifiers.Count - 1; i >= 0; i--)
        {
            if (_statModifiers[i].source == source)
            {
                _statModifiers.RemoveAt(i);
                didRemove = true;
            }
        }

        return didRemove;
    }

    //calculates the total value of the base plus all modifiers. 
    private float CalculateTotal()
    {
        float finalValue = baseValue;

        foreach (StatModifier sm in statModifiers)
        {
            finalValue += sm.value;
        }

        return finalValue;
    }

}
