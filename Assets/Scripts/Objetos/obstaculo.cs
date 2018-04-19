using UnityEngine;
using System.Collections;

public class obstaculo : MonoBehaviour, pooledObjects {

	public float Velocidad;
	float posicionY;
	float posicionZ;
	int RandomY;
	int RandomZ;


	public void OnObjectSpawn () {

		Vector3 force = new Vector3 (Velocidad, 0f, 0f);

		RandomY = Random.Range (1, 3);
		RandomZ = Random.Range (1, 4);

        Debug.Log("y es: " + RandomY);
        Debug.Log("Z es: " + RandomZ);

		if (RandomY == 2) {
			posicionY = 2f;
		} 
		else {
			posicionY = 4f;
		}
		if (RandomZ == 2) {
			posicionZ = 0f;
		} else if (RandomZ == 3) {
			posicionZ = 2f;
		} else {
			posicionZ = -2f;
		}
			
		transform.position = new Vector3 (transform.position.x, posicionY, posicionZ);
		GetComponent<Rigidbody> ().velocity = force;


	}

}