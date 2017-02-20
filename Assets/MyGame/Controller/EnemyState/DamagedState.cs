using UnityEngine;
using System.Collections;


namespace MyGame
{
    namespace Controller
    {
        namespace EnemyState
        {
            public class DamagedState : State
            {

                bool isDamage = false;
                public override void init()
                {
                    base.init();
                    EnemyStateManager.DamagedEventEnter.AddListener(onEnter);
                    EnemyStateManager.DamagedEventExit.AddListener(onExit);                   
                }
                void OnEnable()
                {
                    isDamage = false;
                }

                void Update()
                {                   
                    onDamaged();
                }

                void onDamaged()//Collider2D col)
                {
                   
                    if (!isDamage)
                    {
                        enemyModel.HP--;
						Release ();
                        isDamage = true;

                    }
                   
                    if (enemyModel.HP <= 0)
                    {
                        onStateChanged("Damaged", "Death");
                    }                                          
                    else
                    {
                        onStateChanged("Damaged", "Idel");
                    }                        
                }

				void Release()
				{

					Instantiate(enemyModel.fx, transform.position, Quaternion.identity);

				}
            }
        }
    }
}
