using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) StartMatch();
    }
    public void StartMatch()
    {
        foreach (GameObject g in TeamList.teamA) g.GetComponent<CharacterInfo>().canAct = true;
        foreach (GameObject g in TeamList.teamB) g.GetComponent<CharacterInfo>().canAct = true;
    }
    public void EndMatch()
    {
        foreach (GameObject g in TeamList.teamA) g.GetComponent<CharacterInfo>().canAct = false;
        foreach (GameObject g in TeamList.teamB) g.GetComponent<CharacterInfo>().canAct = false;
    }
}
