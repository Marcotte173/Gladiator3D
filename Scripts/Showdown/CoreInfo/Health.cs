using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    float maxHp;
    float hp;
    float pR;
    float mR;
    CharacterInfo info;
    Bars bar;

    void Start()
    {
        bar = GetComponentInChildren<Bars>();
        info = GetComponent<CharacterInfo>();
        pR = GetComponent<CharacterInfo>().physicalReduction.value;
        mR = GetComponent<CharacterInfo>().magicReduction.value;
        hp = maxHp = GetComponent<CharacterInfo>().maxHP.value;
    }

    public void TakePhysicalDamage(float damage, float penetration)
    {
        float reduction = (pR - penetration <= 0) ? 0 : pR - penetration;
        damage = (damage - reduction <= 0) ? 0 : damage - reduction;
        hp = (hp - damage <= 0) ? 0 : hp - damage;
        bar.SetHealth(hp / maxHp);
        if (hp == 0) Death();
    }
    public void TakeMagicDamage(float damage, float penetration)
    {
        float reduction = (mR - penetration <= 0) ? 0 : mR - penetration;
        damage = (damage - reduction <= 0) ? 0 : damage - reduction;
        hp = (hp - damage <= 0) ? 0 : hp - damage;
        bar.SetHealth(hp / maxHp);
        if (hp == 0) Death();
    }

    private void Death()
    {
        if (info.player) TeamList.teamA.Remove(this.gameObject);
        else TeamList.teamB.Remove(this.gameObject);
        Destroy(gameObject);
    }

    public void Heal(float heal)
    {
        hp = (heal + hp >= maxHp) ? maxHp : heal + hp;
        bar.SetHealth(hp / maxHp);
    }
}