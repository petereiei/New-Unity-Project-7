using UnityEngine;
using System.Collections;

public class BossController : MonoBehaviour
{

    public int Count;
    public float Waite;
    public GameObject emyobj;

    // Use this for initialization
    void Start()
    {

        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(Waite);
        for (int i = 0; i < Count; i++)
            {
                Instantiate(emyobj);
            }
    }
}
