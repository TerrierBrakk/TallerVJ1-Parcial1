using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
	

	private Rigidbody rb;
	Animator anim;
	private float isground =0.2f;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();	
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update()
	{
		Movimiento ();
		saltar ();
	}


	void Movimiento() ///funcion de movimiento en el eje x
		{
			float mov = Input.GetAxis("Horizontal") * Time.deltaTime * 3.0f;
			transform.Translate(mov, 0, 0);
		}

	void saltar() // Funcion para saltar
		{
			Debug.Log (isGrounded ());

			if (Input.GetButtonDown ("Jump")&&isGrounded())
			{
				
				rb.velocity = new Vector3 (0, 4, 0);
			}		
		}
		
	bool isGrounded() //Funcion que lanza un raycast hacia abajo para checar suelo
		{
			return Physics.Raycast (transform.position, Vector3.down, isground);
		}
	}

