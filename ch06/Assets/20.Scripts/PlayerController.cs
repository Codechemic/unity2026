using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    float jumpForce = 300f;
    float walkForce = 5f;
    float maxWalkSpeed = 1f;
    Animator anim;

    public Sprite[] walkSprites;
    public Sprite jumpSprite;
    public float animationPeriod = 0.1f;
    float time = 0;
    int idx = 0;

    SpriteRenderer sr;
    Rigidbody2D rb;
    void Start()
    {
        Application.targetFrameRate = 60;
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>(); 
        anim = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("ClearScene");
        Debug.Log("¼º°ø");
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && rb.linearVelocityY == 0)
        {
            rb.AddForce(transform.up * jumpForce);
        }
        
        if(rb.linearVelocityX < maxWalkSpeed)
        {
            rb.AddForce(transform.right * walkForce);
        }

        time += Time.deltaTime;

        if (rb.linearVelocityY != 0)
        {
            anim.SetBool("isJumping", true);
        }
        else if (time > animationPeriod)
        {
            anim.SetBool("isJumping", false);
        }

        //if (rb.linearVelocityY != 0)
        //{
        //    sr.sprite = jumpSprite;
        //}
        //else if (time > animationPeriod)
        //{
        //    time = 0;
        //    sr.sprite = walkSprites[idx];
        //    idx++;
        //    if (idx == walkSprites.Length)
        //    {
        //        idx = 0;
        //    }
        //}

        if(transform.position.y < -8)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
