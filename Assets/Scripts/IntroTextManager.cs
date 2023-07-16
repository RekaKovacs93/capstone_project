using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroTextManager : MonoBehaviour
{

    [SerializeField]
    private float timer = 0;

    [SerializeField]
    private GameObject narrationText1;

    [SerializeField]
    private GameObject narrationText2;

    [SerializeField]
    private GameObject narrationText3;

    [SerializeField]
    private GameObject narrationText4;

    [SerializeField]
    private GameObject narrationText5;

    [SerializeField]
    private GameObject narrationText6;



    void Start()
    {

        narrationText1.SetActive(false);
        narrationText2.SetActive(false);
        narrationText3.SetActive(false);
        narrationText4.SetActive(false);
        narrationText5.SetActive(false);
        narrationText6.SetActive(false);
    }

 
    void Update()
    {
        if (timer < 1000)
        {
            timer += Time.deltaTime;
        }

        if (timer > 16)
        {
            narrationText1.SetActive(true);
        }

        if (timer > 20)
        {
            narrationText2.SetActive(true);
        }
        if (timer > 24)
        {
            narrationText3.SetActive(true);
        }
        if (timer > 30)
        {
            narrationText1.SetActive(false);
            narrationText2.SetActive(false);
            narrationText3.SetActive(false);
        }
        if (timer > 31)
        {
            narrationText4.SetActive(true);
        }
        if (timer > 32)
        {
            narrationText5.SetActive(true);
        }
        if (timer > 33.5)
        {
            narrationText4.SetActive(false);
            narrationText5.SetActive(false);
        }
        if (timer > 50)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }


  
}
