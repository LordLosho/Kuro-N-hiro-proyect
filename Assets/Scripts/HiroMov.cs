using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiroMov : MonoBehaviour
{// Start is called before the first frame update

    Rigidbody2D rb;
    public float moveSpeed = 140f;

    //bool faceRight = true;
    
    //Animator myAnim;

    //Variable si puede saltar o no
    public Transform groundCheck;
    public float checkRadius = 0.05f;
    public LayerMask whatIsGround;
    bool isGrounded;
    public float JumpForce = 5f;


private  void FixedUpdate() {
    isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
}

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
       HiroMoviment();
       HiroJump();
    }

    void HiroMoviment()
    {
         float move = Input.GetAxisRaw("Horizontal1") * moveSpeed * Time.deltaTime;
        rb.velocity = new Vector2(move, rb.velocity.y);
    }

        void HiroJump(){
        if(Input.GetButtonDown("JumpH")&& isGrounded){

            rb.velocity = new Vector2(rb.velocity.x, JumpForce);

        }

    }
}
