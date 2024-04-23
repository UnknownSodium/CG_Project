using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger3 : MonoBehaviour
{
    public GameManager gm;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Collied");
            gm.ChangeLevelUp();
            Debug.Log("Change to Scene3");
        }
    }
}
