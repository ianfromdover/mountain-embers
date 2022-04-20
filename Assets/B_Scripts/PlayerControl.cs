using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    /**
     * The player and the sphere are siblings, but the player uses
     * the sphere to move. This script links them.
     * 
     * Moving the player relative to the camera was referenced from Okido from
     * https://forum.unity.com/threads/moving-character-relative-to-camera.383086/
     */
    private Rigidbody rb;
    public float speed;
    public float turnSpeed;
    public float boostMultiplier;

    public GameObject sphere;
    private Rigidbody sphereRb;
    private Vector3 sphereOffsetToParent;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        sphereRb = sphere.GetComponent<Rigidbody>();
        sphereOffsetToParent = transform.position - sphere.transform.position;

        // Lock player's mouse to game
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // the camera doesn't work when it is fixedupdate for some reason
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        bool isBoosting = Input.GetButton("Boost");


        Vector3 dir = new Vector3(moveHorizontal, 0.0f, moveVertical);
        Vector3 camDirection = Camera.main.transform.rotation * dir; // gets all 3 axes of camera
        Vector3 tgtDirection = new Vector3(camDirection.x, 0, camDirection.z); // only move horizontally

        if (dir != Vector3.zero) { // when got input, turn sphere to face camera's direction
            // Dampen from current rotation to target rotation
            sphere.transform.rotation = Quaternion.Slerp(transform.rotation,
                                                  Quaternion.LookRotation(tgtDirection),
                                                  Time.deltaTime * turnSpeed);
        }

        // translate forwards
        float boost = isBoosting ? boostMultiplier : 1;
        sphereRb.AddForce(tgtDirection.normalized * speed * boost); // normalized prevents extra speed when diagonal input is present

        // rotate the character to face the camera direction
        transform.Rotate(0, Input.GetAxis("Mouse X"), 0);
    }

    void LateUpdate() {
        // move model body to the sphere
        transform.position = sphere.transform.position + sphereOffsetToParent;
    }
}