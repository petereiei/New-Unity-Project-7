using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunPlayerc : MonoBehaviour {

    public GameObject GunPc;
    public GameObject GunPcu;
    public GameObject GunPcd;
    public AudioClip clis3;

    // Use this for initialization
    public void Start()
    {
        InvokeRepeating("Onshot", 0.5f, 0.8f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Onshot()
    {
        Instantiate(GunPc, transform.position, Quaternion.identity);
        Instantiate(GunPcu, transform.position, Quaternion.identity);
        Instantiate(GunPcd, transform.position, Quaternion.identity);
        AudioSource.PlayClipAtPoint(clis3, transform.position);
    }
}
