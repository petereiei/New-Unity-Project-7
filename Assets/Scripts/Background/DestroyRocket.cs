using UnityEngine;
using System.Collections;

public class DestroyRocket : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        
        Destroy(other.gameObject);
    }
}
