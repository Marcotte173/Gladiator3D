using System.Collections;
using System;
using UnityEngine;

public class CombatInfoUI : MonoBehaviour
{
    public GameObject damageNumbers;

    internal void Miss()
    {
        var clone = Instantiate(damageNumbers, transform.position, Quaternion.Euler(Vector3.zero));
        clone.GetComponent<DamageNumbers>().number.fontSize = 1;
        clone.GetComponent<DamageNumbers>().number.color = Color.white;
        clone.GetComponent<DamageNumbers>().number.text = "Miss";
    }
    internal void Hit(int damage, Attack a)
    {
        var clone = Instantiate(damageNumbers, transform.position, Quaternion.Euler(Vector3.zero));
        clone.GetComponent<DamageNumbers>().number.text = damage.ToString();
        CombatLog.instance.log.Add($"{a.GetComponent<Info>().name} hits {GetComponent<Info>().name} for {damage} damage!");
    }
    internal void Crit(int damage, Attack a)
    {
        var clone = Instantiate(damageNumbers, transform.position, Quaternion.Euler(Vector3.zero));
        damage = Convert.ToInt32(damage * 1.5f);
        clone.GetComponent<DamageNumbers>().number.text = damage.ToString();               
        clone.GetComponent<DamageNumbers>().number.color = Color.red;
        clone.GetComponent<DamageNumbers>().number.fontSize = 2;
        CombatLog.instance.log.Add($"{a.GetComponent<Info>().name} critically hits {GetComponent<Info>().name} for {damage} damage!");
    }
    internal void Fireball(int damage, Attack a)
    {
        var clone = Instantiate(damageNumbers, transform.position, Quaternion.Euler(Vector3.zero));
        clone.GetComponent<DamageNumbers>().number.text = damage.ToString();
        clone.GetComponent<DamageNumbers>().number.color = Color.cyan;
        CombatLog.instance.log.Add($"{a.GetComponent<Info>().name}'s fireball hits {GetComponent<Info>().name} for {damage} damage!");
    }
    internal void Stealth()
    {
        CombatLog.instance.log.Add($"{gameObject.name} disapears in a puff of smoke!");
    }

    internal void Heal(int heal, Attack a)
    {
        var clone = Instantiate(damageNumbers, transform.position, Quaternion.Euler(Vector3.zero));
        clone.GetComponent<DamageNumbers>().number.text = heal.ToString();
        clone.GetComponent<DamageNumbers>().number.color = Color.green;
        CombatLog.instance.log.Add($"{a.GetComponent<Info>().name} heals {GetComponent<Info>().name} for {heal} hitpoints!");
    }
}
