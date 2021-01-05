using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstacle;
    public float minTime = 0.2f;
    public float startTime = 1f;
    private float timeToSpawn;
    private Vector2 pos;
    private float posX;
    public float speedUp = 0;

    // Start is called before the first frame update
    void Start()
    {
        posX = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        pos = new Vector2(posX, Random.Range(-2, -4));
        if (timeToSpawn <= 0) {
            timeToSpawn = startTime;
            Instantiate(obstacle, pos, Quaternion.identity);
        } else {
            timeToSpawn -= Time.deltaTime;
        }
        if(speedUp<15.0f)
            speedUp+=Time.deltaTime*0.25f;
    }
}