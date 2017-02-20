using UnityEngine;
using System.Collections;

public class GunB : MonoBehaviour
{
    GameObject Player;
    GunPlayer GunPlayer;
    GunPlayerb GunPlayerb;
    GunPlayerc GunPlayerc;

    // Use this for initialization
    void Awake()
    {
        Player = GameObject.Find("Plan01/view/Playerview/GunPlayer");
        GunPlayer = Player.GetComponent<GunPlayer>();
        GunPlayerb = Player.GetComponent<GunPlayerb>();
        GunPlayerc = Player.GetComponent<GunPlayerc>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Gunbs();
            Destroy(gameObject);
        }
    }

    protected void Gunbs()
    {
        GunPlayer.enabled = false;
        GunPlayerb.enabled = false;
        GunPlayerc.enabled = true;
    }
}
