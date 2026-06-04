using UnityEngine;

public class BasketController : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public AudioClip appleSE;
    public AudioClip bombSE;

    Rigidbody rb;
    AudioSource aud;
    Vector3 moveDirection;

    void Start()
    {
        Application.targetFrameRate = 60;
        rb = GetComponent<Rigidbody>();
        aud = GetComponent<AudioSource>();
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

        if(Input.GetKeyDown(KeyCode.Space))
        {
            // 스페이스바 동작을 여기에 작성
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Apple")
        {
            aud.PlayOneShot(appleSE);
        } 
        else if(other.gameObject.tag == "Bomb")
        {
            aud.PlayOneShot(bombSE);
        }
        Destroy(other.gameObject);
    }
}