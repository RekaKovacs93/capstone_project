using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleMovement : MonoBehaviour
{

    public float YfloatHeight = 0.15f;      
    public float YfloatSpeed = 0.7f;       
    public float XfloatHeight = 0.05f;      
    public float XfloatSpeed = 0.7f;


    private Vector3 startPosition;
    private float time;

    private void Start()
    {
        startPosition = transform.position;
    }

    private void Update()
    {
        time += Time.deltaTime;
        float newY = startPosition.y + Mathf.Sin(time * YfloatSpeed) * YfloatHeight;
        float newX = startPosition.x + Mathf.Sin(time * XfloatSpeed) * XfloatHeight;
        transform.position = new Vector3(startPosition.x, newY, startPosition.z);
    }

}
