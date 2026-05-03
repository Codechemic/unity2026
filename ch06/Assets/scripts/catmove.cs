using UnityEngine;

public class catmove : MonoBehaviour
{
    public float jumpforce = 100f;
    public float walkforce = 30f;
    public float maxwalkspeed = 2f;

    public Sprite[] walksprites;
    public float animationperiod = 0.1f;
    public Sprite[] jumpsprite;

    float time = 0;
    int idx = 0;

    SpriteRenderer sr;
    Rigidbody2D rb;

    void Start()
    {
        Application.targetFrameRate = 60;
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // 점프
        if (Input.GetMouseButtonDown(0))
        {
            rb.AddForce(transform.up * jumpforce);
        }

        // 이동
        if (rb.linearVelocity.x < maxwalkspeed)
        {
            rb.AddForce(transform.right * walkforce);
        }

        // 점프 중
        if (rb.linearVelocity.y != 0)
        {
            sr.sprite = jumpsprite[0];
        }
        else
        {
            time += Time.deltaTime;

            if (time > animationperiod)
            {
                time = 0;
                sr.sprite = walksprites[idx];
                idx = 1 - idx;
            }
        }
    }
}