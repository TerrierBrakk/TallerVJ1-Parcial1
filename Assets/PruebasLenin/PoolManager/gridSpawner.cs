using UnityEngine;
using System.Collections;

public class gridSpawner : MonoBehaviour {

    pooler objectPooler;
    float tiempo_generar;
    public float Frecuencia = 1f;
    int RandomZ;
    int Randomy;
    bool[,] Grid = new bool[2, 3];
    Vector3 posicion = new Vector3(1f , 1f, 1f);

    private void Start()
    {
        objectPooler = pooler.Instance;
        tiempo_generar = Time.time + 1f;
        posicion.x = transform.position.x;
    }

    void FixedUpdate()
    {
        if (tiempo_generar < Time.time)
        {
            RandomZ = Random.Range(0, 3);
            Randomy = Random.Range(0, 2);


            for (int y = 0; y < 2; y++)
            {
                for (int z = 0; z < 3; z++)
                {
                    posicion.y = y + 4f;
                    posicion.z = z + 6f;
                    if (y == Randomy && z == RandomZ)
                    {
                        Grid[y, z] = true;
                    }
                    if(y ==0 && Grid[y,z] == false)
                    {
                        objectPooler.SpawnFromPool("tronco", posicion, Quaternion.identity);
                    }
                    else if (y == 1 && Grid[y, z] == false)
                    {
                        objectPooler.SpawnFromPool("flama", posicion, Quaternion.identity);
                    }
                    Grid[y, z] = false;

                }

            }

            
            tiempo_generar = Time.time + Frecuencia;
        }

    }

}