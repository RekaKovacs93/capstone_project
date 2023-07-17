using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialTextScript : MonoBehaviour
{
    //[SerializeField]
    //private GameObject canvas;

    [SerializeField]
    private GameObject text;



    [SerializeField]
    private Collider2D textTrigger;


    // Start is called before the first frame update
    void Start()
    {
        text.SetActive(false);
    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            text.SetActive(true);

        }


    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        text.SetActive(false);
    }
}
