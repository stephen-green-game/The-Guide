using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pick_up : MonoBehaviour
{
    public AudioSource sound;
    public Animator ring;


    private void Start()
    {
        ring = GameObject.FindGameObjectWithTag("ring").GetComponent<Animator>();
        sound = GetComponent<AudioSource>();

    }

    void OnMouseEnter()
    { 
       sound.Play();
        ring.SetBool("seen", true);

    }

    private void OnMouseExit()
    {
        sound.Stop();
        ring.SetBool("seen", false);

    }


}
