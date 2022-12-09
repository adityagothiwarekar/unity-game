using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{
   public bool gameover;
   public GameObject GameOverPanel;
   public bool game=true;
    Rigidbody2D rb;
   public float rotationSpeed;
   public TextMeshProUGUI textcoins;
   public float score=0;
   public float PointIncresedPerSecond = 1f;
   [SerializeField] private AudioSource audiosource;
   [SerializeField] private AudioSource gamemusic;




    // Start is called before the first frame update
    void Start()
    {
        
       
       /* rb = GetComponent<Rigidbody2D>();
        rb.tag = "Player";
        Destroy(gameObject);
        */

    
        
    }

    // Update is called once per frame


    private void FixedUpdate()
    {
        calculatescore();
        transform.Rotate(0,0,rotationSpeed);
       
        
      
       
       
         }
         
        /*
        //to rotate the obstacle

        transform.Rotate(0,0,rotationSpeed);
        if(gameover)
        {
           
        textcoins.text = "Score :"+((int)score).ToString();
        score += PointIncresedPerSecond * Time.fixedDeltaTime;
        }else
        {
                                                                                                                                                                                                                           
                textcoins.text="Score :"+((int)score).ToString();
        }
        */
    
    
     private void OnTriggerEnter2D(Collider2D collision) {

            if(collision.gameObject.CompareTag("Ground"))
            {
                   
                gameover=false;
                gamemusic.Play();
              
            }
             if(collision.gameObject.CompareTag("Player"))
            {
                Debug.Log("inside player");
                gameover=true;
                gamemusic.Pause();
                Debug.Log("paused music");
                audiosource.Play();
                Debug.Log("Changed Gameover");
                Destroy(collision.gameObject);
                GameObject.FindGameObjectWithTag("ObstacleSpawner").GetComponent<Obstaclespawner>().StopSpawning();
                GameOverPanel.SetActive(true);
                score=0;
                textcoins.text = "Score :"+((int)score).ToString();
        }
            }
            
     

        public void calculatescore()
        {
            if(!gameover)
        {
          score=score/1000+1;
         textcoins.text = "Score :"+((int)score).ToString();
        }
        }
       
}
        
    
    //to destroy the object once it touches the ground
   /* public void OnCollisionEnter2D(Collision2D col) {

        if(col.gameObject.tag =="Player")
        {
        gameover=false;
        Debug.Log("collision occurs");
        Destroy(col.gameObject);
        GameObject.FindGameObjectWithTag("ObstacleSpawner").GetComponent<Obstaclespawner>().StopSpawning();
        print(gameover);

        }
        else{

            
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
        

        
    
        
        /*public void addscore(int newscore)
         {
            score=score+newscore;
         }
         public void updatescore()
         {
            textcoins.text = "Score :"+((int)score).ToString();

         }
         */
         




    

        
     

     
    


