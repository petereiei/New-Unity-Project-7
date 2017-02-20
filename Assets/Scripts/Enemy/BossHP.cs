using UnityEngine;
using System.Collections;

public class BossHP : MonoBehaviour
{
    public int startingHealth = 100;
    public int currentHealth;
	public int scorevalus;
    public GameObject fx;
    public AudioClip clis4;
    private Scoreplayer scoreplayer;
    GameObject Player;
    NewScenes newscenes;
    Gamecontroller game;

    void Awake()
    {
        GameObject GameControllerObject = GameObject.FindGameObjectWithTag("GameController");
        scoreplayer = GameControllerObject.GetComponent<Scoreplayer>();
        newscenes = GameControllerObject.GetComponent<NewScenes>();
        game = GameControllerObject.GetComponent<Gamecontroller>();
        currentHealth = startingHealth;
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Rocket")
        {
            if (currentHealth <= 0)
            {
                Invoke("Release", 0.1f);
                AudioSource.PlayClipAtPoint(clis4, transform.position);
                Destroy(gameObject);
                scoreplayer.addscore(scorevalus);
                newitemboss();
            }
            Invoke("Release", 0.1f);
            AudioSource.PlayClipAtPoint(clis4, transform.position);
            currentHealth--;
            Destroy(other.gameObject);
        }


    }

    void Release()
    {

        Instantiate(fx, transform.position, Quaternion.identity);
        

    }

    void newitemboss()
    {
        newscenes.enabled = true;
        game.enabled = false;
    }
}
