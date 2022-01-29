using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldTorch : MonoBehaviour
{
    public Transform grabPos;
    public float followSpeed = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        GetComponent<Rigidbody>().velocity = followSpeed * (grabPos.position - transform.position);
    }
}
