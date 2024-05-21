using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public float velocidad = 35f;
 
    void Update()
    {
        float T = Random.Range(velocidad - velocidad/3, velocidad + velocidad/3);
        transform.position += Vector3.back  * T * Time.deltaTime;
        StartCoroutine(Destruir());
    }
    IEnumerator Destruir()
    {
        yield return new WaitForSeconds(5f);
        Destroy(gameObject);
    }
}
