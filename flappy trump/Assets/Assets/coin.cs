using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public int Coinvalue = 2;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        void OnCollisionEnter2D(Collision2D collision)
        {
            Destroy(gameObject);
            Score.score += Coinvalue;
        }
    }
}
