using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopLight : MonoBehaviour
{

    public new Collider2D collider2D;

    [SerializeField]
    private PlayerMechanics playerMechanics;

    [SerializeField]
    private AudioSource audioSource;

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
            audioSource.Play();
            this.gameObject.GetComponent<UnityEngine.Rendering.Universal.Light2D>().intensity = 0;
            playerMechanics.IncreaseLight();
            Invoke("Disappear", 1f);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            canBeEaten = true;
        }
    }

    private void Disappear()
    {
        this.gameObject.SetActive(false);
    }

  
    
        
}

