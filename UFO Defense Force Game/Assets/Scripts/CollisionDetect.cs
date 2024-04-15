using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
   void OnTriggerEnter(Collider other)
   {
	   // destroys game object and the other game object it hits
        if (!other.gameObject.CompareTag("Pickup"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
   }
}
