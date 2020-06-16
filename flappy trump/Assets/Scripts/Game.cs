using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public float maxTime = 1;
    private float timer = 0;
    public GameObject pipe;
    public float height;
    public int bossSpawn;
    bool hasInstantiated = false;
    //bool Spawn = true;



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
        
        


            if (timer > maxTime)
            {
                GameObject newpipe = Instantiate(pipe);
                newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
                Destroy(newpipe, 15);
                timer = 0;

            }
            timer += Time.deltaTime;

        

        if (Score.score>bossSpawn)
        {
            if (!hasInstantiated)
            {
                Debug.Log("bosss");
                hasInstantiated = true;
                //StopCoroutine("Spawntubes");
            }
        }
       
    }
}
