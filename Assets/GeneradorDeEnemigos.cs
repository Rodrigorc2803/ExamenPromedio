using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorDeEnemigos : MonoBehaviour
{
 public GameObject[] enemigos; 
    public float intervaloMinimo = 1f; 
    public float intervaloMaximo = 3f; 
    public float rangoX = 30f;

    private float tiempoSiguienteGeneracion; 

    void Start()
    {

        tiempoSiguienteGeneracion = Time.time + Random.Range(intervaloMinimo, intervaloMaximo);
    }

    void Update()
    {
        if (Time.time >= tiempoSiguienteGeneracion)
        {
            GenerarEnemigo();
            tiempoSiguienteGeneracion = Time.time + Random.Range(intervaloMinimo, intervaloMaximo);
        }
    }

    void GenerarEnemigo()
    {
        GameObject enemigoAleatorio = enemigos[Random.Range(0, enemigos.Length)];
        float posicionX = transform.position.x + Random.Range(-rangoX / 2f, rangoX / 2f);
        Vector3 posicion = new Vector3(posicionX, transform.position.y, transform.position.z);
        Instantiate(enemigoAleatorio, posicion, Quaternion.identity);
    }
}