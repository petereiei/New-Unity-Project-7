using UnityEngine;
using System.Collections;
using MyGame.Controller.Strategy;
using System.Collections.Generic;



namespace MyGame
{
    namespace Controller
    {
        namespace EnemyState
        {
            [System.Serializable]
            public class IdelState : State
            {
                [SerializeField]
                public List<IRunner> methods;

                public override void init()
                {
                    base.init();
                    EnemyStateManager.IdleEventEnter.AddListener(onEnter);
                    EnemyStateManager.IdleEventExit.AddListener(onExit);

                    EventManager.onHitTriggerEvents.AddListener(OnTriggerEnter2D);

                }
                // Use this for initialization
                void Start()
                {

                }

                void FixedUpdate()
                {               
                    if(enemyModel.HP > 1)
                    {
                        methods[0].move(gameObject);
                    } 
                    if(enemyModel.HP < 1)
                    {
                        methods[1].move(gameObject);
                    } 
      
                }

                void OnTriggerEnter2D(Collider2D en)
                {
					if (en.tag == "Rocket")
                    {
						if (enemyModel.HP <= 0) 
						{                      
							onStateChanged ("Idle", "Death");
							Destroy(gameObject);

						}
						else if(enemyModel.HP > 0) 
						{
							onStateChanged ("Idle", "Damaged");
							Destroy(en.gameObject);
						}
                    }
                }
            }
        }
    }
}
