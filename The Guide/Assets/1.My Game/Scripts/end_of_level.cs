using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class end_of_level : MonoBehaviour {

    public Transform Destination;

    public new Vector3 dest;

    private void Start()
    {
        dest = Destination.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            other.transform.position = dest;

        }
    }



}
