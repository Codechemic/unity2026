using UnityEngine;

public class carcontroller : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    float speed = 0f;
    Vector2 startpos;
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
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
