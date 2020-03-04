using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaArriAbajo : MonoBehaviour {
    public float m_speed;
    private GameManager m_GameManager;
    public GameObject SpawnAr;
    public GameObject SpawnAb;
    bool MovimientoArriba;

    // Use this for initialization
    void Start () {
        m_GameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }
	
	// Update is called once per frame
	void Update () {
        if (MovimientoArriba)
        {

            transform.position = Vector3.MoveTowards(transform.position, SpawnAr.transform.position, m_speed * Time.deltaTime);
            if (Vector3.Distance(transform.position, SpawnAr.transform.position) < 0.1f)
            {
                MovimientoArriba = false;
            }
        }
        else if (MovimientoArriba == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, SpawnAb.transform.position, m_speed * Time.deltaTime);
            if (Vector3.Distance(transform.position, SpawnAb.transform.position) < 0.1f)
            {
                MovimientoArriba = true;
            }
        }
    }
}
