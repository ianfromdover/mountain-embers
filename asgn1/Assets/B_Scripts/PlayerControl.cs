using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public GameObject holdingTorch;
    public GameObject campfire;
    public float speed;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);

        // friction
        rb.AddForce(new Vector3(moveHorizontal, -1.0f, moveVertical));
    }

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
        }
    }
}
