using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class energy_pickup : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            FindObjectOfType<light_orb>().curent_energy = FindObjectOfType<light_orb>().curent_energy + 0.1f;
        }

        Destroy(gameObject);

    }


}
