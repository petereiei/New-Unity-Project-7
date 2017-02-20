using UnityEngine;
using System.Collections;

public class ItemController : MonoBehaviour
{

    public int Count;
    public float Waite;
    public GameObject Item;
    public GameObject Item2;


    // Use this for initialization
    void Start()
    {

        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(Waite);
        {
            for (int i = 0; i < Count; i++)
            {
                Vector2 spawn = new Vector2(10f, Random.Range(-4.2f, 3.5f));
                Quaternion spawn1 = Quaternion.identity;

                Instantiate(Item, spawn, spawn1);
                Instantiate(Item2, spawn, spawn1);
            }

        }
    }
}
