using UnityEngine;
using System.Collections;
using MyGame.Model;
using MyGame.View;



namespace MyGame
{
    namespace Controller
    {
        public class EnemyController : MonoBehaviour
        {
            private EnemyModel enemymoel;
            private EnemyView enemyview;
            private Rigidbody2D rbenemy;

            public GameObject enemyViewObject;
            public GameObject enemyModelOject;

            void Awake()
            {
                enemymoel = enemyModelOject.GetComponent<EnemyModel>();
                enemyview = enemyViewObject.GetComponent<EnemyView>();
            }

            public void onMoveEnemy()
            {
                
                Rigidbody2D rb = enemyview.GetComponent<Rigidbody2D>();

                rb.velocity = new Vector2(-2f, 0f) * enemymoel.moveSpeed;

            }


           
            public void OnTriggerEnter2D(Collider2D other)
            {
                Debug.Log("Enemy");
                if (other.tag == "Player")
                {

                    if (enemymoel.HP > 0f)
                    {
                        Debug.Log("EnemyTD");
                        enemymoel.HP--;

                    }

                }

            }

        }
    }
}
