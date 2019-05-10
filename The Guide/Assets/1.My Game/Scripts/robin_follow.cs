using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robin_follow : MonoBehaviour
{
    private GameObject player;


    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }


    private void Update()
    {
        gameObject.transform.position = player.transform.position;
    }
}
