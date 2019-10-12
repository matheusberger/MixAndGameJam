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
        if (spawnTimer < elapsedTime)
        {
            Instantiate(obstacle, new Vector3(), this.transform.rotation);
            elapsedTime = 0;
        }

        elapsedTime += Time.deltaTime;
    }
}
