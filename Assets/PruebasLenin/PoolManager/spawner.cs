using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class spawner : MonoBehaviour {

	pooler objectPooler;
	float tiempo_generar;
	public float Frecuencia = 1f;

	private void Start()
	{
		objectPooler = pooler.Instance;
		tiempo_generar = Time.time + 1f;
	}

	void FixedUpdate() {
		
	
		if (tiempo_generar < Time.time) {
		
			objectPooler.SpawnFromPool ("obstaculo", transform.position, Quaternion.identity);
			tiempo_generar = Time.time + Frecuencia;
		}
			
	}

}
