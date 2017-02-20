using UnityEngine;
using System.Collections;

public class BackgroundMove : MonoBehaviour
{

    public float speedx;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector2 offset = new Vector2(Time.time * speedx, 0);
        GetComponent<Renderer>().material.mainTextureOffset = offset;
	}
}
