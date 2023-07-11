using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Portal : MonoBehaviour
{

    public Collider2D collider2D;

    private bool portalOpen = false;


    [SerializeReference]  private List<PortalTrigger> triggers;

    [SerializeReference] private GameObject text;

    private void Start()
    {
        //on start text will be set to false
        text.SetActive(false);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && portalOpen)
        {
            text.SetActive(portalOpen);
            Debug.Log("I aM TrIGgeRed by " + collision.name + " and I am now " + portalOpen);
        }

        else if (collision.CompareTag("Player")){
            Debug.Log("I am lost in darkness exdee");
        }
    }

    public void checkPortalTriggers() {

        bool check = true;

        foreach (PortalTrigger trigger in triggers)
        {
            if (!trigger.getActivated())
            {
                check = false;
            }
        }

        if (check)
        {
            portalOpen = true;

        }
        
    }


}
