using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float directionAxis;
    public float jumpForce = 12f;
    public bool isGrounded = false;
    public SpriteRenderer sprite;

    void Start()
    {
    }

    void Update()
    {
        directionAxis = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(directionAxis, 0f, 0f);
        if (directionAxis > 0)
            sprite.flipX = false;
        else if(directionAxis<0)
            sprite.flipX = true;
        transform.position += movement * Time.deltaTime * moveSpeed;
        if (Input.GetButtonDown("Jump") && isGrounded)
            Jump();
    }

    void Jump()
    {
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
    }

}