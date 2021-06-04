using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCrocmove : MonoBehaviour
{
    Rigidbody2D rb;
    public int playerSpeed;
    SpriteRenderer playerSprite;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerSprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        //movement when key is get accessed./playerSprite.flipX = true; -this is for flip the faceing of the player
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = Vector2.right * playerSpeed;
            playerSprite.flipX=false;
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = Vector2.left * playerSpeed;
            playerSprite.flipX = true;
        }
    }
}
