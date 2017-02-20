using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour
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
        GunPlayer.enabled = true;
    }
	
	// Update is called once per frame
	void Update ()
    {
	    
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Rocketm")
        {
            GunA();
            Destroy(other.gameObject);
        }
		else if (other.gameObject.tag == "ItemRockets")
        {
            GunB();
            Destroy(other.gameObject);
        }
    }


	protected void GunA()
	{
		GunPlayer.enabled = false;
        GunPlayerc.enabled = false;
        GunPlayerb.enabled = true;
	}

    protected void GunB()
    {
        GunPlayer.enabled = false;
        GunPlayerb.enabled = false;
        GunPlayerc.enabled = true;
    }

}
