using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal_teleport : MonoBehaviour
{
    private Transform player;
    public Transform destination;
    private float rotation_difference = 180;
    private bool player_in_portal = false;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void FixedUpdate()
    {
        if (player_in_portal)
        {
            //player.position = destination.position;

            Vector3 portal_to_player = player.position - transform.position;
            float dot_product = Vector3.Dot(transform.up, portal_to_player);

            if (dot_product < 0f)
            {
                float ro_diff = -Quaternion.Angle(transform.rotation, destination.rotation);

                ro_diff += rotation_difference;

                player.Rotate(Vector3.up, ro_diff);

                Vector3 pos_offset = Quaternion.Euler(0f, ro_diff, 0f) * portal_to_player;
                player.position = destination.position + pos_offset;

                player_in_portal = false;
            }


        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //StartCoroutine(teleport());
            player_in_portal = true;
        }
        //player.GetComponent<CharacterController>().enabled = false;
        //player.GetComponent<CharacterController>().enabled = true;

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            player_in_portal = false;
        }
    }


    IEnumerator teleport()
    {
        player_in_portal = true;
        yield return new WaitForSeconds(0.01f);
        player_in_portal = false;
    }
}
