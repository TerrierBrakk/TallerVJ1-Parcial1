using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
	
	//escenario limite
	float limXpos = 1.20f;
	float limXneg = -1.20f;
	bool salto=false;
	//animator, rigibody y grounded
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
		deslizar ();

	}


	void Movimiento() ///funcion de movimiento en el eje x
		{
			
		float posX;

		//if (salto == false) {
			float mov = Input.GetAxis ("Horizontal") * Time.deltaTime * 2.0f;
			transform.Translate (mov, 0, 0);
			posX = transform.position.x;
		

			// Condiciones de limite de movimiento 
			if (posX >= limXpos) {
				Vector3 pos = transform.position;
				pos.x = limXpos;
				transform.position = pos;
			}

			if (posX <= limXneg) {

				Vector3 pos = transform.position;
				pos.x = limXneg;
				transform.position = pos;
						
			}
		}

	void saltar() // Funcion para saltar
		{
			

			if (Input.GetButtonDown ("Jump")&&isGrounded())
			{
				
			rb.velocity = new Vector3 (0, 6, 0);
			salto = true;
			print ("Salte");
			anim.Play ("Jump");
			}		
		}

		void deslizar()
		{
			if (Input.GetButtonDown ("Fire1")&&isGrounded())
			{
				print ("Slide");
				anim.Play ("Slide");
			}		
		}
		
	bool isGrounded() //Funcion que lanza un raycast hacia abajo para checar suelo
		{
			return Physics.Raycast (transform.position, Vector3.down, isground);
		}
	}

