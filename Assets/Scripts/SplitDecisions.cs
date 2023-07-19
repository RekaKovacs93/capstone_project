using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplitDecisions : MonoBehaviour
{
    [SerializeField]
    private GameObject splitDecisions;

    [SerializeField]
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        splitDecisions.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < 1000)
        {
            timer += Time.deltaTime;
        }
        if (timer > 7f)
        {
            Debug.Log("here should be a thing");
            splitDecisions.SetActive(true);
        }
        if (timer > 13f)
        {
            splitDecisions.SetActive(false);
        }
    }
    
}
