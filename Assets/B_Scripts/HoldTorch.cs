using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Allows the player to pick up a torch.
 * This lets the player bring torches to the campfire, allowing them to complete the game.
 */
public class HoldTorch : MonoBehaviour
{
    public Transform grabPos;
    public float followSpeed = 3;
    void FixedUpdate()
    {
        GetComponent<Rigidbody>().velocity = followSpeed * (grabPos.position - transform.position);
    }
}
