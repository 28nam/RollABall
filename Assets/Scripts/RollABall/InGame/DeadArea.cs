using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadArea : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Sphere")
        {
            // Sphere �ƏՓ˂���
            Destroy(other.gameObject);
            Debug.Log("Sphere ��j�����܂����B");
        }
    }
}
