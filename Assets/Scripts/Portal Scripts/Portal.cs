using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Portal : MonoBehaviour
{

    public new Collider2D collider2D;

    private bool portalOpen = false;

    [SerializeField] private PlayerMechanics playerMechanics;

    [SerializeField] private GameEngine gameEngine;


    [SerializeReference]  private List<PortalTrigger> triggers;


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
            GetComponent<UnityEngine.Rendering.Universal.Light2D>().intensity += 100f;
            Debug.Log("Portal now active");
        }
        
    }


}
