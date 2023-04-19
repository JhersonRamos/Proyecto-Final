using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FlamerEnemy : MonoBehaviour
{
    public int rutinas;
    public float cronometro;
    public Animator ani;
    public Quaternion angulo;
    public float grados;
    public GameObject target;
    public NavMeshAgent Agente;
    public float distancia_ataque, radio_vision;
    void Start()
    {
        ani = GetComponent<Animator>();
        target = GameObject.Find("Player");
    }

    public void ComportamientoEnemigo()
    {
        if (Vector3.Distance(transform.position, target.transform.position) > radio_vision && ani == null)
        {
            Agente.enabled = false;
        ani.SetBool("run", false);
        cronometro += 1 * Time.deltaTime;
        if (cronometro >= 4)
        {
            rutinas = Random.Range(0, 3);
            cronometro = 0;
        }
        switch (rutinas)
        {
            case 0:
                ani.SetBool("walk", false); 
                    break;
            
            case 1:
                grados = Random.Range(0, 360);
                angulo = Quaternion.Euler(0, grados, 0);
                rutinas++;
                break;

            case 2:
                transform.rotation = Quaternion.RotateTowards(transform.rotation, angulo, 0.5f);
                transform.Translate(Vector3.forward * 1 * Time.deltaTime);
                ani.SetBool("walk", true);
                break;
            


        }

    }
    else
    {
       {
        var lookPos = target.transform.position - transform.position;
        lookPos.y = 0;
        var rotation = Quaternion.LookRotation(lookPos);
        /*transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, 3);
        ani.SetBool("walk", false);

        ani.SetBool("run", true);
        transform.Translate(Vector3.forward * 2 * Time.deltaTime);*/
        Agente.enabled = true;
        Agente.SetDestination(target.transform.position);
        if (Vector3.Distance(transform.position, target.transform.position) > distancia_ataque)
        {
            ani.SetBool("walk", false);                
            ani.SetBool("run", true);  
        }
        }
    }
    }

    void Update()
    {
        ComportamientoEnemigo();  
    }

    







}
