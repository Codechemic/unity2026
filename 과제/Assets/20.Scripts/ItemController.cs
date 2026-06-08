using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemController : MonoBehaviour
{
    public float dropSpeed = -1f;

    void Update()
    {
        transform.Translate(0, dropSpeed * Time.deltaTime, 0);
        if(transform.position.y < -5f)
        {
            SceneManager.LoadScene("EndScene");
            Destroy(gameObject);
        }
    }
}