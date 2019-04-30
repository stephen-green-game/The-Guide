using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal_teleport_orb : MonoBehaviour
{
    public Transform Destination;

    public new Vector3 dest;

    private void Start()
    {
        dest = Destination.position;
    }



    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "light_orb")
        {
            other.transform.position = dest;
        }
    }


}
