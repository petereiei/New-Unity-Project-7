using UnityEngine;
using System.Collections;

public class sssv : MonoBehaviour {

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
        moveXf = -1f;
        rb.velocity = new Vector2(moveXf, 0f) * speed;

    }
}
