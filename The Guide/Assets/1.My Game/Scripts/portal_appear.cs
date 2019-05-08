using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal_appear : MonoBehaviour
{
    public GameObject portals;

    private void Start()
    {
        portals.SetActive(false);
    }


    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            portals.SetActive(true);
        }
    }
}
