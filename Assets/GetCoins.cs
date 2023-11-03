using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GetCoins : MonoBehaviour
{
    public TextMeshProUGUI label;
    private int number;
    // Start is called before the first frame update
    void Start()
    {

        number = 0;
        Debug.Log(number);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void collectCoin()
    {
        number = number + 1;
        label.text = number.ToString() + "";
    }
}
