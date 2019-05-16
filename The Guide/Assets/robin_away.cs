using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robin_away : MonoBehaviour
{
    public Animator anim;


    

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            anim.SetBool("end_game", true);
        }
    }
}
