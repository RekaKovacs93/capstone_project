using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Movement : MonoBehaviour
{
    public Tilemap tilemap;
    public Rigidbody2D lightBoy;

    public float speed = 10.5f;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey("w"))
        {
            pos.y += speed * Time.deltaTime;
            //pos.x += speed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            pos.y -= speed * Time.deltaTime; 
            //pos.x -= speed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            pos.x += speed * Time.deltaTime;
            //pos.y -= speed * Time.deltaTime /2;
        }
        if (Input.GetKey("a"))
        {
            pos.x -= speed * Time.deltaTime;
            //pos.y += speed * Time.deltaTime /2;
        }
        
        lightBoy.transform.position = pos;
    }
}
