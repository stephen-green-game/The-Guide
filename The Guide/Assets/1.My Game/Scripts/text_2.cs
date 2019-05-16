using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class text_2 : MonoBehaviour
{
    public GameObject _text;
    public GameObject _text_2;

    void Start()
    {
        _text.SetActive(false);
        _text_2.SetActive(false);

    }


    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(destroy());
        }
    }



    IEnumerator destroy()
    {
        _text.SetActive(true);
        _text_2.SetActive(true);


        yield return new WaitForSeconds(7);

        Destroy(_text);
        Destroy(_text_2);
    }
}
