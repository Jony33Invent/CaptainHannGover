using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class deathChecker : MonoBehaviour
{
    public GameObject player;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
            player.GetComponent<Transform>().position = new Vector3(-6f,0f,0f);
    }
}
