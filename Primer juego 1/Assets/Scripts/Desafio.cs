using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Desafio : MonoBehaviour
{
    public float cron;
    public GameObject Textgsd, Part32, Finalpart, Principio;
    void Update()
    {
        cron += 1 * Time.deltaTime;
        twe();
       fgsg();
        sgsd();
        Principio2();
    }
    void twe()
    {if(cron >= 80f && Textgsd != null)
        {
            Textgsd.SetActive(true);
           
        }


    }
    void fgsg()
    {
 if(cron >= 140f && Part32 != null)
        {
            Part32.SetActive(true);
            
        }

    }
    void sgsd()
    {
if(cron >= 160f && Finalpart != null)
        {
            Finalpart.SetActive(true);

        }

    }
    void Principio2()
    {
     if(cron >= 40f && Principio != null)
        {
            Principio.SetActive(true);

        }
      

    }







}

