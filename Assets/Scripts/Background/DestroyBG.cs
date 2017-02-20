using UnityEngine;
using System.Collections;

public class DestroyBG : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Rocket")
        {
            Destroy(other.gameObject);
        }
        Destroy(other.gameObject);
    }
}
