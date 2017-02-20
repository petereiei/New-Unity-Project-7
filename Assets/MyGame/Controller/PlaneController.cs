using UnityEngine;
using System.Collections;
using MyGame.Model;
using MyGame.View;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


namespace MyGame
{
    namespace Controller
    {
        public class PlaneController : MonoBehaviour
        {            
            private PlaneModel model;
            private HpBarView hpview;
            private PlayerView view;
            private Rigidbody2D rb;

            public GameObject playerViewObject;
            public GameObject playerModelObject;
			public GameObject player;

            void Start()
            {
                model = playerModelObject.GetComponent<PlaneModel>();
                view = playerViewObject.GetComponent<PlayerView>();
            }


            public void onHorizontalInput(float h, float v)
            {
                Rigidbody2D rb = view.GetComponent<Rigidbody2D>();
                Vector2 movement = new Vector2(h, v);
                rb.velocity = movement * model.maxSpeed;
            }
             
            public void OnTriggerEnter2D(Collider2D other)

            {

                if (other.tag == "REnemy")
                {
                    
                    if (model.Health > 0f)
                    {

                        TakeDamage();
						Destroy (other.gameObject);

                    }

                    else if (model.Health <= 0f)
                    {
						Destroy(player);
						StartCoroutine("ReloadGame");

                    }
                  
                }
            }

            void TakeDamage()
            {               
                model.Health -= model.damageAmount; 
            }

            void OnDestroy()
            {
                GameObject profile = GameObject.Find("CanvasProfile");
                if(profile == null)
                {
                    return;
                }

                profile.GetComponent<InventoryController>().loseLife();
            }
			
			void ReloadGame()
			{							
				SceneManager.LoadScene ("Gameplay");
			}
        }
    }
}
