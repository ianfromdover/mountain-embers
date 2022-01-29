using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControlYoutubePickup : MonoBehaviour
{
    float yRotation;
    RaycastHit hit;
    GameObject onHand;
    public Transform grabPos;
    // Start is called before the first frame update
    void LateUpdate()
    {
        yRotation -= Input.GetAxis("Mouse Y");
        yRotation = Mathf.Clamp(yRotation, -60, 60);
        transform.localRotation = Quaternion.Euler(yRotation, 0, 0);
        /*
        if (Input.GetMouseButtonDown(0) && Physics.Raycast(transform.position, transform.forward, out hit, 5) && hit.transform.GetComponent<Rigidbody>()) {
            onHand = hit.transform.gameObject;
        } else if (Input.GetMouseButtonUp(0)) {
            onHand = null;
        }

        if (onHand) {
            onHand.GetComponent<Rigidbody>().velocity = 10 * (grabPos.position - onHand.transform.position);
        }
        */
    }
}
