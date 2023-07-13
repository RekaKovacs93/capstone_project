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

    [SerializeField]
    private GameEngine gameEngine;

    private bool LevelLost = false;

    [SerializeField] private GameObject popLightPrefab;

    private Vector3 pos;

    // Start is called before the first frame update

        private void Start()
    {
        lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().intensity = 100f;
        lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().pointLightOuterRadius = 0.69f;
        lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().pointLightInnerRadius = 0.15f;
    }

    // Update is called once per frame
    void Update()
    {
        pos = transform.position;

        if (Input.GetKey("w") && !LevelLost)
        {
            
            pos.y += speed * Time.deltaTime;
            countDown.moveDrain();
            lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().intensity -= 0.01f;
            lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().pointLightOuterRadius -= 0.0001f;
            lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().pointLightInnerRadius -= 0.0001f;
            //pos.x += speed * Time.deltaTime;
        }
        if (Input.GetKey("s") && !LevelLost)
        {
            
            pos.y -= speed * Time.deltaTime;
            countDown.moveDrain();
            lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().intensity -= 0.01f;
            lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().pointLightOuterRadius -= 0.0001f;
            lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().pointLightInnerRadius -= 0.0001f;
            //pos.x -= speed * Time.deltaTime;
        }
        if (Input.GetKey("d") && !LevelLost)
        {
            
            pos.x += speed * Time.deltaTime;
            countDown.moveDrain();
            lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().intensity -= 0.01f;
            lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().pointLightOuterRadius -= 0.0001f;
            lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().pointLightInnerRadius -= 0.0001f;
            //pos.y -= speed * Time.deltaTime /2;
        }
        if (Input.GetKey("a") && !LevelLost)
        {
            
            pos.x -= speed * Time.deltaTime;
            countDown.moveDrain();
            lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().intensity -= 0.01f;
            lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().pointLightOuterRadius -= 0.0001f;
            lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().pointLightInnerRadius -= 0.0001f;
            //pos.y += speed * Time.deltaTime /2;
        }
        
        lightBoy.transform.position = pos;

        if (lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().pointLightOuterRadius < 0.5f && !LevelLost)
        {
            Debug.Log("Noooooooooooo");
            gameEngine.ActivateLoseScreen();
            LevelLost = true;

        }

        if (Input.GetKeyDown("x"))
        {
            dropPopLight();
            
        }

    }
    public void increaseIntensity(float edibleValue)
    {
        lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().intensity += edibleValue;
    }

    public void dropPopLight()
    {
        GameObject newPopLIght = Instantiate(popLightPrefab, pos, Quaternion.identity); 
    }

}
