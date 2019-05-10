using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class light_orb : MonoBehaviour
{
    public GameObject light_orbs;
    public float shoot_force = 1000;
    public float cooldown = 1;
    public AudioSource sound;
    public float max_energy = 0.9f;
    public float start_energy = 0.1f;

    public float curent_energy;
    public Image energy_bar;

    GameObject orb;
    float shoot_timer = 0;

     void Start()
    {
        curent_energy = start_energy;
        sound = GetComponent<AudioSource>();

    }

    void Update()
    { 

        if (Input.GetMouseButtonDown(0) && shoot_timer >= cooldown &&  curent_energy > 0)
        {
            spawn_new_ball();
            //reset cooldown
            shoot_timer = 0;

        }

        shoot_timer += Time.deltaTime;

        energy_bar.fillAmount = curent_energy;

        if (curent_energy > max_energy)
        {
            curent_energy = max_energy;
        }
    }


    void spawn_new_ball()
    {
        //creates object
        orb = GameObject.Instantiate(light_orbs as GameObject);
        //
        orb.transform.position = transform.position;
        Rigidbody my_rb = orb.GetComponent<Rigidbody>();
        my_rb.AddForce(transform.forward * shoot_force, ForceMode.Force);

        energy_bar.fillAmount = curent_energy - 0.1f;
        curent_energy = curent_energy - 0.1f;
        sound.Play();

    }


  



}
