using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> items = new List<Item>();
    public int space = 3;
    public static Inventory instance;
    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("More than 1 of inventory instance found.");
            return;
        }
        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }
    
    public bool Add(Item item)
    {
        if (!item.idDefaultItem)
        {
            if (items.Count >= space)
            {
                Debug.Log("not enough space");
                return false;
            }
            items.Add(item);
            Debug.Log("Added item");
            if (onItemChangedCallback != null)
                onItemChangedCallback.Invoke();
        }
        return true;
    }
    
    public void Remove(Item item)
    {
        items.Remove(item);
        if (onItemChangedCallback != null)
            onItemChangedCallback.Invoke();
    }
}
