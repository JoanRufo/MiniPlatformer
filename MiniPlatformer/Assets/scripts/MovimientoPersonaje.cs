using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour {

    private GameManager m_GameManager;
    public float m_speed;
    public float m_speedDash;
    bool m_dash;
    public Vector3 m_dashDistance;
    Vector3 m_destino;
    bool m_salto = false;
    bool m_suelo;
    public Rigidbody2D m_personaje;
    bool m_plataforma;
    public float currentCD_dash;
    public float CDMax_dash;


    
    void Start () {

        m_GameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        m_personaje = GetComponent<Rigidbody2D>();
    }
	
	
	void Update () {
        if (Input.GetAxis("Horizontal")>0)
        {
            this.transform.position += this.transform.right * Time.deltaTime * m_speed;
            GetComponent<SpriteRenderer>().flipX = false;
            

        }

        else if (Input.GetAxis("Horizontal")<0)
        {
            this.transform.position += -this.transform.right * Time.deltaTime * m_speed;
            GetComponent<SpriteRenderer>().flipX = true;

        }

        if (Input.GetKeyDown(KeyCode.Space)&& (m_suelo == true || m_plataforma == true))
        {
            m_personaje.AddForce(Vector3.up * m_speed, ForceMode2D.Impulse); 
            
        }
        if (Input.GetMouseButtonUp(0) && currentCD_dash >= CDMax_dash)
        {
            m_dash = true;
            if(Input.GetAxis("Horizontal") > 0)
            {
                m_destino = transform.position + m_dashDistance;
                
            }
            if (Input.GetAxis("Horizontal") < 0)
            {
                m_destino = transform.position - m_dashDistance;
                
            }
            currentCD_dash = 0;


        }
        if (currentCD_dash < CDMax_dash)
        {
            currentCD_dash += Time.deltaTime;
        }

        if (m_dash == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, m_destino, m_speedDash * Time.deltaTime);

        }
        if(m_dash == true && Vector3.Distance(transform.position, m_destino) < 0.25)
        {
            m_dash = false;
        }


    }


    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("suelo")) 
        {
            m_suelo = false;
            

        }
        if (collision.gameObject.CompareTag("plataforma"))
            {
            m_plataforma = false;
            }
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("suelo"))
        {
            m_suelo = true;


        }
        if (collision.gameObject.CompareTag("plataforma"))
        {
            m_plataforma = true;
        }

    }

}
