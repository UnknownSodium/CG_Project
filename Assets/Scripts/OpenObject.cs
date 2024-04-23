using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenObject : MonoBehaviour
{
    [System.Serializable]
    public class ObjectPair
    {
        public List<GameObject> objectsToDeactivate = new List<GameObject>();
        public List<GameObject> objectsToActivate = new List<GameObject>();
    }

    public List<ObjectPair> objectPairs = new List<ObjectPair>();
    public float interactionDistance = 15f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, interactionDistance))
            {
                foreach (var pair in objectPairs)
                {  
                    if (pair.objectsToDeactivate.Contains(hit.collider.gameObject))
                    {
                        foreach (var obj in pair.objectsToDeactivate)
                        {
                            obj.SetActive(false);
                        }

                        foreach (var obj in pair.objectsToActivate)
                        {
                            obj.SetActive(true);
                        }

                        break;
                    }
                }
            }
        }
    }
}