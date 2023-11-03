using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Heal : MonoBehaviour
{
    public Image hpbar;
    private bool healing = false;
    private float healAmount = 0.5F;
    private float healAmountTick = 0.01F;
    private float healBound;
    public float waitTime = 0.5f;


    // Start is called before the first frame update
    void Start()
    {
        hpbar.fillAmount = 1.0F;
    }

    // Update is called once per frame
    void Update()
    {
        if (healing && hpbar.fillAmount < healBound && hpbar.fillAmount < 1.0F)
        {
            hpbar.fillAmount += healAmountTick;
        }
        else
        {
            healing = false;
            hpbar.color = Color.red;
        }
    }

    public void HealOnClick()
    {
        if (hpbar.fillAmount < 1.0F)
        {
            healing = !healing;
            hpbar.color = Color.green;
            healBound = hpbar.fillAmount + healAmount;
        }
    }
}
