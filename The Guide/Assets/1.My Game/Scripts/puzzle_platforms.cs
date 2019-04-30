using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzle_platforms : MonoBehaviour
{
    public GameObject platform;
    public GameObject platform_controller;
    

    private void Start()
    {
        platform.SetActive(false);
        

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
           
            
                platform.SetActive(true);
           
            
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player" && platform_controller.GetComponent<box_appear>().shot == false)
        {
            platform.SetActive(false);
        
        }
    }
}
