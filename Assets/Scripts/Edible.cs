using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Edible : MonoBehaviour
{
    new AudioSource audio;

    public new Collider2D collider2D;

    [SerializeField]
    private PlayerMechanics playerMechanics;



    private void Start()
    {
        this.gameObject.SetActive(true);
        audio = GetComponent<AudioSource>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        

        if (collision.CompareTag("Player"))
        {

            audio.Play();
            playerMechanics.increaseLight();
            Invoke("disableEdible", 0.1f);
       
            
        }
    }
    private void disableEdible() {
        this.gameObject.SetActive(false);

}

}
