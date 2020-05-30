using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = gameObject.transform.parent.gameObject;
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Ground")
            player.GetComponent<MoveScript>().isGrounded = true;
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "Ground")
            player.GetComponent<MoveScript>().isGrounded = false;
    }
}
