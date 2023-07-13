using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerMechanics : MonoBehaviour
{
    public Tilemap tilemap;
    public Rigidbody2D lightBoy;
    
    [SerializeField]
    private CountDown countDown;

    public float speed = 10.5f;


    // Start is called before the first frame update

        private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey("w"))
        {
            
            pos.y += speed * Time.deltaTime;
            countDown.moveDrain();
            lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().intensity -= 0.01f;
            lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().pointLightOuterRadius -= 0.0001f;
            //pos.x += speed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            
            pos.y -= speed * Time.deltaTime;
            countDown.moveDrain();
            lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().intensity -= 0.01f;
            lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().pointLightOuterRadius -= 0.0001f;
            //pos.x -= speed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            
            pos.x += speed * Time.deltaTime;
            countDown.moveDrain();
            lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().intensity -= 0.01f;
            lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().pointLightOuterRadius -= 0.0001f;
            //pos.y -= speed * Time.deltaTime /2;
        }
        if (Input.GetKey("a"))
        {
            
            pos.x -= speed * Time.deltaTime;
            countDown.moveDrain();
            lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().intensity -= 0.01f;
            lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().pointLightOuterRadius -= 0.0001f;
            //pos.y += speed * Time.deltaTime /2;
        }
        
        lightBoy.transform.position = pos;
    }
    public void increaseIntensity(float edibleValue)
    {
        lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().intensity += edibleValue;
    }

 

}
