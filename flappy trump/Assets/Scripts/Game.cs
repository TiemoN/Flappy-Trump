using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public float maxTime = 1;
    private float timer = 0;
    public GameObject pipe;
    public float height;
    public static int bossSpawn=23;
    bool hasInstantiated = false;
   public GameObject boss;
   
   public bool Spawn = true;
   public bool Show = true;
    private int whatToSpawn;
    public GameObject coin;
    public Transform coinSpawn;
    public AudioSource bossSound;
    public GameObject[] section;
    bool spawnSection2=false;
    public GameObject[] section2;
    public int section2point;
    public int part2;
    public float maxTime2;
    private float timer2=0;
    public Transform level2Spawn;
    public GameObject[] obstacle;
    public float maxTimeO;
    public Transform BossObstacle;
    private bool Show2=true;



    //float randX;





    public void Start()
    {
       
        GameObject newpipe = Instantiate(pipe);
        bossSound = GetComponent<AudioSource>();
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

        timer += Time.deltaTime;
        timer2 += Time.deltaTime;


        if (Show == true)
        {
            if (Score.score < part2)
            {
                if (timer > maxTime)
                {
                    int level = Random.Range(0, section.Length);
                    //  GameObject newpipe = Instantiate(pipe);
                    //newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
                    // Destroy(newpipe, 15);
                    //whatToSpawn = Random.Range(1, 3);
                    timer = 0;
                    Instantiate(section[level], transform.position, transform.rotation);




                }
               

            }
        }
        else if (Show==false)
        {
          
        }


        if (Score.score>bossSpawn)
        {
            if (!hasInstantiated)
            {
               /* if (timer > maxTimeO)
                {
                    int Oblevel = Random.Range(0, obstacle.Length);
                    //  GameObject newpipe = Instantiate(pipe);
                    //newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
                    // Destroy(newpipe, 15);
                    //whatToSpawn = Random.Range(1, 3);
                    timer = 0;
                    Instantiate(obstacle[Oblevel], BossObstacle.position, transform.rotation);




                }*/
                Debug.Log("bosss");
                bossSound.Play();
              
                hasInstantiated = true;
                Show2 = false;
               
            }
        }
        if (Bossmove.ps == 1)
        {
          
        }
        if (Show2 == true)
        {
            if (part2 <= Score.score)
            {

                if (timer2 > maxTime2)
                {
                    int level2 = Random.Range(0, section2.Length);
                    //  GameObject newpipe = Instantiate(pipe);
                    //newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
                    // Destroy(newpipe, 15);
                    //whatToSpawn = Random.Range(1, 3);
                    timer2 = 0;
                    Instantiate(section2[level2], level2Spawn.position, transform.rotation);




                }

            }
        }
        else if(Show2==false)
       {

       }
    }
   
    
}
