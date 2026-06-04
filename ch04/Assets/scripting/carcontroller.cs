using UnityEngine;

public class carcontroller : MonoBehaviour
{
    float speed = 0f;
    Vector2 startpos;
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            startpos = Input.mousePosition;
        }
        else if(Input.GetMouseButtonUp(0))
        {
            Vector2 endPos = Input.mousePosition;
            float swipelength = endPos.x - startpos.x;
            speed = swipelength / 1000f;
            GetComponent<AudioSource>().Play();
        }
        transform.Translate(speed, 0, 0);
        speed *= 0.995f;
    }
}
