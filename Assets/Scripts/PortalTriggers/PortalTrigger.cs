using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTrigger : MonoBehaviour
{

    public Collider2D collider2D;

    AudioSource audio;

    [SerializeField]
    private Portal portal;

    private bool activated = false;


    [SerializeField] PlayerMechanics player;

    

    private void Update()
    {
    

        if (GetComponent<UnityEngine.Rendering.Universal.Light2D>().intensity > 100f && GetComponent<UnityEngine.Rendering.Universal.Light2D>().intensity < 70 && activated)
        {
            GetComponent<UnityEngine.Rendering.Universal.Light2D>().intensity -= 5f * Time.deltaTime;
            GetComponent<UnityEngine.Rendering.Universal.Light2D>().pointLightOuterRadius = 50f * Time.deltaTime;
        }

    }




    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player") && activated == false)
        {
            Debug.Log(player);
            GetComponent<UnityEngine.Rendering.Universal.Light2D>().intensity = 150f;
            audio = GetComponent<AudioSource>();
            activated = true;
            portal.checkPortalTriggers();
            player.CrystalReducePlayerLight();
            audio.Play();

        }
    }


    public bool getActivated()
    {
        return activated;
    }
}
