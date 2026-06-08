using UnityEngine; 

public class ItemGenerator : MonoBehaviour
{
    public GameObject applePrefab;

    public float span = 1f;
    GameObject currentItem;

    void Update()
    {
        if(currentItem == null)
        {
            currentItem = Instantiate(applePrefab);
            float x = Random.Range(-13, 14);
            float z = Random.Range(-13, 14);
            currentItem.transform.position = new Vector3(x, 30, z);
        }
    }
}