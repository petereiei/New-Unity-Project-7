using UnityEngine;
using System.Collections;

public class BossEnemy : MonoBehaviour
{

    public float speed;
    private Rigidbody2D rb;
    GameObject player;


    private float moveYf = 0;


    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");

    }

    void Update()
    {
        if (player != null)
        {

            if (player.transform.position.y > transform.position.y)
            {
                moveYf = 1f;
            }
            else if (player.transform.position.y < transform.position.y)
            {
                moveYf = -1f;
            }
            rb.velocity = new Vector2(0f, moveYf) * speed;
        }

    }
}
