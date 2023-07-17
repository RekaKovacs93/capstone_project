using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpokenIntroScript : MonoBehaviour
{

    new AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("PlayAudio", 15f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PlayAudio()
    {
        audio = GetComponent<AudioSource>();
        audio.Play();
    }
}
