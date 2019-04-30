using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class object_destroy : MonoBehaviour
{
    public float life_span = 5;

    public int curent_light;


    float life_time = 0;

    void Start()
    {
        curent_light = 10;
    }

    void Update()
    {
        life_time += Time.deltaTime;
        if (life_time > life_span)
            Destroy(gameObject);
    }

    public void Add_light(int add_light)
    {
        curent_light = add_light + 10;
    }
}
