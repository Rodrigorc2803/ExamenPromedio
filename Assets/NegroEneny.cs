using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NegroEneny : Enemigo
{
  
   void OnTriggerEnter(Collider other)
   {
        if (other.CompareTag("BalaNegra"))
        {
            Destroy(gameObject);  
        }
   }
}
