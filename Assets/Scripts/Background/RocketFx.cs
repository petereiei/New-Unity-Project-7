using UnityEngine;
using System.Collections;

public class RocketFx : MonoBehaviour
{

    float timeLeft = 0.2f;

    // Update is called once per frame
    void Update ()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            Destroy(gameObject);
        }
    }
}
