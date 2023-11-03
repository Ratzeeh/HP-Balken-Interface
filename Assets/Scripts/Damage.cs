using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Damage : MonoBehaviour
{
    public Image hpbar;
    private bool dealingDmg = false;
    private float dmgAmount = 0.2F;
    private float dmgAmountTick = 0.01F;
    private float dmgBound;
    public float waitTime = 1.0f;
    

    // Start is called before the first frame update
    void Start()
    {
         hpbar.fillAmount = 1.0F;
    }

    // Update is called once per frame
    void Update()
    {
        if (dealingDmg && hpbar.fillAmount > dmgBound)
        {
            hpbar.fillAmount -= dmgAmountTick;
        }
        else
        {
            dealingDmg = false;
        }
    }

    public void TaskOnClick()
    {
        dealingDmg = !dealingDmg;
        dmgBound = hpbar.fillAmount - dmgAmount;
    }
}
