using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public float velocidad = 5f;
    void Update()
    {
        transform.position += Vector3.forward  * velocidad * Time.deltaTime;
    }
}
