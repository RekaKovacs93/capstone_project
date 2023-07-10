using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Portal : MonoBehaviour
{

    public Collider2D collider2D;

    public bool portalOpen = false;

    [SerializeReference]
    public List<PortalTrigger> triggers;

    public GameObject text;

    private void Start()
    {
        text.SetActive(false);

        
        

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

    private void checkPortalTriggers() { 
        foreach (PortalTrigger trigger in triggers)
        {

        }

    }

}
