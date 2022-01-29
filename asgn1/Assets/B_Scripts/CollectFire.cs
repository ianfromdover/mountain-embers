using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectFire : MonoBehaviour
{
    public GameObject holdingTorch;
    public GameObject campfire;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Fire Stick"))
        {
            other.gameObject.SetActive(false);
            holdingTorch.SetActive(true);
        }
        else if (other.gameObject.CompareTag("Campfire")) 
        {
            holdingTorch.SetActive(false);
            // make campfire bigger
            // UI noOfSticksLeft--;
            // UI make targeting reticle
        }
    }
}
