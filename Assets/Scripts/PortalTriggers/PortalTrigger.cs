using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTrigger : MonoBehaviour
{

    public Collider2D collider2D;

    [SerializeField]
    private Portal portal;

    private bool activated = false;


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player") && activated == false)
        {
            activated = true;
            portal.checkPortalTriggers();
            Debug.Log("I am now active");
        }
    }


    public bool getActivated()
    {
        return activated;
    }
}
