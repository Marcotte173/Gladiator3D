using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Info : MonoBehaviour
{
    public Text nameText;
    new public string name;    
    public string team;
    public int hp;
    public float energy;
    public int damage;
    public int hit;
    public int crit;
    public int defence;
    public int mitigation;
    public float range;
    public float attackSpeed;
    public int size;
    
    // Start is called before the first frame update
    void Start()
    {
        if (name == "") name = Names.Return();
        gameObject.name = name;
        nameText.text = name;
    }
}
