using UnityEngine; 

public class ItemGenerator : MonoBehaviour
{
    public GameObject applePrefab;
    public GameObject bombPrefab;

    public float span = 1f;
    float delta = 0f;
    GameObject currentItem;

    void Update()
    {
        delta += Time.deltaTime;
        if(delta > span && currentItem == null)
        {
            currentItem = Instantiate(applePrefab);
            float x = Random.Range(-13, 14);
            float z = Random.Range(-13, 14);
            currentItem.transform.position = new Vector3(x, 30, z);
            delta = 0;
        }
    }
}