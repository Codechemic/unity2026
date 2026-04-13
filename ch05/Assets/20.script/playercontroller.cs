using JetBrains.Annotations;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    public float speed = 0.1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    //    if(Input.GetKey(KeyCode.LeftArrow))
    //    {
    //        transform.Translate(-speed, 0, 0);
    //    }
    //    if(Input.GetKey(KeyCode.RightArrow))
    //    {
    //        transform.Translate(speed, 0, 0);
    //    }
    //}
    public void LButtonDown()
    {
        transform.Translate(-speed, 0, 0);
    }

    public void RButtonDown()
    {
        transform.Translate(speed, 0, 0);
    }
