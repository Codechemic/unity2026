using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public GameObject scoreObject;
    int score = 0;

    void Start()
    {
        instance = this;
        scoreObject.GetComponent<TextMeshProUGUI>().text = "Score: 0";
    }

    public void AddScore()
    {
        score++;
        scoreObject.GetComponent<TextMeshProUGUI>().text = "Score: " + score;
    }
}