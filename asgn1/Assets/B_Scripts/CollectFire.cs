using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectFire : MonoBehaviour
{
    public GameObject holdingTorch;
    public GameObject campfire;
    public GameObject[] torchesAtCampfire;
    private static int maxTorches = 6;
    private static int noOfTorches = 0;
    private static int torchesLeft = maxTorches - noOfTorches;

    public int getTorchesLeft() {
        return torchesLeft;
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Fire Stick") && !holdingTorch.activeSelf)
        {
            other.gameObject.SetActive(false);
            holdingTorch.SetActive(true);
        }
        else if (other.gameObject.CompareTag("Campfire")) 
        {
            // make campfire bigger
            holdingTorch.SetActive(false);

            if (noOfTorches < maxTorches) {
                torchesAtCampfire[noOfTorches].SetActive(true);
                noOfTorches++;
                torchesLeft--; // to update UI
            }
            // UI make targeting reticle
        }
    }
}
