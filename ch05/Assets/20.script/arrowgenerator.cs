using UnityEngine;

public class arrowgenerator : MonoBehaviour
{
    public GameObject arrowprefab;
    float span = 1.0f;
    float delta = 0f;

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if (delta > span) 
        {
            GameObject go = Instantiate(arrowprefab);
            float px = Random.Range(-8f, 8f);
            go.transform.position = new Vector3(px, 6F, 0);
            delta = 0;
        }
    }
}
