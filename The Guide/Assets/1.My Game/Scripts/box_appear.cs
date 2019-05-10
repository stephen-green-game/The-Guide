using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box_appear : MonoBehaviour
{
    public AudioSource bird;
    public GameObject platform;
    public Animator ring;
    public bool shot;

    void Start()
    {
        if (platform.tag == "plat")
        {
            platform.SetActive(false);
        }

        bird = GetComponent<AudioSource>();
        ring = GameObject.FindGameObjectWithTag("ring").GetComponent<Animator>();

    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "light_orb")
        {
            platform.SetActive(true);
            
            shot = true;

            platform.GetComponent<Animator>().SetBool("shot_at", true);
        }
    }

    void OnMouseEnter()
    {
        if (shot == false)
        {
            bird.Play();
            ring.SetBool("seen", true);
        }

    }

    void OnMouseExit()
    {
        ring.SetBool("seen", false);
    }

}
