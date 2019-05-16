using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ammo : MonoBehaviour
{
    private GameObject cam;
    public int num_of_orbs;
    public int energy;

    public Image[] symbol;
    public Sprite full_symbol;
    public Sprite empty_symbol;


    void Start()
    {
        cam = Camera.main.gameObject;

    }

    void Update()
    {
        num_of_orbs = cam.GetComponent<light_orb>().curent_energy;
        energy = cam.GetComponent<light_orb>().max_energy;

        for (int i = 0; i < symbol.Length; i++)
        {
            if (i < energy)
            {
                symbol[i].sprite = full_symbol;
            }
            else
            {
                symbol[i].sprite = empty_symbol;
            }


            if (i < num_of_orbs)
            {
                symbol[i].enabled = true;
            }
            else
            {
                symbol[i].enabled = false;
            }
        }
    }
}
