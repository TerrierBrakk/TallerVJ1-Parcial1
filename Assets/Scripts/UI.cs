using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour {

	int contador;
	public Text Score;


	public void OnTriggerEnter(Collider other)
	{
		Destroy (other.gameObject);
		contador = contador + 1;

	}

	private void marcador()
	{
		Score.text = " Score: " + contador;
	}
}
