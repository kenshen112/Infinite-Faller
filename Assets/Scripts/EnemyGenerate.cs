using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerate : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    int maxDistance = 0;
    [SerializeField]
    GameObject enemy;
    Queue<GameObject> enemyQueue;

    void Start()
    {
        
    }

    void Generate()
    {
        // TODO Add previous instantiated Enemy objects. 
        if (enemyQueue.Peek().transform.position.x < maxDistance)
        {
            // Nah M8
        }
        Instantiate(enemyQueue.Dequeue());
    }

    // Update is called once per frame
    void Update()
    {
        // Enemies should move up
    }
}
