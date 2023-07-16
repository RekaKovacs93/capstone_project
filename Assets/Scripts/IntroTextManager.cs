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

    new AudioSource audio;

    public void MusicFade()
    {
        audio = GetComponent<AudioSource>();
        if (audio.volume > 0)
        {
            audio.volume -= 0.0005f;
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
        if (timer > 24.8)
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
        if (timer > 37)
        {
            narrationText7.SetActive(false);
            narrationText8.SetActive(true);
        }
        if (timer > 39)
        {
            narrationText8.SetActive(false);
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
