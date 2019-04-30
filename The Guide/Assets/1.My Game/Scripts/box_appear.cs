using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box_appear : MonoBehaviour
{
    public AudioSource bird;
    public GameObject platform;
    public bool shot;
    void Start()
    {
        if (platform.tag == "plat")
        {
            platform.SetActive(false);
        }

        bird = GetComponent<AudioSource>();

    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "light_orb")
        {
            platform.SetActive(true);
            shot = true;
            Destroy(other);

            platform.GetComponent<Animator>().SetBool("shot_at", true);
        }
    }

    void OnMouseEnter()
    {
        bird.Play();
        bird.UnPause();

    }

    void OnMouseExit()
    {
        bird.Pause();
    }

}
