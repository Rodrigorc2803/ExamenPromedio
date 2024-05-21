using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suelo : MonoBehaviour
{
    private float planoZ;
    public GameObject prefab;
   public float tiempoDeAparecer;
   public float tiempoDeDesaparecer;
    // Start is called before the first frame update
    void Start()
    {
        planoZ = prefab.GetComponent<Renderer>().bounds.size.z;
        StartCoroutine(creacion());
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    IEnumerator creacion()
    {
        yield return new WaitForSeconds(tiempoDeAparecer);
        Instantiate(prefab, new Vector3(transform.position.x, transform.position.y, transform.position.z + planoZ), Quaternion.identity);
        yield return new WaitForSeconds(tiempoDeDesaparecer);
         Destroy(gameObject);
    }
   
}
