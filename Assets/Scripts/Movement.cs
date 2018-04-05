using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update()
	{
		Movimiento ();
		Salto ();
	}

	void Movimiento()
	{
		var mov = Input.GetAxis("Horizontal") * Time.deltaTime * 10.0f;
		transform.Translate(mov, 0, 0);
	}

	void Salto()
	{
		var salto = Input.GetAxis ("Vertical") * Time.deltaTime * 40.0f;


			transform.Translate (0, salto, 0);
	}
}