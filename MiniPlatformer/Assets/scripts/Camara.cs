using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour {

    public GameObject personaje;
    private Vector3 posicion;


	
	void Start () {

        posicion = transform.position - personaje.transform.position;
		
	}
	
	
	void Update () {

        transform.position = personaje.transform.position + posicion;
		
	}
}
