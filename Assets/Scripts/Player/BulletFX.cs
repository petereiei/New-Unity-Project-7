using UnityEngine;
using System.Collections;

public class BulletFX : MonoBehaviour
{

    public GameObject fx;


    

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {

            fx.SetActive(true);
            Invoke("Release", 0.1f);
        }
    }


    void Release()
    {
        
        Instantiate(fx, transform.position, Quaternion.identity);
        fx.SetActive(false);
        Destroy(gameObject, 0.2f);
    }
}
