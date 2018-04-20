using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour {
	

	static int contador;
	public Text Score;

	void Start()
	{
		Score = GameObject.FindGameObjectWithTag ("UiScore").GetComponent<Text>();
		contador = 0;
	}
	void Update()
	{
		marcador ();

	}

	public void OnTriggerEnter(Collider other)
	{
		{
			if (other.GetComponent<Collider> ().CompareTag ("Player")) {
				print ("agarreobjet6o");
				contador = contador + 1;
				gameObject.SetActive (false);

			} 

		}

	}

	private void marcador()
	{
		Score.text = " Score: " + contador;
	}
}
