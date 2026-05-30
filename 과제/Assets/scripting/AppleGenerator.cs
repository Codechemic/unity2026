using UnityEngine;

public class AppleGenerator : MonoBehaviour
{
    public GameObject applePrefab;
    public float rangeX = 5f;
    public float rangeZ = 5f;
    public float spawnY = 7f;

    void Start()
    {
        SpawnApple();
    }

    void SpawnApple()
    {
        float x = Random.Range(-rangeX, rangeX);
        float z = Random.Range(-rangeZ, rangeZ);
        GameObject apple = Instantiate(applePrefab);
        apple.transform.position = new Vector3(x, spawnY, z);
    }
}