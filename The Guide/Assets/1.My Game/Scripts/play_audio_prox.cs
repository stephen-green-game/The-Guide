using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play_audio_prox : MonoBehaviour
{
    public AudioSource sound;
   

    private void Start()
    {
        sound = GetComponent<AudioSource>();

       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            sound.Play();
            sound.UnPause();
        }
       

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            sound.Pause();
        }
    }

    
}
