using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAntidote : MonoBehaviour
{
    public GameObject antidote;
    public float maxX1;
    public float minX1;
    public float maxY1;
    public float minY1;
    public float timeBetweenSpawn1;
    private float spawnTime1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > spawnTime1)
        {
            Spawn1();
            spawnTime1 = Time.time + timeBetweenSpawn1;
        }
    }
    void Spawn1()
    {
        float randomX = Random.Range(minX1, maxX1);
        float randomY = Random.Range(minY1, maxY1);

        Instantiate(antidote, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }
}
