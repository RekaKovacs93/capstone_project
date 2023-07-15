using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTrigger : MonoBehaviour
{

    public new Collider2D collider2D;

    AudioSource audio;

    [SerializeField]
    private Portal portal;

    private bool activated = false;



    private void Update()
    {
    

        if (GetComponent<UnityEngine.Rendering.Universal.Light2D>().intensity < 50f && activated)
        {
            GetComponent<UnityEngine.Rendering.Universal.Light2D>().intensity += 5f * Time.deltaTime;
        }

    }




    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player") && activated == false)
        {
            //Debug.Log()
            audio = GetComponent<AudioSource>();
            activated = true;
            portal.checkPortalTriggers();
            Debug.Log(GetComponent<UnityEngine.Rendering.Universal.Light2D>().intensity);
            audio.Play();
            //GetComponent<UnityEngine.Rendering.Universal.Light2D>().intensity += 109f;

        }
    }


    public bool getActivated()
    {
        return activated;
    }
}
