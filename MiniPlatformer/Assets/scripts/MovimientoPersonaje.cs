using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour {

    private GameManager m_GameManager;
    public float m_Speed;
    // Use this for initialization
    void Start () {

        m_GameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxis("Horizontal")>0)
        {
            this.transform.position += this.transform.right * Time.deltaTime * m_Speed;


        }

        else if (Input.GetAxis("Horizontal")<0)
        {


            this.transform.position += -this.transform.right * Time.deltaTime * m_Speed;

        }
    }
}
