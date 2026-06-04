using JetBrains.Annotations;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    public float speed = 0.1f;
    void Start()
    {
        Application.targetFrameRate = 60;
    }

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
}