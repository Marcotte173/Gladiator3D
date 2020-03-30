using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInfo : MonoBehaviour
{         
    public CharacterAttribute magicDamage;
    public CharacterAttribute physicalDamage;
    public CharacterAttribute magicReduction;
    public CharacterAttribute physicalReduction;
    public CharacterAttribute magicPenetration;
    public CharacterAttribute physicalPenetration;
    public CharacterAttribute maxHP;
    public CharacterAttribute maxEnergy;
    public CharacterAttribute energy;
    public CharacterAttribute range;
    public CharacterAttribute dodge;
    public CharacterAttribute size;
    public CharacterAttribute attackSpeed;
    public CharacterAttribute crit;
    public GameObject front;
    public GameObject back;
    public bool cleave;
    internal bool targetable;
    internal bool canAct;
    public bool player;
    private void Awake()
    {
        targetable = true;
        if (player) TeamList.teamA.Add(this.gameObject);
        else TeamList.teamB.Add(this.gameObject);
    }
}
