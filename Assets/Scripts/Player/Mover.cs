using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

    
    public float speedx;
 


    void Update()
    {

        transform.Translate(new Vector2(speedx, 0f) * Time.deltaTime);
    }

    void RRocket()
    {

    }



}
