using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using static UnityEditor.Progress;

public class CollectItem : MonoBehaviour
{
    public float interactionDistance = 10f;
    public Item item;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, interactionDistance))
            {
                if (hit.collider.CompareTag("Key"))
                {
                    GameObject clickedObject = hit.collider.gameObject;
                    Debug.Log("Pick up item " + item.name);
                    bool wasPickup = Inventory.instance.Add(item);

                    if (wasPickup)
                        Destroy(clickedObject);

                }
                else
                {
                    Debug.Log("Object clicked, but it's not tagged as Interactable.");
                }

            }
            else
            {
                Debug.Log("No object clicked.");
            }
        }
    }
}
