using UnityEngine;

public class WASDMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust the speed in the Unity Inspector

    void Update()
    {
        // Get input from the default Unity Input Manager axes
        float horizontalInput = Input.GetAxis("Horizontal"); // A/D keys and Left/Right arrow keys
        float verticalInput = Input.GetAxis("Vertical"); // W/S keys and Up/Down arrow keys

        // Calculate movement direction for 2D (using X and Y axes)
        // Vector3 movement = new Vector3(horizontalInput, verticalInput, 0f); // Alternative way to write
        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0f).normalized; // Normalize for consistent diagonal speed

        // Apply movement to the object's position, ensuring smooth movement regardless of frame rate
        transform.Translate(movement * moveSpeed * Time.deltaTime);
    }
}
