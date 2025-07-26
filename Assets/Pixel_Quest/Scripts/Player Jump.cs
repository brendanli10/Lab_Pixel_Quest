using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    private Rigidbody2D rb; 
    public float JumpForce= 10f;
    public float CapsuleHeight= 0.25f;
    public float CapsuleRadius= 0.08f;

    public Transform feetCollider;
    public LayerMask groundMask;
    private bool _groundCheck;
    private float fallForce = 3;
    private Vector2 gravityForce;
    public bool _waterCheck;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gravityForce= new Vector2 (0f, Physics2D.gravity.y);
    }

 private void OnTriggerEnter2D(Collider2D other) //enter water
    {
        if (other.tag=="Water")
        {
            _waterCheck= true;
        }
    }


    private void OnTriggerExit2D(Collider2D other) //exit water
    {
       if (other.tag=="Water"){
        _waterCheck= false;
       }
    
}


    void Update() //ground check
    {
         _groundCheck = Physics2D.OverlapCapsule(feetCollider.position, new Vector2
        (CapsuleHeight,CapsuleRadius), CapsuleDirection2D.Horizontal,0,groundMask);
    
         if (Input.GetKeyDown(KeyCode.Space)&& (_groundCheck || _waterCheck))
        {
            rb.velocity = new Vector2(rb.velocity.x, JumpForce);
        }
        
        if (rb.velocity.y<0 && !_waterCheck) //falling
        {
            rb.velocity += gravityForce * (fallForce*Time.deltaTime);
        }
    }

}
