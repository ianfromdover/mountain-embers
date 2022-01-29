using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject player;
    private float yRotation;
    // private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        // offset = transform.position - player.transform.position;
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // transform.position = player.transform.position + offset;
        yRotation -= Input.GetAxis("Mouse Y");
        yRotation = Mathf.Clamp(yRotation, -60, 60);
        transform.localRotation = Quaternion.Euler(yRotation, 0, 0);
        // transform.position = player.transform.position;
    }
}
