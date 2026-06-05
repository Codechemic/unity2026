using UnityEngine;
using TMPro;

public class GameDirector : MonoBehaviour
{
    public GameObject appleText;
    public GameObject[] platforms;

    public void GetApple()
    {
        appleText.GetComponent<TextMeshProUGUI>().text = "Apple Get!";

        int dice = Random.Range(1, 10);
        Destroy(platforms[dice - 1]);
    }
}