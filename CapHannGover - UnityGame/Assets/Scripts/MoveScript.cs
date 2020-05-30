using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float jumpForce = 12f;
    public bool isGrounded = false;
    void Start()
    {
    }

    void Update()
    {

        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;
        if (Input.GetButtonDown("Jump") && isGrounded)
            Jump();
    }

    void Jump()
    {
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
    }

}