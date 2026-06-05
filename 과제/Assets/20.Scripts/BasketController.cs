using UnityEngine;

public class BasketController : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float jumpForce = 300f;

    Rigidbody rb;
    Vector3 moveDirection;
    GameObject director;

    void Start()
    {
        Application.targetFrameRate = 60;
        rb = GetComponent<Rigidbody>();
        director = GameObject.Find("GameDirector");
    }

    void Update()
    {
        float xInput = Input.GetAxisRaw("Horizontal");
        float zInput = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector3(xInput, 0, zInput);

        if(moveDirection.magnitude > 0.1f)
        {
            moveDirection.Normalize();
            rb.MovePosition(rb.position + moveDirection * moveSpeed * Time.deltaTime);
        }

        if(Input.GetKeyDown(KeyCode.Space) && rb.linearVelocity.y == 0)
        {
            rb.AddForce(transform.up * jumpForce);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Apple")
        {
            director.GetComponent<GameDirector>().GetApple();
        } 
        Destroy(other.gameObject);
    }
}