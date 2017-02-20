using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour
{

    public int startingHealth = 100;
    public int currentHealth;
    public GameObject fx;
    public AudioClip clip3;
    private Scoreplayer scoreplayer;


    void Awake()
    {
        GameObject GameControllerObject = GameObject.FindGameObjectWithTag("GameController");
        scoreplayer = GameControllerObject.GetComponent<Scoreplayer>();

        currentHealth = startingHealth;
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Rocket")
        {
            if (currentHealth <= 0)
            {
                AudioSource.PlayClipAtPoint(clip3, transform.position);
                Destroy(gameObject);
                scoreplayer.addscore(10);
            }
            else if(currentHealth > 0)
            {  
                currentHealth--;               
            }
            //fx.SetActive(true);
            Invoke("Release", 0.1f);
            AudioSource.PlayClipAtPoint(clip3,transform.position);
            Destroy(other.gameObject);
        }
    }


    void Release()
    {

        Instantiate(fx, transform.position, Quaternion.identity);
        //fx.SetActive(false);

    }

}
