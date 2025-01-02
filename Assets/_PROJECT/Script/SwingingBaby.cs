using UnityEngine;

public class SwingingBaby : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed of movement
    public Transform baby;

    public float leftConstraint = -5f;  // Left boundary
    public float rightConstraint = 5f; // Right boundary

    void Start()
    {
        transform.position = new Vector3(0, transform.position.y, transform.position.z);
    }

    void FixedUpdate()
    {
        // Get current position
        Vector3 currentPosition = transform.position;

        // Move left when Q is pressed
        if (Input.GetKey(KeyCode.Q))
        {
            currentPosition.x -= moveSpeed * Time.fixedDeltaTime;
        }

        // Move right when E is pressed
        if (Input.GetKey(KeyCode.E))
        {
            currentPosition.x += moveSpeed * Time.fixedDeltaTime;
        }

        // Clamp position within the constraints
        currentPosition.x = Mathf.Clamp(currentPosition.x, leftConstraint, rightConstraint);

        // Apply the new position
        transform.position = currentPosition;
    }
}
