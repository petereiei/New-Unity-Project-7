using UnityEngine;
using System.Collections;
using MyGame.Model;



namespace MyGame
{
    namespace Controller
    {
        namespace EnemyState
        {
            public class DeathState : State
            {
					
                public float deathSpinMin = -100f;	
                public float deathSpinMax = 100f;	

				private Scoreplayer scoreplayer;
				Gamecontroller game;
               
                bool isDead = false;



                public override void init()
                {
                    base.init();
                    EnemyStateManager.DeathEventEnter.AddListener(onEnter);
                    EnemyStateManager.DeathEventExit.AddListener(onExit);

                   
                }
                void Update()
                {
                    if (isDead) return;

                    isDead = true;

                    GetComponent<Rigidbody2D>().fixedAngle = false;
                    GetComponent<Rigidbody2D>().AddTorque(Random.Range(deathSpinMin, deathSpinMax));

					Release ();
                    Destroy(gameObject);

                }

				void Release()
				{

					Instantiate(enemyModel.fx, transform.position, Quaternion.identity);

				}


            }
        }
    }
}
