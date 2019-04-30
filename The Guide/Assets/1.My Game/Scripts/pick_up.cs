using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pick_up : MonoBehaviour
{
    public AudioSource sound;
   

    private void Start()
    {

        sound = GetComponent<AudioSource>();

    }

    void OnMouseEnter()
    { 
       sound.Play();
    }

    private void OnMouseExit()
    {
        sound.Stop();
    }


}
