using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocidad ;
    public int vida = 3;
    public GameObject BalaBlanca;
     public GameObject BalaNegra;
    public Transform point;
    public float velocidadDeBala;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
      
        float MovimientoX = Input.GetAxis("Horizontal");
        float MovimientoZ = Input.GetAxis("Vertical");
         Vector3 movimiento = new Vector3(MovimientoX, 0.0f, MovimientoZ );
          transform.position += movimiento * velocidad * Time.deltaTime;
          vidu();
         if (Input.GetMouseButtonDown(0))
        {
             Disparo(BalaBlanca);
        }
        if(Input.GetMouseButtonDown(1))
        {
           Disparo(BalaNegra);
        }
    }

    void vidu()
    {
        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }
     void Disparo(GameObject tipoDeBala)
    {
        GameObject bala = Instantiate(tipoDeBala, point.position, Quaternion.identity);
        Rigidbody rb = bala.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.velocity = bala.transform.forward * velocidadDeBala ;
           StartCoroutine(Destruir(bala));
            
        }
        else
        {
            Debug.LogWarning("La bala no tiene un Rigidbody adjunto.");
        }
    }
   void OnTriggerExit(Collider other)
   {
        if (other.CompareTag("Enemy"))
        {       
            Destroy(other.gameObject);
            vida--;
        }
   }
   IEnumerator Destruir(GameObject bullet)
    {
        
        yield return new WaitForSeconds(5f);   
        Destroy(bullet.gameObject);
    }
}
