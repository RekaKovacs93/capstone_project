using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTrigger : MonoBehaviour
{

    public Collider2D collider2D;

    private Portal portal;

    private bool activated = false;


    private void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player") && activated == false)
        {
            activated = true;
            Debug.Log("I am now active");
        }
    }
}
