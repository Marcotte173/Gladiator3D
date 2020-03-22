using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadPlayersIntoFight : MonoBehaviour
{
    public List<GameObject> manequins;
    public List<Toggle> toggles;
    public List<GameObject> summon;

    private void Update()
    {
        for (int i = 0; i < toggles.Count; i++)
        {
            if (toggles[i].isOn && !summon.Contains(manequins[i])) summon.Add(manequins[i]);
            if (!toggles[i].isOn) summon.Remove(manequins[i]);
        }
    }
    public void Go()
    {    
        if (summon.Count > 0 && summon.Count < 4)
        {
            foreach (GameObject g in summon)
                GameInfo.summon.Add(g);
            SceneManager.LoadScene("First Fight");
        }                  
    }
    public void Go2()
    {
        if (summon.Count > 0 && summon.Count < 4)
        {
            foreach (GameObject g in summon)
                GameInfo.summon.Add(g);
            SceneManager.LoadScene("Arena");
        }
    }
}