using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class Playermove : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;

    


    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float h = CrossPlatformInputManager.GetAxis("Horizontal");
        float v = CrossPlatformInputManager.GetAxis("Vertical");

        Vector2 movement = new Vector2(h, v);
        rb.velocity = movement * speed;






    }


}
