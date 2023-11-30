using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadArea : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Sphere")
        {
            // Sphere ‚ÆÕ“Ë‚µ‚½
            Destroy(other.gameObject);
            Debug.Log("Sphere ‚ğ”jŠü‚µ‚Ü‚µ‚½B");
        }
    }
}
