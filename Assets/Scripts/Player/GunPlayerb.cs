using UnityEngine;
using System.Collections;

public class GunPlayerb : MonoBehaviour
{

    public GameObject GunPb;
    public AudioClip clis2;


    // Use this for initialization
    public void Start()
    {
        InvokeRepeating("Onshot", 0.5f, 0.1f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Onshot()
    {
        Instantiate(GunPb, transform.position, Quaternion.identity);
        AudioSource.PlayClipAtPoint(clis2,transform.position);
    }
}
