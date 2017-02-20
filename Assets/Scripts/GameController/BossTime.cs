using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossTime : MonoBehaviour {

    public GameObject Bossa;
    public float Waite;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(BossA());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator BossA()
    {
        yield return new WaitForSeconds(Waite);
        Instantiate(Bossa);
    }
}
