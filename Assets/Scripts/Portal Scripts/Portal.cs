using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Portal : MonoBehaviour
{

    public Collider2D collider2D;

    public bool portalOpen = false;

    public GameObject text;

    private void Start()
    {
        text.SetActive(false);
        Debug.Log("You should not see mee teehee");

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            portalOpen = true;
            text.SetActive(portalOpen);
            Debug.Log("I aM TrIGgeRed by " + collision.name + " and I am now " + portalOpen);
        }
    }

    
    
}
