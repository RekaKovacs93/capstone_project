using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Edible : MonoBehaviour
{

    public new Collider2D collider2D;

    [SerializeField]
    private PlayerMechanics playerMechanics;



    


    private bool activated = false;


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            playerMechanics.increaseIntensity(10f);
            //Destroy(collider2D);
        }
    }


    public bool getActivated()
    {
        return activated;
    }
}
