using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public float maxTime = 1;
    private float timer = 0;
    public GameObject pipe;
    public float height;
    public static int bossSpawn=3;
    bool hasInstantiated = false;
   public GameObject boss;
   
   public bool Spawn = true;
   public bool Show = true;
    private int whatToSpawn;
    public GameObject coin;
    public Transform coinSpawn;
  
   
   


    public void Start()
    {
        GameObject newpipe = Instantiate(pipe);
       
        newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
       
       
    }
  public void Update()
    {
        // InvokeRepeating("Spawntubes", 0, 1);
        /*if (Spawn)
        {
            Spawntubes();
            
        }
        */





        if (Show == true)
        {
            if (timer > maxTime)
            {
                GameObject newpipe = Instantiate(pipe);
                newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
                Destroy(newpipe, 15);
                whatToSpawn = Random.Range(1, 3);
                timer = 0;

            }
            timer += Time.deltaTime;
            switch (whatToSpawn)
            {
                case 1:Instantiate(coin, coinSpawn.position, transform.rotation);
                    Debug.Log("yeah");
                    break;
                case 2:
                    Debug.Log("dfeh");
                    break;
                case 3:;
                    break;
            }
           
        }
        else if (Show==false)
        {
          
        }


        if (Score.score>bossSpawn)
        {
            if (!hasInstantiated)
            {
               Debug.Log("bosss");
              
                hasInstantiated = true;
                Show=false;
               
            }
        }
        if (Bossmove.ps == 1)
        {
            Show = true;
        }
       
    }
}
