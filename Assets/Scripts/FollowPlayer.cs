using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform playerTransform; // Reference to the player's transform
    public float offset;

    void Start()
    {
        
    }

    void LateUpdate() // Use LateUpdate for smooth camera movement
    {
        Vector3 cameraPos = transform.position;
        cameraPos.z = playerTransform.position.z + offset;
        transform.position = cameraPos;
    }
}
