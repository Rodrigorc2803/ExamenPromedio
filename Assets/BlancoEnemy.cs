using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlancoEnemy : Enemigo
{
   void OnTriggerEnter(Collider other)
   {
        if (other.CompareTag("BalaBlanca"))
        {
            Destroy(gameObject);  
        }
   }
}
