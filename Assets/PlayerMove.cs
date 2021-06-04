using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    Rigidbody2D playerRB;
    public float Jump;
    private bool grounded;
    Animator animator;
    public GameObject Endscrn;
    //down three are from stop to work after game end
    RepeatBackground v;
    RepeatBackground U;
    SpawnManager os;
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        //down three are from stop to work after game end
        v = GameObject.Find("Background").GetComponent<RepeatBackground>();
        U = GameObject.Find("Ground").GetComponent<RepeatBackground>();
        os = GameObject.Find("Spawnmanager").GetComponent<SpawnManager>();
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            if(grounded)
            {
               
                JumpP();
                animator.SetTrigger("Jump");
            }
           
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            print("huhu");
            grounded = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag== "Obstacle")
        {
          animator.SetTrigger("Dead");
            v.xoffset = 0;
            U.xoffset = 0;
            os.CancelInvoke("Spawn");


        }
        if (collision.gameObject.tag == "Obstacle")
        {
            Endscrn.gameObject.SetActive(true);
        }
    }
  
    private void JumpP()
    {
        grounded = false;
        playerRB.velocity = new Vector2(0, Jump);
        
    }

    
}

//if(Input.GetKeyDown(KeyCode.Space))
//{
//    //playerRB.position = new Vector2(0, 1);

//}
//animator.gameObject.GetComponent<Animator>().enabled = false;
