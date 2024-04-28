using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target; // Reference to the target to follow (the third-person character)

    public Vector3 offset = new Vector3(0f, 1.5f, -5f); // Offset from the target position

    public float smoothSpeed = 0.125f; // Speed of camera movement

    private Vector3 velocity = Vector3.zero; // Velocity for smoothing movement

    void LateUpdate()
    {
        if (target == null)
        {
            Debug.LogWarning("Target not set for ThirdPersonCamera.");
            return;
        }

        // Calculate the desired position for the camera
        Vector3 desiredPosition = target.position + offset;

        // Smoothly move the camera towards the desired position using SmoothDamp
        transform.position = Vector3.SmoothDamp(transform.position, desiredPosition, ref velocity, smoothSpeed);

        // Make the camera look at the target
        transform.LookAt(target);
    }
}
