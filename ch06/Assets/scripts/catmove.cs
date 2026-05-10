using UnityEngine;
using UnityEngine.SceneManagement; // LoadScene을 사용하는 데 필요하다.

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    float jumpForce = 200.0f;
    float walkForce = 30;
    float maxWalkSpeed = 2.0f;

    public Sprite[] walkSprites;
    public Sprite jumpSprite;

    float time = 0;
    int idx = 0;

    SpriteRenderer spriteRenderer;

    void Start()
    {
        Application.targetFrameRate = 60;
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // 점프한다.
        if (Input.GetMouseButtonDown(0) && this.rigid2D.linearVelocityY == 0)
        {
            this.rigid2D.AddForce(transform.up * this.jumpForce);
        }

        // 오른쪽으로 이동한다.
        if (this.rigid2D.linearVelocityX < this.maxWalkSpeed)
        {
            this.rigid2D.AddForce(transform.right * walkForce);
        }

        // 애니메이션
        if (this.rigid2D.linearVelocityY != 0)
        {
            this.spriteRenderer.sprite = this.jumpSprite;
        }
        else
        {
            this.time += Time.deltaTime;

            if (this.time > 0.1f)
            {
                this.time = 0;
                this.spriteRenderer.sprite = this.walkSprites[this.idx];
                this.idx = 1 - this.idx;
            }
        }

        // 플레이어가 화면 밖으로 나가면 처음부터
        if (transform.position.y < -10)
        {
            SceneManager.LoadScene("GameScene");
        }
    }

    // 골 도착
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("골");
        SceneManager.LoadScene("ClearScene");
    }
}