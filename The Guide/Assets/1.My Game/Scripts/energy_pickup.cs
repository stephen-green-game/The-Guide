using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class energy_pickup : MonoBehaviour
{
    public GameObject particles;
    public int vaule = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            StartCoroutine(add_energy());

        }


    }

    IEnumerator add_energy()
    {
        FindObjectOfType<light_orb>().curent_energy = FindObjectOfType<light_orb>().curent_energy + vaule;

        Destroy(particles);

        yield return new WaitForSeconds(5);

        Destroy(gameObject);
    }


}
