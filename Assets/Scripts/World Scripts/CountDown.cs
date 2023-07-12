using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountDown : MonoBehaviour
{


    private bool timesUp = false;

    public float timeValue = 10;

    public void moveDrain()
    {
        if (timeValue > 0 && !timesUp)
        {
            timeValue -= Time.deltaTime;
            
        }
        else 
        {
            timesUp = true;
        }
        
    }

    

}
