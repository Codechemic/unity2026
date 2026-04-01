using UnityEngine;
using TMPro;

public class gamemanager : MonoBehaviour
{
    public GameObject car;
    public GameObject flag;
    public GameObject distance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //car = GameObject.Find("car");
    }

    // Update is called once per frame
    void Update()
    {
        float length = (flag.transform.position.x - car.transform.position.x);
        distance.GetComponent<TextMeshProUGUI>().text = "°Å¸® : " + length.ToString("F2") + "m";
    }
}
