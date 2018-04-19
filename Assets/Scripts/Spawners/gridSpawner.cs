using UnityEngine;
using System.Collections;

public class gridSpawner : MonoBehaviour {

    pooler objectPooler;
    float tiempo_generar;
    float tiempo_generaorbes;
    public float Frecuencia = 1f;
    public float FrecOrbes = 21f;
    int RandomX;
    int RandomY;
    bool[,] Grid = new bool[2, 3];
    Vector3 posicion;
    public static gridSpawner Instancia;

     void Start()
    {
        Instancia = this;
        objectPooler = pooler.Instance;
        tiempo_generar = Time.time + Frecuencia;
        tiempo_generaorbes = Time.time + FrecOrbes;
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

        if(tiempo_generaorbes < Time.time)
        {
            GeneraOrbes();
            tiempo_generaorbes = Time.time + FrecOrbes;
        }

    }

    void GeneraOrbes()
    {
        
        int PosicionRandom = Random.Range(0, 3);
        float PosicionXorbe;
        float PosicionZorbe = transform.position.z;
        if(PosicionRandom == 0)
        {
            PosicionXorbe = -.9f;
        }
        else if (PosicionRandom == 1)
        {
            PosicionXorbe = .1f;
        }
        else
        {
            PosicionXorbe = 1.1f;
        }

        Vector3 PosOrbe = new Vector3(PosicionXorbe, .5f, PosicionZorbe);


            for (int i=0; i<10; i++)
            {
         
                objectPooler.SpawnFromPool("orbe", PosOrbe, Quaternion.identity);
                PosOrbe.z += 1f;

        }
    }

}