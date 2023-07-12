using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Edible : MonoBehaviour
{

    public new Collider2D collider2D;

    [SerializeField]
    private PlayerMechanics playerMechanics;

    private void Start()
    {
        this.gameObject.SetActive(true);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            playerMechanics.increaseIntensity(10f);
            this.gameObject.SetActive(false);
        }
    }



}
