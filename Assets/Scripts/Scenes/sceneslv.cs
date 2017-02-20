using UnityEngine;
using System.Collections;

public class sceneslv : MonoBehaviour
{
    

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Example();
        }
       
    }


   
    void Example()
    {
        Application.LoadLevel("Gameplays2");
    }

}
