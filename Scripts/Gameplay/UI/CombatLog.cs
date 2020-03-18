using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CombatLog : MonoBehaviour
{
    public static CombatLog instance;
    public List<string> log = new List<string>{};

    private void Start()
    {
        instance = this;
    }

    private void Update()
    {
        while (log.Count > 10) { log.RemoveAt(0); }
        GetComponent<Text>().text = "";
        foreach (string cLog in log)
        {
            GetComponent<Text>().text += $"{cLog}\n";
        }
    }
}
