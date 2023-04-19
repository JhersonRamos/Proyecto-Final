using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Raycasting : MonoBehaviour
{
    public float range = 20f;
    public Camera Cam;
    public int count = 0;
    public Text Pistas;
    

    void Start()
    {
        
    }

    
    void Update()
    {
        Debug.DrawRay(Cam.transform.position, Cam.transform.forward * range, Color.red);
        AbrirPuertas();
        if (count == 5)
        {
            SceneManager.LoadScene("Final");
        }
        if (count == 4)
        {
            Pistas.text = "pistas 4/5";
        }
        if (count == 3)
        {
            Pistas.text = "pistas 3/5";
        }
        if (count == 2)
        {
            Pistas.text = "pistas 2/5";
        }
        if (count == 1)
        {
            Pistas.text = "pistas 1/5";
        }
    }
    void AbrirPuertas()
    {
        RaycastHit Hit;
        if(Input.GetKeyDown(KeyCode.E)){
         if(Physics.Raycast(Cam.transform.position, Cam.transform.forward, out Hit, range, LayerMask.GetMask("Interactable")))
         {
           Hit.transform.GetComponent<Interactuar>().Interact();
         }
        }
        
         //if(Physics.Raycast(Cam.transform.position, Cam.transform.forward, out Hit, range, LayerMask.GetMask("Interactable")))
        //{
       //   icon.SetActive(true);
       //   texto.SetActive(true);
       // }else{icon.SetActive(false); texto.SetActive(false);}//
        
}
void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Objetos_Interac"))
        {
            Destroy(collision.gameObject);
            count++;
        }
    }
}
