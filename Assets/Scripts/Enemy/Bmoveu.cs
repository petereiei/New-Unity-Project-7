using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bmoveu : MonoBehaviour {

    private Rigidbody2D rb;
    public float speed;


    float moveXf = 0;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        moveXf = -3f;
        rb.velocity = new Vector2(moveXf, 1.5f) * speed;

    }
}
