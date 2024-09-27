using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawRate = 2;
    private float timer = 0;
    public float hightOffset = 10;

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawRate){
            timer = timer = Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - hightOffset;
        float highesPoint = transform.position.x + hightOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highesPoint), 0), transform.rotation);
    }
}
