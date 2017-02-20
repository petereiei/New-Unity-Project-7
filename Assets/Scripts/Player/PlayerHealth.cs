using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{
    public int startingHealth = 100;
    public int currentHealth;
    public Slider healthSlider;
    public Image damageImage;
    public GameObject fx;
    public float flashSpeed = 5f;
    public Color flashColour = new Color(1f, 0f, 0f, 0.1f);


    Playermove Playermove;
    bool isDead;
    bool damaged;

    // Use this for initialization
    void Awake()
    {
        Playermove = GetComponent<Playermove>();

        currentHealth = startingHealth;

    }
	
	// Update is called once per frame
	void Update ()
    {
        if (damaged)
        {            
            damageImage.color = flashColour;
        }        
        else
        {           
            damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
        }
        damaged = false;
    }

    public void TakeDamage(int amount)
    {

        damaged = true;
        currentHealth -= amount;
        healthSlider.value = currentHealth;
       
        if (currentHealth <= 0 && !isDead)
        {
            Death();
        }
    }


    void Death()
    {
        
        isDead = true;
        Playermove.enabled = false;
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            Debug.Log("GGGGG");
            if (currentHealth <= 0)
            {
                
                Destroy(gameObject);
                
            }
            Invoke("Release", 0.1f);
            Destroy(other.gameObject);
        }
    }

    void Release()
    {

        Instantiate(fx, transform.position, Quaternion.identity);
        

    }


}
