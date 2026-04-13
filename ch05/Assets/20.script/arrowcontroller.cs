using UnityEngine;

public class arrowcontroller : MonoBehaviour
{
    public GameObject player;

    float minDistance = 1.1f;

    public float dropspeed = 0.1f;

    private void Start()
    {
        player = GameObject.Find("player");
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -dropspeed, 0);

        if (transform.position.y < -7)
        {
            Destroy(gameObject);
        }

        Vector2 p1 = transform.position;
        Vector2 p2 = player.transform.position;
        float distance = (p1 - p2).magnitude;
        if (distance < minDistance)
        {
            Destroy(gameObject);
        }
    }
}
