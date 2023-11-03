using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Activation : MonoBehaviour
{
    [SerializeField] private GameObject inventory;
    [SerializeField] private GameObject healthBar;
    [SerializeField] private GameObject coins;

    private void Update()
    {
        // Inventory
        if (Input.GetKeyDown(KeyCode.B))
        {
            if (inventory == null) return;
            if (inventory.activeSelf)
                inventory.SetActive(false);
            else inventory.SetActive(true);
        }

        // Health Bar
        if (Input.GetKeyDown(KeyCode.H))
        {
            if (healthBar == null) return;
            if (healthBar.activeSelf)
                healthBar.SetActive(false);
            else healthBar.SetActive(true);
        }

        // Coins
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (coins == null) return;
            if (coins.activeSelf)
                coins.SetActive(false);
            else coins.SetActive(true);
        }
    }
}
