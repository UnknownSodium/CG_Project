using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
    public Text wintext;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other){
        if(other.tag == "Player" && Inventory.instance.items.Count == 3){
            Debug.Log("EndGame!");
            wintext.gameObject.SetActive(true);
        }
    }

    /*private void OnTriggerExit(Collider other){
        if(other.tag == "Player" && Inventory.instance.items.Count == 3){
            wintext.gameObject.SetActive(false);
        }
    }
    */
}
