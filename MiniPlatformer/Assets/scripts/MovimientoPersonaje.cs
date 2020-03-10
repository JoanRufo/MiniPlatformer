using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour {

    private GameManager m_GameManager;
    public float m_Speed;
    bool salto = false;
    bool suelo;
    public Rigidbody2D personaje;
    bool plataforma;

    
    void Start () {

        m_GameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();

    }
	
	
	void Update () {
        if (Input.GetAxis("Horizontal")>0)
        {
            this.transform.position += this.transform.right * Time.deltaTime * m_Speed;


        }

        else if (Input.GetAxis("Horizontal")<0)
        {


            this.transform.position += -this.transform.right * Time.deltaTime * m_Speed;

        }

         if (Input.GetKeyDown(KeyCode.Space)&& (suelo == true || plataforma == true))
         {
            personaje.AddForce(Vector3.up * m_Speed, ForceMode2D.Impulse); 
            
         }

        
    }


    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("suelo")) 
        {
            suelo = false;
            

        }
        if (collision.gameObject.CompareTag("plataforma"))
            {
            plataforma = false;
            }
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("suelo"))
        {
            suelo = true;


        }
        if (collision.gameObject.CompareTag("plataforma"))
        {
            plataforma = true;
        }

    }

}
