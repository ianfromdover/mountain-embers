using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    // lab prescribed: follow the player with a fixed offset
    // public GameObject player;
    // private Vector3 offset;
    private float yRotation;

    /*
    void Start()
    {
        // offset = transform.position - player.transform.position;
    }
    */

    void LateUpdate()
    {
        // transform.position = player.transform.position + offset;

        // rotate view according to the mouse
        yRotation -= Input.GetAxis("Mouse Y");
        yRotation = Mathf.Clamp(yRotation, -60, 60); // max 60˚ up or down
        transform.localRotation = Quaternion.Euler(yRotation, 0, 0);
    }
}