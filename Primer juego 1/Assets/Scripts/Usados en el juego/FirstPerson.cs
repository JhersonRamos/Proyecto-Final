using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FirstPerson : MonoBehaviour
{
    private new Rigidbody rigidbody;
    [Header("Movimiento")]
    public float speed = 3;
    bool m_Jump;
    public float JumpForce;
    public AudioSource Audiw;
    private bool Hactivo, Vactivo;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();

    }

   
    void Update()
    {
        UpdateMovement();
        //saltar();
    }                                                                     //Hacer el sistema de estamina, terminar la gravedad y hacer el nivel
    public void UpdateMovement() {
    
    float hor = Input.GetAxisRaw("Horizontal");
    float ver = Input.GetAxisRaw("Vertical");
    //MovimientoDelPlayer.SetFloat("XSpeed", hor);
    //MovimientoDelPlayer.SetFloat("YSpeed", ver);
    Vector3 velocity;
    if (hor !=0 || ver != 0) {

    Vector3 motion = (transform.forward * ver + transform.right * hor).normalized * speed;
    velocity = motion;
    
    }else{
     
     velocity = Vector3.zero;
      }  
     velocity.y = rigidbody.velocity.y;
     rigidbody.velocity = velocity;
    
    if(Input.GetButtonDown("Horizontal"))
    {
        if(Vactivo == false)
        {
            Audiw.Play();
            Hactivo = true;
        }
        

    }
    if(Input.GetButtonDown("Vertical"))
    {
        if(Hactivo == false)
        {
            Audiw.Play();
            Vactivo = true;
        }

    }
    if(Input.GetButtonUp("Horizontal"))
    {Hactivo = false;
        if(Vactivo == false)
        Audiw.Pause();

    }
    if(Input.GetButtonUp("Vertical"))
    {Vactivo = false;
        if(Hactivo == false)
        Audiw.Pause();

    }
    }

    
    
    
    /*void saltar()
    {
        if (Input.GetButtonDown("Jump"))
           rigidbody.AddForce(Vector3.up * JumpForce * Time.deltaTime, ForceMode.Impulse);
      
        if (Input.GetKeyDown(KeyCode.Space))
            m_Jump = true;

        else m_Jump = false;

        if (m_Jump == false)
            MovimientoDelPlayer.SetBool("Saltando", false);

        if (m_Jump == true)
            MovimientoDelPlayer.SetBool("Saltando", true);
    }
*/
}
