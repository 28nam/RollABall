using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadArea : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Sphere")
        {
            // Sphere と衝突した
            Destroy(other.gameObject);
            Debug.Log("Sphere を破棄しました。");
        }
    }
}
