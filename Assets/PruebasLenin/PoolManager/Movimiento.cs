using UnityEngine;
using System.Collections;

public class Movimiento : MonoBehaviour, pooledObjects
{
    public float Velocidad;
    public void OnObjectSpawn()
    {
        Vector3 force = new Vector3(0f, 0f, -Velocidad);
        GetComponent<Rigidbody>().velocity = force;
    }

}
