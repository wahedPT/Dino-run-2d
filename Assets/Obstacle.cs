using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
   //public GameObject[] Obs;
    Rigidbody2D rb;
    public int speed;
   
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       
         
    }

    void Update()
    {
        rb.velocity = new Vector2(-speed    , 0);
        if (transform.position.x <= -11)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            Destroy(this.gameObject);
            

        }
    }
}
