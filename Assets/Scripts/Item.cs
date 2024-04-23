using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//blueprint for creating object instance
[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
    new public string name = "New Item"; // name of item
    public Sprite icon = null; //icon of item
    public bool idDefaultItem = false;
}