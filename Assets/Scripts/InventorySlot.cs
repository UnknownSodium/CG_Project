using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    Item item;
    public Image icon;

    public void AddItem(Item newItem) //add item to inventory for UI
    {
        item = newItem;
        icon.sprite = item.icon;
        icon.enabled = true;
        Debug.Log("Added item to slot");
    }

    public void ClearItem() //remove item from inventory for UI
    {
        item = null;
        icon.sprite = null;
        icon.enabled = false;
    }
}