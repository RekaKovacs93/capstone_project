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
       
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player") && canBeEaten)
        {
            //need to change this so that it affects radius
            playerMechanics.IncreaseLight();
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

