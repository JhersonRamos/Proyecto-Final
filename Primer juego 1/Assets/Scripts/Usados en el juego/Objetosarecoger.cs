using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objetosarecoger : MonoBehaviour
{
    public GameObject[] nusd;

    public int count = 0;

    void Update()
    {
        if (count == 5)
        {
            Debug.Log("Hola");
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Objetos_Interac"))
        {
            Destroy(collision.gameObject, 5f);
            count++;
        }
    }
}
