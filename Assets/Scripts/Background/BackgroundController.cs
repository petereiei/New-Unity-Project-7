using UnityEngine;
using System.Collections;

public class BackgroundController : MonoBehaviour
{

    public GameObject Background;
    public float a;
    public float b;

    // Use this for initialization
     void Start()
    {
        InvokeRepeating("Spawn", a, b);
    }

     void Spawn()
    {
        Instantiate(Background, transform.position, Quaternion.identity);
    }
}