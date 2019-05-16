using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class end_of_level : MonoBehaviour {

    public Transform Destination;

    public bool player_fallen;

    private Transform player;


    public void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }



    public void OnTriggerEnter(Collider other)
    {
    if (other.tag == "Player")
    {
    StartCoroutine(teleport());
    }

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && player_fallen == false)
        {
            StartCoroutine(teleport());
        }

    }

    public void FixedUpdate()
    {
        if(player_fallen)
        {
            player.position = Destination.position;
            GameObject.FindGameObjectWithTag("pause").GetComponent<pause_menu>().current_ui.GetComponent<CanvasGroup>().alpha = 0f;
        }
        else
        {
            GameObject.FindGameObjectWithTag("pause").GetComponent<pause_menu>().current_ui.GetComponent<CanvasGroup>().alpha = 1f;

        }
    }

    IEnumerator teleport()
    {
        player_fallen = true;
        yield return new WaitForSeconds(2);
        player_fallen = false;
    }


}
