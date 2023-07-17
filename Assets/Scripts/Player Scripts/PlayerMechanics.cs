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

    }
    public void IncreaseLight()
    {
        lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().intensity += 10f * Time.deltaTime;
        lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().pointLightOuterRadius += 0.069f * Time.deltaTime;
        lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().pointLightInnerRadius += 0.015f * Time.deltaTime;
    }

    public void DropPopLight()
    {
        GameObject newPopLIght = Instantiate(popLightPrefab, pos, Quaternion.identity);
        lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().intensity -= 10f * Time.deltaTime;
        lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().pointLightOuterRadius -= 0.069f * Time.deltaTime;
        lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().pointLightInnerRadius -= 0.015f * Time.deltaTime;

    }
    public void DrainLight()
    {
        lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().intensity -= 0.1f * Time.deltaTime;
        lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().pointLightOuterRadius -= 0.01f * Time.deltaTime;
        lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().pointLightInnerRadius -= 0.01f * Time.deltaTime;
    }

    public void SetLevelOver(bool status)
    {
        LevelOver = status;
    }


    public void CrystalReducePlayerLight()
    {
        lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().intensity -= 50f;
        lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().pointLightOuterRadius -= 3f;
        lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().pointLightInnerRadius -= 5f;
        Debug.Log(lightBoy.GetComponent<UnityEngine.Rendering.Universal.Light2D>().intensity);
    }

}
