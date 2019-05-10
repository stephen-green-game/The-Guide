using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving_platform : MonoBehaviour
{

    public GameObject player;
    private Animator anim;
    public bool playing = false;
    public GameObject platform;
    private bool player_on_platform = false;

    private void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player");
    }


   private void Update()
    {
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("platform move right") || anim.GetCurrentAnimatorStateInfo(0).IsName("platform move left"))
        {
            playing = true;
        }
        else
        {
            playing = false;
        }
    }

    private void FixedUpdate()
    {
        if(player_on_platform == true)
        {
            player.transform.parent = platform.transform;
        }
    }


    public void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player" && playing == true)
        {
            player_on_platform = true;
            gameObject.GetComponent<BoxCollider>().isTrigger = false;

        }
        else
        {
            player_on_platform = false;
            gameObject.GetComponent<BoxCollider>().isTrigger = true;

        }
    }

}




