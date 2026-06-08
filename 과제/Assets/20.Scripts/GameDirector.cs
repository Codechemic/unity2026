using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameDirector : MonoBehaviour
{
    public GameObject appleText;
    public GameObject[] platforms;

    int score = 0;

    public void GetApple()
    {
        appleText.GetComponent<TextMeshProUGUI>().text = "Apple Get!";

        score += 1;

        if(score >= 5)
        {
            SceneManager.LoadScene("FinishScene");
        }

        int dice = Random.Range(1, 10);
        Destroy(platforms[dice - 1]);
    }
}