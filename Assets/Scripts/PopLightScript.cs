using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopLight : MonoBehaviour
{

    public new Collider2D collider2D;

    [SerializeField]
    private PlayerMechanics playerMechanics;
    private bool canBeEaten = false;

    private void Start()
    {
        this.gameObject.SetActive(true);
        //Invoke("delayActivate",3f);
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player") && canBeEaten)
        {
            //need to change this so that it affects radius
            playerMechanics.increaseLight();
            this.gameObject.SetActive(false);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            canBeEaten = true;
        }
    }
    
        
}

