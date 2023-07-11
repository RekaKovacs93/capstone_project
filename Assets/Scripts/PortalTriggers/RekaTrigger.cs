using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RekaTrigger : MonoBehaviour
{

    public Collider2D collider2D;


    public bool activated = false;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            activated = true;
            Debug.Log("I am now active");
        }
    }
}
