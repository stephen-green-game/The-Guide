using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class text : MonoBehaviour
{
    public GameObject _text;

    void Start()
    {
        _text.SetActive(false);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(destroy());
        }
    }



    IEnumerator destroy()
    {
        yield return new WaitForSeconds(5);

        _text.SetActive(true);

        yield return new WaitForSeconds(5);

        Destroy(gameObject);
    }
}
