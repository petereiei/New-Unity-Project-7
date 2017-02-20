using UnityEngine;
using System.Collections;

public class GunPlayer : MonoBehaviour
{
    public GameObject Rocket;
    public AudioClip clip;


    // Use this for initialization
    public void Start ()
    {
        InvokeRepeating("Onshot", 0.5f, 0.8f);
    }
	
	// Update is called once per frame
	void Update ()
    {
     
    }

    public void Onshot()
    {
        Instantiate(Rocket, transform.position, Quaternion.identity);
        AudioSource.PlayClipAtPoint(clip,transform.position);
    }

}
