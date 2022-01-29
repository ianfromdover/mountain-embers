using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldTorch : MonoBehaviour
{
    public Transform grabPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        GetComponent<Rigidbody>().velocity = 9 * (grabPos.position - transform.position);
    }
}
