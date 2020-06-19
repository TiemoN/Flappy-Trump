using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public float maxTime = 1;
    private float timer = 0;
    public GameObject pipe;
    public float height;
   // public static int bossSpawn=2;
    bool hasInstantiated = false;
   // public GameObject boss;
   
    //bool Spawn = true;
    bool Show = true;
   


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
                timer = 0;

            }
            timer += Time.deltaTime;
           
        }
       // else if (Show==false)
        {
          
        }


        //if (Score.score>bossSpawn)
        {
           // if (!hasInstantiated)
            {
              //  Debug.Log("bosss");
              
                //hasInstantiated = true;
                //Show=false;
            }
        }
       
    }
}
