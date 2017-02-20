using UnityEngine;
using System.Collections;

public class sclv2 : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
        }
        else if (other.gameObject.tag == "Player")
        {
            Example();
        }

    }



    void Example()
    {
        Application.LoadLevel("Gameplays3");
    }
}
