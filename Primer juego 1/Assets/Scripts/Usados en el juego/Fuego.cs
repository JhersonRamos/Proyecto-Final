using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuego : MonoBehaviour
{
    public GameObject Bala,padre;
    public Transform posSpawn;
    public float Tiempo = 5f;
    public float TiempoOriginal = 5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Temporizador();
    }

    void Temporizador()
{
    Tiempo -= Time.deltaTime;
    if (Tiempo <= 0)
    {
        RestartTemp();
        GameObject hijo = Instantiate(Bala, posSpawn.position, transform.rotation);
        hijo.transform.parent = padre.transform;

       
    }
}
    void RestartTemp()
    {
    Tiempo = TiempoOriginal;
    }
}
