using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTrigger : MonoBehaviour
{

    public new Collider2D collider2D;

    [SerializeField]
    private Portal portal;


    private bool activated = false;


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player") && activated == false)
        {
            //Debug.Log()
            activated = true;
            portal.checkPortalTriggers();
            Debug.Log(GetComponent<UnityEngine.Rendering.Universal.Light2D>().intensity);
            GetComponent<UnityEngine.Rendering.Universal.Light2D>().intensity += 109f;

        }
    }


    public bool getActivated()
    {
        return activated;
    }
}
