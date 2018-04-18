using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
	
	//escenario limite
	float limXpos = 1.20f;
	float limXneg = -1.20f;



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

		/*if (Input.GetKey (KeyCode.A)) 
		{
			Pos_X = Pos_X - 1.0f * Time.deltaTime;
		}

		if (Input.GetKey (KeyCode.D)) 
		{
			Pos_X = Pos_X + 1.0f * Time.deltaTime;
		}

		if (Pos_X >= 1.0f) 
		{
			Pos_X = 1.0f;
		}

		if (Pos_X <= -1.0f) 
		{
			Pos_X = -1.0f;
		}

		Pos_Z += 1.0 * Time.deltaTime;

		transform.position = Vector3 (Pos_X, 0, Pos_Z);*/
	}


	void Movimiento() ///funcion de movimiento en el eje x
		{
			float mov = Input.GetAxis("Horizontal") * Time.deltaTime * 3.0f;

		if (mov >= limXpos) {
	
			mov = limXpos;
		}

		if (mov <= limXneg) {

			mov = limXneg;
		}
		transform.Translate (mov, 0, 0);
		}

	void saltar() // Funcion para saltar
		{
			

			if (Input.GetButtonDown ("Jump")&&isGrounded())
			{
				
			rb.velocity = new Vector3 (0, 5, 0);
			print ("Salte");
			anim.Play ("Jump");
			}		
		}
		
	bool isGrounded() //Funcion que lanza un raycast hacia abajo para checar suelo
		{
			return Physics.Raycast (transform.position, Vector3.down, isground);
		}
	}

