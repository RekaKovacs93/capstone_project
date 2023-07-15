using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroTextManager : MonoBehaviour
{

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
        
    }
}
