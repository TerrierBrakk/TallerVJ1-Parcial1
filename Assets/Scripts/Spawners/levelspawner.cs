﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class levelspawner : MonoBehaviour {

    pooler objectPooler;
    float tiempo_generar;
    public float Frecuencia = 1f;
    Vector3 spawnInicial;
    float DistanciaZ = 3.1f;
    private void Start()
    {
        objectPooler = pooler.Instance;
        tiempo_generar = Time.time + Frecuencia;
        spawnInicial = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        for (int i=0; i<7; i++)
        {
            objectPooler.SpawnFromPool("nivel", spawnInicial, Quaternion.identity);
            spawnInicial.z -= DistanciaZ;
        }

    }

    void FixedUpdate()
    {
        if (tiempo_generar < Time.time)
        {
            objectPooler.SpawnFromPool("nivel", transform.position, Quaternion.identity);
            tiempo_generar = Time.time + Frecuencia;
        }

    }

}