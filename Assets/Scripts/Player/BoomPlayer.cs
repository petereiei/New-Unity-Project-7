using UnityEngine;
using System.Collections;

public class BoomPlayer : MonoBehaviour
{
    public GameObject Boom;


    // Use this for initialization
    void Start ()
    {
        InvokeRepeating("Boomz", 2f, 1f);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void Boomz()
    {
        Instantiate(Boom, transform.position, Quaternion.identity);
    }
}
