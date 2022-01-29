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
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // the camera doesn't work when it is fixedupdate for some reason
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);

        // friction
        rb.AddForce(new Vector3(moveHorizontal, -1.0f, moveVertical));
        
        transform.Rotate(0, Input.GetAxis("Mouse X"), 0);
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
