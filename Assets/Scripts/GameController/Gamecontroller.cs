using UnityEngine;
using System.Collections;

public class Gamecontroller : MonoBehaviour 
{
    public int Count;
    public float spawnwaite;
    public float Waite;
    public GameObject emyobj;

    // Use this for initialization
    void Start()
    {
        
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            for (int i = 0; i < Count; i++)
            {
                Vector2 spawn = new Vector2(10f, Random.Range(-4.2f,3.5f));
                Quaternion spawn1 = Quaternion.identity;

                Instantiate(emyobj, spawn, spawn1);

                yield return new WaitForSeconds(spawnwaite);
            }
            yield return new WaitForSeconds(Waite);
        }
    }

}
