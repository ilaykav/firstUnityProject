using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour {

    public float speed;
    public float jumpForce;
    public LayerMask groundLayer;
    public float groundCheckRadius;
    bool onGround = true;
//    bool facingRight = true;
    Rigidbody2D r;

    bool doubleJump = false;



	void Start () {
        r = GetComponent<Rigidbody2D>();
	}
	
	void Update () {
		
	}

    void FixedUpdate() {
        //float move = Input.GetAxis("Horizontal");
        r.velocity = new Vector2(speed, r.velocity.y);

        //if (move < 0 && facingRight || move > 0 && !facingRight)
        //    ChangeDirection();

        Vector2 characterPosition = r.position;
        characterPosition.y -= 1;
        onGround = Physics2D.OverlapCircle(characterPosition, groundCheckRadius, groundLayer);

        if (onGround)
            doubleJump = false;

        if ((onGround || !doubleJump) && Input.GetKeyDown(KeyCode.Space))
        {
            r.velocity = new Vector2(r.velocity.x, 0);
            r.AddForce(new Vector2(0, jumpForce));
            
            if (!onGround)
                doubleJump = true;
        }        
    }

    /*void ChangeDirection() {
        facingRight = !facingRight;
        Vector3 characterScale = transform.localScale;
        characterScale.x *= -1;
        transform.localScale = characterScale;

    }*/
}
