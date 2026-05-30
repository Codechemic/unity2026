using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 1000f;
    public float jumpForce = 300f;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        float xSpeed = xInput * moveSpeed * Time.deltaTime;
        float zSpeed = zInput * moveSpeed * Time.deltaTime;

        rb.linearVelocity = new Vector3(
            xSpeed,
            rb.linearVelocity.y,
            zSpeed
        );

        if (Input.GetKeyDown(KeyCode.Space) && rb.linearVelocity.y == 0)
        {
            rb.AddForce(transform.up * jumpForce);
        }
    }

    // BasketController.cs 방식 채택
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Apple")
        {
            ScoreManager.instance.AddScore();
            Destroy(other.gameObject);
        }
    }
}