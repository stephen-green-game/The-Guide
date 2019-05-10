using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class end_of_level : MonoBehaviour {

    public Transform Destination;

    private bool player_fallen;

    private Transform player;


    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }



    private void OnTriggerEnter(Collider other)
    {
    if (other.tag == "Player")
    {
    StartCoroutine(teleport());
    }

    }

    private void FixedUpdate()
    {
        if(player_fallen)
        {
            player.position = Destination.position;
        }
    }

    IEnumerator teleport()
    {
        player_fallen = true;
        yield return new WaitForSeconds(0.1f);
        player_fallen = false;
    }


}
