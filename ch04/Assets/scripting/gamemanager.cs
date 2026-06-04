using UnityEngine;
using TMPro;

public class gamemanager : MonoBehaviour
{
    public GameObject car;
    public GameObject flag;
    public GameObject distance;
    void Start()
    {
        //car = GameObject.Find("car");
    }

    void Update()
    {
        float length = (flag.transform.position.x - car.transform.position.x);
        distance.GetComponent<TextMeshProUGUI>().text = "Distance : " + length.ToString("F2") + "m";
    }
}
