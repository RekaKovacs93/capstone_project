using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RekaPortal : MonoBehaviour
{


    public Collider2D collider2D;

    public bool portalOpen = false;

    [SerializeReference]
    public List<RekaTrigger> triggers;

    public GameObject text;

    private void Start()
    {
        text.SetActive(false);

    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            foreach (RekaTrigger trigger in triggers)
            {
                if (trigger.activated == false)
                {
                    portalOpen = false;
                    Debug.Log("I aM Not Activated");
                }
                else
                {
                    portalOpen = true;
                    text.SetActive(portalOpen);
                    Debug.Log("I aM Activated");

                }
            }

        }
    }
}