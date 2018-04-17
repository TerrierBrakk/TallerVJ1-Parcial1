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
	}

	void Movimiento()
	{
		var mov = Input.GetAxis("Horizontal") * Time.deltaTime * 5.0f;
		transform.Translate(mov, 0, 0);
	}


}