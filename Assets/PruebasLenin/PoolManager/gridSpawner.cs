using UnityEngine;
using System.Collections;

public class gridSpawner : MonoBehaviour {

    pooler objectPooler;
    float tiempo_generar;
    public float Frecuencia = 1f;
    int RandomX;
    int RandomY;
    bool[,] Grid = new bool[2, 3];
    Vector3 posicion;

    private void Start()
    {
        objectPooler = pooler.Instance;
        tiempo_generar = Time.time + 1f;
        posicion = new Vector3(0f, 0f, transform.position.z);
    }

    void FixedUpdate()
    {
        if (tiempo_generar < Time.time)
        {
            RandomX = Random.Range(0, 3);
            RandomY = Random.Range(0, 2);


            for (int y = 0; y < 2; y++)
            {
                for (int x = 0; x < 3; x++)
                {
                    posicion.y = y;
                    posicion.x = x - .9f;
                    if (y == RandomY && x == RandomX)
                    {
                        Grid[y, x] = true;
                    }
                    else 
                    {
                       
                        objectPooler.SpawnFromPool("obstaculo", posicion, Quaternion.identity);
                    }
                   
                    Grid[y, x] = false;

                }

            }

            
            tiempo_generar = Time.time + Frecuencia;
        }

    }

}