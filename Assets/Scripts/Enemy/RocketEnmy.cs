using UnityEngine;
using System.Collections;

public class RocketEnmy : MonoBehaviour
{
    public GameObject Rocket;


    public void Start()
    {
        InvokeRepeating("OnRocket", 2f, 2f);
    }



    public void OnRocket()
    {
        Instantiate(Rocket, transform.position, Quaternion.identity);
    }
}
