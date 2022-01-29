using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlYoutube : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
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
}