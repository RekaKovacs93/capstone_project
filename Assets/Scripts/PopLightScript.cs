using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopLight : MonoBehaviour
{

    public new Collider2D collider2D;

    private PlayerMechanics playerMechanics;

    [SerializeField]
    private AudioSource audioSource;

    private bool canBeEaten = false;

    private void Start()
    {
        this.gameObject.SetActive(true);
        playerMechanics = FindObjectOfType<PlayerMechanics>();
        Invoke("makeEdible", 3f);

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player") && canBeEaten)
        {
            audioSource.Play();
            this.gameObject.GetComponent<UnityEngine.Rendering.Universal.Light2D>().intensity = 0;
            playerMechanics.IncreaseLight();
            canBeEaten = false;
            Invoke("Disappear", 3f);
        }
    }

    private void makeEdible()
    {
        canBeEaten = true;
    }

    private void Disappear()
    {
        this.gameObject.SetActive(false);
    }




}

