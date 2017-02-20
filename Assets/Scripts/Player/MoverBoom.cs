using UnityEngine;
using System.Collections;

public class MoverBoom : MonoBehaviour {

    public float speedx;
    public float speedy;



    // Use this for initialization
    void Start()
    {

    }

    void Update()
    {
        transform.Translate(new Vector3(speedx, speedy, 0f) * Time.deltaTime);
    }
}
