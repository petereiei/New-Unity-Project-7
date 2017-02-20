using UnityEngine;
using System.Collections;

public class Enemymove : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;


    float moveXf = 0;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        moveXf = -1f;
        rb.velocity = new Vector2(moveXf, 0f) * speed;

    }

    
}
