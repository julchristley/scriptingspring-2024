using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
   void OnTriggerEnter(Collider other)
   {
	   // destroys game object and the other game object it hits
	   Destroy(gameObject);
	   Destroy(other.gameObject);
   }
}
