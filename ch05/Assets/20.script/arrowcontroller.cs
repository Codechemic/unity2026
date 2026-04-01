using UnityEngine;

public class arrowcontroller : MonoBehaviour
{
    public float dropspeed = 0.1f;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -dropspeed, 0);

        if (transform.position.y < -7)
        {
            Destroy(gameObject);
        }
    }
}
