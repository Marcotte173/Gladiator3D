using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bars : MonoBehaviour
{
    public Image healthBar;
    public Image energyBar;
    // Start is called before the first frame update
    void Start()
    {
        SetHealth(1f);
        SetEnergy(0f);
    }

    public void SetHealth(float value)
    {
        healthBar.fillAmount = value;
    }
    public void SetEnergy(float value)
    {
        energyBar.fillAmount = value;
    }
}
