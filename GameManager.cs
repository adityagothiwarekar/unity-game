using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
     public static GameManager Instance; 
     //bool gameover = false;
     public void Awake()
     {
        Instance=this;
     }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {
        // gameover=true;
            
            GameObject.Find("ObstacleSpawner").GetComponent<Obstaclespawner>().StopSpawning();
            Debug.Log("Function Called");
    }
}
