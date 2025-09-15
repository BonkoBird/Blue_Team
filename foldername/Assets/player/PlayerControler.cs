using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class PlayerControler : MonoBehaviour
{
 
    private Rigidbody2D rb;
    public float Movespeed;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {  
    }
    private void FixedUpdate()
    {
        Movement();
    }
    void Movement()
    {
 
        float InputSpeedX = Input.GetAxisRaw("Horizontal");
        float InputSpeedY = Input.GetAxis("Vertical");
 
        rb.linearVelocity = new Vector2(InputSpeedX * Movespeed, rb.linearVelocity.y);
        rb.linearVelocity = new Vector2(rb.linearVelocity.x,InputSpeedY * Movespeed);
 
    }
 
}