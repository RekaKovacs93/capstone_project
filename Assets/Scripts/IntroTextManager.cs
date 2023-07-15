using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroTextManager : MonoBehaviour
{
    //[SerializeField]
    //private IntroTimer timer;

    [SerializeField]
    private float timer = 0;

    [SerializeField]
    private GameObject narrationText1;

    [SerializeField]
    private GameObject narrationText2;

    [SerializeField]
    private GameObject narrationText3;
    // Start is called before the first frame update


    void Start()
    {

        narrationText1.SetActive(false);
        narrationText2.SetActive(false);
        narrationText3.SetActive(false);
    }

    // Update is called once per frame
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

        if (timer > 20.3)
        {
            narrationText2.SetActive(true);
        }
        if (timer > 24)
        {
            narrationText3.SetActive(true);
        }
        if (timer > 32)
        {
            narrationText1.SetActive(false);
            narrationText2.SetActive(false);
            narrationText3.SetActive(false);
        }
        if (timer > 40)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }


    //public void text1Disappear()
    //{
    //    narrationText1.SetActive(false);
    //}

}
