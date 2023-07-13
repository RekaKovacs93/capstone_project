using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEngine : MonoBehaviour
{
    [SerializeField]
    private GameObject loseScreen;
    [SerializeField]
    private GameObject winScreen;

    // Start is called before the first frame update
    void Start()
    {
        loseScreen.SetActive(false);
        winScreen.SetActive(false);
    }


    public void ActivateLoseScreen()
    {
        loseScreen.SetActive(true);
    }


    public void ActivateWinScreen()
    {
        winScreen.SetActive(true);
    }

    // Update is called once per frame

}
