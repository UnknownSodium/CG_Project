using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class Door : MonoBehaviour
{
    public float InteractionDistance;
    public string doorOpenAnimName, doorCloseAnimName;

    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, InteractionDistance))
        {
            Debug.Log("See thing");
            
            if (hit.collider.gameObject.tag == "Door")
            {

                GameObject doorWing = hit.collider.transform.root.gameObject;
                Animator doorAnim = doorWing.GetComponent<Animator>();
                if (doorWing != null) { Debug.Log("See Door"); }

                if (Input.GetMouseButtonDown(0))
                {

                    Debug.Log("Door Pressed");

                    if (doorAnim.GetCurrentAnimatorStateInfo(0).IsName(doorOpenAnimName))
                    {
                        Debug.Log("Open Door");
                        doorAnim.ResetTrigger("Open");
                        doorAnim.SetTrigger("Close");
                    }

                    if (doorAnim.GetCurrentAnimatorStateInfo(0).IsName(doorCloseAnimName))
                    {

                        doorAnim.ResetTrigger("Close");
                        doorAnim.SetTrigger("Open");
                    }
                }
            }
        }
    }
}