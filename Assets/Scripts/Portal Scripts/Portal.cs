using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Portal : MonoBehaviour
{
    AudioSource audio;

    Animator animator;

    public new Collider2D collider2D;

    private bool portalOpen = false;

    [SerializeField] private PlayerMechanics playerMechanics;

    [SerializeField] private GameEngine gameEngine;


    [SerializeReference]  private List<PortalTrigger> triggers;





    private void Update()
    {
        if(portalOpen)
        {
            GetComponent<UnityEngine.Rendering.Universal.Light2D>().intensity = Mathf.PingPong(Time.time * 40f, 30f);

        }



    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && portalOpen)
        {
            gameEngine.ActivateWinScreen();
            playerMechanics.SetLevelOver(true);
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
            
            audio = GetComponent<AudioSource>();
            audio.Play();
            Invoke("activateVisuals", 1f);
            Debug.Log("Portal now active");
        }
        
    }


    public bool getPortalStatus()
    {
        return portalOpen;
    }

    public void activateVisuals()
    {
        portalOpen = true;
        animator = GetComponent<UnityEngine.Animator>();
        animator.enabled = true;
    }

}
