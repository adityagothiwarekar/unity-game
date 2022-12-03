using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    bool gameover = false;
    Rigidbody2D rb;
   public float rotationSpeed;
   int score=0;
    // Start is called before the first frame update
    void Start()
    {
       /* rb = GetComponent<Rigidbody2D>();
        rb.tag = "Player";
        Destroy(gameObject);
        */
    
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        //to rotate the obstacle

        transform.Rotate(0,0,rotationSpeed);
    }
    //to destroy the object once it touches the ground
    public void OnCollisionEnter2D(Collision2D col) {

        if(col.gameObject.tag =="Player")
        {
        Debug.Log("collision occurs");
        Destroy(col.gameObject);
        GameObject.FindGameObjectWithTag("ObstacleSpawner").GetComponent<Obstaclespawner>().StopSpawning();
        gameover=true;
       
    
          }
          else{
            
            score++;
            print(score);
          }
        
        /*if(col.gameObject.tag =="Player")
        {
            Destroy(col.gameObject);
            GameManager.instance.GameOver();
        }
        
        if(col.gameObject.tag == "Ground") 
        {
            Destroy(gameObject);
            
        }
        */
        
    }

   /* public void IncrementScore()
    {
        if(!gameover)
        {
            score++;
           Debug.Log("score");
        }
    }  
    */ 
}
