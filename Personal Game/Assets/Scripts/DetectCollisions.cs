using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
        else if (other.gameObject.CompareTag("Ghost"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
