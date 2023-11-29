using UnityEngine;

public class FPSMovement : MonoBehaviour
{
    public float speed = 5.0f;
    public float sensitivity = 2.0f;

    private Rigidbody rb;
    private float rotationX = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        // Make the Rigidbody not influenced by the physics system,
        // as we're controlling movement manually
        rb.freezeRotation = true;
    }

    void Update()
    {
        // Player Movement
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontal, 0, vertical);
        movement = transform.TransformDirection(movement);
        rb.velocity = new Vector3(movement.x * speed, rb.velocity.y, movement.z * speed);

        // Player Rotation
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, -90f, 90f);

        Camera.main.transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
        transform.rotation *= Quaternion.Euler(0, mouseX, 0);
    }
}