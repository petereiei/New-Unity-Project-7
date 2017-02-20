using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossRocket : MonoBehaviour {

    public GameObject Bossc;
    public GameObject Bossu;
    public GameObject Bossd;

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
        Instantiate(Bossc, transform.position, Quaternion.identity);
        Instantiate(Bossu, transform.position, Quaternion.identity);
        Instantiate(Bossd, transform.position, Quaternion.identity);
    }
}
