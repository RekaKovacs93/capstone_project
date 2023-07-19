using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Edible : MonoBehaviour
{
    new AudioSource audio;

    public new Collider2D collider2D;

    [SerializeField]
    private PlayerMechanics playerMechanics;

    private bool isEdible;



    private void Start()
    {
        this.gameObject.SetActive(true);
        isEdible = true;
        audio = GetComponent<AudioSource>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        

        if (collision.CompareTag("Player") && isEdible)
        {
            Debug.Log("I am colliding");
            this.gameObject.GetComponent<UnityEngine.Rendering.Universal.Light2D>().intensity = 0;
            audio.Play();
            playerMechanics.IncreaseLight();
            isEdible = false;
            Invoke("disableEdible", 3f);
       
            
        }
    }
    private void disableEdible() {
        this.gameObject.SetActive(false);

}
    

}
