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

    private bool LevelOver = false;

    [SerializeField] private GameObject popLightPrefab;

    private Vector3 pos;


    private Queue<float> queue; // TODO: initialize
    private int smoothing = 5;

 


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

        if (Input.GetKey("w") && !LevelOver)
        {
            
            pos.y += speed * Time.deltaTime;
            countDown.moveDrain();
            DrainLight();
        }
        if (Input.GetKey("s") && !LevelOver)
        {
            
            pos.y -= speed * Time.deltaTime;
            countDown.moveDrain();
            DrainLight();
        }
        if (Input.GetKey("d") && !LevelOver)
        {
            
            pos.x += speed * Time.deltaTime;
            countDown.moveDrain();
            DrainLight();

        }
        if (Input.GetKey("a") && !LevelOver)
        {
            
            pos.x -= speed * Time.deltaTime;
            countDown.moveDrain();
            DrainLight();
        }
        
        lightBoy.transform.position = pos;

        if (lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().pointLightOuterRadius < 0.3f && !LevelOver)
        {
            Debug.Log("Noooooooooooo");
            gameEngine.ActivateLoseScreen();
            SetLevelOver(true);

        }

        if (Input.GetKeyDown("x"))
        {
            DropPopLight();
            
        }

        if (lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().pointLightOuterRadius < 0.4)
        {
            StartCoroutine(Flicker());
        }

    }

 
    public void IncreaseLight()
    {
        Debug.Log("Before "+"Intensity "+ lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().intensity + "Outer " + lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().pointLightOuterRadius + "Inner " + lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().pointLightInnerRadius);
        if (lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().intensity <= 80) {
            lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().intensity += 20f;
        } else
        {
            lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().intensity = 100f;
        }
        if (lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().pointLightOuterRadius <= 0.552)
        {
            lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().pointLightOuterRadius += 0.138f;
        } else
        {
            lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().pointLightOuterRadius = 0.69f;
        }
        if (lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().pointLightInnerRadius <= 0.12)
        {
            lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().pointLightInnerRadius += 0.03f;
        }
        else
        {
            lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().pointLightInnerRadius = 0.15f;
        }
        Debug.Log("After "+"Intensity " + lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().intensity + "Outer " + lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().pointLightOuterRadius + "Inner " + lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().pointLightInnerRadius);
    }

    public void DropPopLight()
    {
        
        GameObject newPopLIght = Instantiate(popLightPrefab, pos, Quaternion.identity);
        lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().intensity -= 20f;
        lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().pointLightOuterRadius -= 0.0138f;
        lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().pointLightInnerRadius -= 0.03f;

    }
    public void DrainLight()
    {
        lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().intensity -= 0.6f * Time.deltaTime;
        lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().pointLightOuterRadius -= 0.00414f * Time.deltaTime;
        lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().pointLightInnerRadius -= 0.0009f * Time.deltaTime;
    }

    public void SetLevelOver(bool status)
    {
        LevelOver = status;
    }


    public void CrystalReducePlayerLight()
    {
        lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().intensity -= 20f;
        lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().pointLightOuterRadius -= 0.138f;
        lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().pointLightInnerRadius -= 0.3f;
        Debug.Log("I have reduced the light to "+lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().intensity);
    }

    IEnumerator Flicker()
    {
        //while (true)
        //{
            lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().intensity = Random.Range(10, 30);
            var randomTime = Random.Range(0, 0.5f);
            yield return new WaitForSeconds(randomTime);
        //}
    }

}
