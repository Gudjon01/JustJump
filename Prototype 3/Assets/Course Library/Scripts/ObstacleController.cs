using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    public float moveSpeed;
    private float leftBound = -20;
    private PlayerController PCScript;
    // Start is called before the first frame update
    void Start()
    {
        PCScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PCScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);            
        }

        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
