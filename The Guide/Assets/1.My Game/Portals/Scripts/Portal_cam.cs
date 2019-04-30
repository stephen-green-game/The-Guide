using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal_cam : MonoBehaviour
{
    private Transform player_cam;
    public Transform this_portal;
    public Transform other_portal;

    void Start()
    {
        player_cam = GameObject.FindGameObjectWithTag("MainCamera").transform;
    }

    void Update()
    {
        Vector3 player_offset_from_portal = player_cam.position - this_portal.position;
        transform.position = other_portal.position + player_offset_from_portal;

        float angular_diff_portal_ro = Quaternion.Angle(other_portal.rotation, this_portal.rotation);

        Quaternion port_ro_diff = Quaternion.AngleAxis(angular_diff_portal_ro, Vector3.up);
        Vector3 new_cam_dir = port_ro_diff * player_cam.forward;
        transform.rotation = Quaternion.LookRotation(new_cam_dir, Vector3.up);
    }
}
