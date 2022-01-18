using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public bool isPickup;
    private float multiplier;

    void Start()
    {
        if (isPickup)
        {
            multiplier = 1;
        }
        else 
        {
            multiplier = 0;
        }
    }
    void Update()
    {
        transform.Rotate(multiplier * new Vector3(15, 30, 45) * Time.deltaTime);
    }
    
    public void spinFaster()
    {
        if (!isPickup)
        {
            multiplier += 0.1f;
        }
    }
}
