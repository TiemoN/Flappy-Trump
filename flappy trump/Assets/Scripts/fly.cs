using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fly : MonoBehaviour
{
    private Animator anim;
    public GameManager gameManager;
    public GameObject pauseMENU;
    public float velocity = 1;
    private Rigidbody2D rb;
    private AudioSource audioSource;
    public AudioClip[] dead;
    private AudioClip deadclip;
    
   
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //jump
            rb.velocity = Vector2.up * velocity;
            anim.SetTrigger("Flap");
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        gameManager.GameOver();
       
        
        anim.SetTrigger("Die");
        int index = Random.Range(0, dead.Length);
        deadclip = dead[index];
        audioSource.clip = deadclip;
        audioSource.Play();

        pauseMENU.SetActive(false);
    }
}
