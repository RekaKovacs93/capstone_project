using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Portal : MonoBehaviour
{
    AudioSource audio;
    public new Collider2D collider2D;

    private bool portalOpen = false;

    [SerializeField] private PlayerMechanics playerMechanics;

    [SerializeField] private GameEngine gameEngine;


    [SerializeReference]  private List<PortalTrigger> triggers;


    private void Update()
    {
        if (GetComponent<UnityEngine.Rendering.Universal.Light2D>().pointLightOuterRadius < 1)
        {
            GetComponent<UnityEngine.Rendering.Universal.Light2D>().pointLightOuterRadius += 0.09f * Time.deltaTime;
        }
        

        if (GetComponent<UnityEngine.Rendering.Universal.Light2D>().pointLightInnerAngle < 130f && GetComponent<UnityEngine.Rendering.Universal.Light2D>().pointLightOuterRadius >= 1 && portalOpen)
        {
            GetComponent<UnityEngine.Rendering.Universal.Light2D>().pointLightOuterAngle += 50f * Time.deltaTime;
            GetComponent<UnityEngine.Rendering.Universal.Light2D>().pointLightInnerAngle += 50f * Time.deltaTime;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && portalOpen)
        {
            gameEngine.ActivateWinScreen();
            playerMechanics.setLevelOver(true);
         }

        else if (collision.CompareTag("Player")){
            Debug.Log("I am lost in darkness exdee");
        }
    }

    public void checkPortalTriggers() {

        bool check = true;

        foreach (PortalTrigger trigger in triggers)
        {
            if (!trigger.getActivated())
            {
                check = false;
            }
        }

        if (check)
        {
            portalOpen = true;
            audio = GetComponent<AudioSource>();
            audio.Play();
            GetComponent<UnityEngine.Rendering.Universal.Light2D>().intensity += 100f;
            Debug.Log("Portal now active");
        }
        
    }


}
