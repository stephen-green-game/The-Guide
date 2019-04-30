using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal_texture_setup : MonoBehaviour
{
    public Camera in_cam;
    public Camera out_cam;

    public Material cam_matt_out;
    public Material cam_matt_in;

    void Start()
    {
        if (out_cam.targetTexture != null)
        {
            out_cam.targetTexture.Release();
        }

        out_cam.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);

        cam_matt_out.mainTexture = out_cam.targetTexture;

        if (in_cam.targetTexture != null)
        {
            in_cam.targetTexture.Release();
        }

        in_cam.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);

        cam_matt_in.mainTexture = in_cam.targetTexture;
    }
}
