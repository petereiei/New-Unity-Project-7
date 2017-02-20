using UnityEngine;
using System.Collections;

public class NewScenes : MonoBehaviour
{
    public GameObject Item;


    // Use this for initialization
    void Start ()
    {
        InvokeRepeating("ItemScenes", 1f, 1f);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void ItemScenes()
    {
        Instantiate(Item, transform.position, Quaternion.identity);
    }
}
