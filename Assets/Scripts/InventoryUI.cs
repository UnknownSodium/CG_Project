using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Initiate UI");
        if (Inventory.instance.items.Count > 0)
           UpdateUI();
        Inventory.instance.onItemChangedCallback += UpdateUI;

    }
    void UpdateUI()
    {
        GameObject itemsParent = GameObject.Find("InventoryCanvas");
        InventorySlot[] slots = itemsParent.GetComponentsInChildren<InventorySlot>();
        for (int i = 0; i < slots.Length; i++)
        {
            //check the space of inventory, if exceed the limit will not add.
            if (i < Inventory.instance.items.Count)
                slots[i].AddItem(Inventory.instance.items[i]);
            else
                slots[i].ClearItem();
        }
    }
}