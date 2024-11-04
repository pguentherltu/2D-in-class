using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float horizSpeed;
    public float jumpSpeed;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float xSpeed = Input.GetAxis("Horizontal") * horizSpeed;
  
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Jump!");
            rb.velocity = new Vector2(xSpeed, jumpSpeed);
        }
        else
        {
            rb.velocity = new Vector2(xSpeed, rb.velocity.y);
        }

        
    }
}
