using UnityEngine;

public class PlayerMoveRB : MonoBehaviour
{
    public float moveSpeed = 1000f;
    public float rotationSpeed = 100f;

    Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        float xSpeed = xInput * rotationSpeed * Time.deltaTime;
        float zSpeed = zInput * moveSpeed * Time.deltaTime;

        //transform.Translate(0, 0, zSpeed);
        transform.Rotate(0, xSpeed, 0);
        rb.linearVelocity = zSpeed * transform.forward;
    }
}
