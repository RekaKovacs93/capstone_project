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

    [SerializeField]
    private GameObject narrationText7;

    [SerializeField]
    private GameObject narrationText8;

    [SerializeField]
    private GameObject narrationText9;

    [SerializeField]
    private GameObject narrationText10;

    [SerializeField]
    private GameObject narrationText11;

    [SerializeField]
    private GameObject narrationText12;

    [SerializeField]
    private GameObject narrationText13;

    [SerializeField]
    private GameObject narrationText14;

    [SerializeField]
    private GameObject narrationText15;

    [SerializeField]
    private GameObject narrationText16;

    [SerializeField]
    private GameObject narrationText17;

    new AudioSource audio;

    public void MusicFade()
    {
        audio = GetComponent<AudioSource>();
        if (audio.volume > 0)
        {
            audio.volume -= 0.0003f;
        }
    }

    void Start()
    {

        narrationText1.SetActive(false);
        narrationText2.SetActive(false);
        narrationText3.SetActive(false);
        narrationText4.SetActive(false);
        narrationText5.SetActive(false);
        narrationText6.SetActive(false);
        narrationText7.SetActive(false);
        narrationText8.SetActive(false);
        narrationText9.SetActive(false);
        narrationText10.SetActive(false);
        narrationText11.SetActive(false);
        narrationText12.SetActive(false);
        narrationText13.SetActive(false);
        narrationText14.SetActive(false);
        narrationText15.SetActive(false);
        narrationText16.SetActive(false);
        narrationText17.SetActive(false);
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
            narrationText1.SetActive(false);
            narrationText2.SetActive(true);
        }
        if (timer > 24.8)
        {
            narrationText2.SetActive(false);
            narrationText3.SetActive(true);
        }
        if (timer > 30)
        {
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
        if (timer > 33.8)
        {
            narrationText4.SetActive(false);
            narrationText5.SetActive(false);
        }
        if (timer > 35)
        {
            narrationText6.SetActive(true);
        }
        if (timer > 36)
        {
            narrationText6.SetActive(false);
            narrationText7.SetActive(true);
        }
        if (timer > 37.5)
        {
            narrationText7.SetActive(false);
            narrationText8.SetActive(true);
        }
        if (timer > 40)
        {
            narrationText8.SetActive(false);
            narrationText9.SetActive(true);
        }
        if (timer > 42)
        {
            narrationText9.SetActive(false);
            narrationText10.SetActive(true);
        }
        if (timer > 46)
        {
            narrationText10.SetActive(false);
        }
        if (timer > 47)
        {
            narrationText11.SetActive(true);
        }
        if (timer > 49)
        {
            narrationText11.SetActive(false);
        }
        if (timer > 51)
        {
            narrationText12.SetActive(true);
        }
        if (timer > 53.5)
        {
            narrationText12.SetActive(false);
            narrationText13.SetActive(true);
        }
        if (timer > 54.5)
        {
            narrationText13.SetActive(false);
            narrationText14.SetActive(true);
        }
        if (timer > 57)
        {
         
            narrationText14.SetActive(false);
        }
        if (timer > 58)
        {
            narrationText15.SetActive(true);
        }
        if (timer > 60)
        {
            narrationText15.SetActive(false);
            narrationText16.SetActive(true);
            
        }
        if (timer > 62)
        {
            narrationText16.SetActive(false);
            narrationText17.SetActive(true);
        }
        if (timer > 64)
        {
            
        }
        if (timer > 64)
        {
            MusicFade();
        }
        if (timer > 70)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }


  
}
