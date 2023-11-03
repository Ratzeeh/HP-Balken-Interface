using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    [SerializeField] private Color selectedIconColor;
    [SerializeField] private Color defaultIconColor;
    public Color DefaultIconColor
    {
        get
        {
            return defaultIconColor;
        }
    }

    [SerializeField] private TextMeshProUGUI itemCountText;
    private int itemCount = 0;


    private void Start()
    {
        itemCountText.text = itemCount.ToString();

        MakeAllIconsDefaultColor();
    }

    private void MakeAllIconsDefaultColor()
    {
        Image[] images = GetComponentsInChildren<Image>(false);
        for(int i = 0; i < images.Length; i++)
        {
            if (images[i].gameObject.name.Contains("Icon"))
                images[i].color = defaultIconColor;
        }
    }

    public void OnItemslotClick(Image _image)
    {
        if (_image.color == defaultIconColor)
        {
            _image.color = selectedIconColor;
            itemCount++;
            itemCountText.text = itemCount.ToString();
        }
        else
        {
            _image.color = defaultIconColor;
            itemCount--;
            itemCountText.text = itemCount.ToString();
        }
    }
}
