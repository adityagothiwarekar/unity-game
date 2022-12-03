using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaclespawner : MonoBehaviour
{
    public GameObject obstacle;
    public float spawnRate;
    public float maxXpos;
    // Start is called before the first frame update
    void Start()
    {
        StartSpawning();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public void Spawn()
    {
        float randomX = Random.Range(-maxXpos , maxXpos);

        Vector2 spawnPos = new Vector2(randomX , transform.position.y);

        //to spawn the object
        Instantiate(obstacle,spawnPos,Quaternion.identity);
        //we dont want the object to rotate hence we use this function
    }

    void StartSpawning()
    {
        InvokeRepeating("Spawn",1f, spawnRate);
    }
   public void StopSpawning()
    {
        CancelInvoke("Spawn");
    }
    
}
