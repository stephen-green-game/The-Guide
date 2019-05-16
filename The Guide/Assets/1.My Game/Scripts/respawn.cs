using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] public Transform respawn_point;
    private bool player_died = false;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }


     void OnTriggerEnter(Collider other)
    {
        if (other == player)
        {
            player_died = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other == player)
        {
            player_died = false;
        }
    }

    private void FixedUpdate()
    {
        if (player_died == true)
        {
            player.transform.position = respawn_point.position;
        }

    }

}
