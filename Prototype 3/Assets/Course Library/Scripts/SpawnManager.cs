using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstacle;
    private Vector3 spawnPos = new Vector3(20, 0, 0);
    public float delayRate;
    public float repeatRate;

    private PlayerController PCScript;
    // Start is called before the first frame 
    void Start()
    {
        InvokeRepeating("SpawnObstacle",delayRate,repeatRate);
        PCScript = GameObject.Find("Player").GetComponent<PlayerController>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        if (PCScript.gameOver == false)
        {
            Instantiate(obstacle, spawnPos, obstacle.transform.rotation);            
        }

    }
}
