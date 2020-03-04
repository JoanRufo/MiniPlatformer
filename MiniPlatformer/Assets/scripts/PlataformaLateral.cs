using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaLateral : MonoBehaviour {
    public float m_speed;
    private GameManager m_GameManager;
    public GameObject SpawnIz;
    public GameObject SpawnDe;
    bool MovimientoDerecha;
    // Use this for initialization
    void Start () {
        m_GameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }
	
	// Update is called once per frame
	void Update () {
        if (MovimientoDerecha)
        {

            transform.position = Vector3.MoveTowards(transform.position, SpawnDe.transform.position, m_speed * Time.deltaTime);
            if(Vector3.Distance(transform.position, SpawnDe.transform.position) < 0.1f)
            {
                MovimientoDerecha = false;
            }
        }
        else if (MovimientoDerecha == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, SpawnIz.transform.position, m_speed * Time.deltaTime);
            if (Vector3.Distance(transform.position, SpawnIz.transform.position) < 0.1f)
            {
                MovimientoDerecha = true;
            }
        }

    }
}
