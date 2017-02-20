using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveu : MonoBehaviour {

    public float speedu;



    void Update()
    {

        transform.Translate(new Vector2(speedu, 2f) * Time.deltaTime);
    }
}
