using UnityEngine;
using System.Collections;

public class gridSpawner : MonoBehaviour
{

    pooler objectPooler;
    float tiempo_generar;
    float tiempo_orbes;
    public float Frecuencia = 1f;
    public float FrecOrbes = 2f;
    int RandomX;
    int RandomY;
    bool[,] Grid = new bool[2, 3];
    Vector3 posicion;
    float PosOrbeY = 0;
    float PosOrbeX = 0;
 
    

    private void Start()
    {
        objectPooler = pooler.Instance;
        tiempo_generar = Time.time + Frecuencia;
        tiempo_orbes = Time.time + FrecOrbes;
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
                        PosOrbeX = x -.9f;
                        PosOrbeY = y +.5f;
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

       

        if (tiempo_orbes < Time.time) 
        {
        float PosicionZorbe = transform.position.z;


        Vector3 PosOrbe = new Vector3(PosOrbeX, PosOrbeY, PosicionZorbe);


        for (int i = 0; i < 10; i++)
        {

            objectPooler.SpawnFromPool("orbe", PosOrbe, Quaternion.identity);
            PosOrbe.z += 1f;

        }
            tiempo_orbes = Time.time + FrecOrbes;
        }
      
    }

  
}



