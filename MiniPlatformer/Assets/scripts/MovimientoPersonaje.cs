using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour {

    private GameManager m_GameManager;
    public float m_Speed;
    public GameObject SpawnSalto;
    bool salto = false;
    bool suelo;
    public Rigidbody2D personaje;

    
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

         if (Input.GetKeyUp(KeyCode.Space)&& suelo == true)
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
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("suelo"))
        {
            suelo = true;

        }
    }

}
