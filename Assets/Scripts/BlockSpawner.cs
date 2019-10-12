using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    [Range(1,5)]
    public int spawnTimer = 2;

    public GameObject obstacle;

    private float elapsedTime;

    // Start is called before the first frame update
    void Start()
    {
        elapsedTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnTimer/2.0f < elapsedTime)
        {
            Instantiate(obstacle, GetSpawnPosition(), Quaternion.identity);
            elapsedTime = 0;
        }

        elapsedTime += Time.deltaTime;
    }

    Vector3 GetSpawnPosition()
    {
        float x = 0f, z = 0f;

        x = Random.Range(-5.0f, 5.0f);
        z = Random.Range(-5.0f, 5.0f);
        var position = new Vector3(x, 15, z);



        return position;
    }
}
