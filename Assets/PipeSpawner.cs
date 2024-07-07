using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnTime = 2;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnTime)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            timer = 0;
        }
    }
    
    void SpawnPipe()
    {
        Instantiate(pipePrefab, new Vector3(transform.position.x, Random.Range(-3, 3), 0), Quaternion.identity);
    }
}
