using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bossmove : MonoBehaviour
{
    bool boxcol = true;
   public Animator animator;
    public GameObject missle;
    public float SpawnSpeed = 0;
    public float maxTIME = 1;
    public Transform SpawnPoint;
    private float rocketNumber=0;
    public float rocketLimit=5;
    private bool Phase = true;
    public static int ps = 0;
    public GameObject Boss;
  
   


    // Start is called before the first frame update
    void Start()
    {
        animator.gameObject.GetComponent<Animator>().enabled=false;
       

        
       
    }

    // Update is called once per frame
    void Update()
    {
        if (boxcol==true) {
            if (Score.score >= Game.bossSpawn)
            {

                animator.gameObject.GetComponent<Animator>().enabled = true;
                if (Phase==true)
                {
                    
                    if (SpawnSpeed > maxTIME)
                    {
                        Instantiate(missle, SpawnPoint.position, transform.rotation);
                        SpawnSpeed = 0;
                        rocketNumber++;
                    }
                    SpawnSpeed += Time.deltaTime;
                }
                if (rocketNumber == rocketLimit)
                {
                    Phase = false;
                    animator.gameObject.GetComponent<Animator>().enabled = false;
                    Boss.SetActive(false);

                    ps = 1;

                }
            }
        }
    
       
    }
   
    
}
