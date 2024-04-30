using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    // Start is called before the first frame update
    // Rotation speed of the collectible
    public float rotationSpeed = 50f;

    // Bobbing motion variables
    public float bobSpeed = 1f; // Speed of bobbing motion
    public float bobHeight = 0.5f; // Height of bobbing motion

    // Initial position of the collectible
    private Vector3 initialPosition;

    // Start is called before the first frame update
    void Start()
    {
        // Store the initial position of the collectible
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate the collectible around its Y-axis
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);

        // Bob the collectible up and down using a sine wave
        float bob = Mathf.Sin(Time.time * bobSpeed) * bobHeight;
        Vector3 newPosition = initialPosition + new Vector3(0, bob, 0);
        transform.position = newPosition;
    }
}
