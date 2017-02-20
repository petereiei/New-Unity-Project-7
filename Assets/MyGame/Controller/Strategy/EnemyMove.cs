using UnityEngine;
using System.Collections;
using MyGame.Model;



namespace MyGame
{
    namespace Controller
    {
        namespace Strategy
        {
            public class EnemyMove : IRunner
            {

                public override void move(GameObject g)
                {
                    EnemyModel enemyModel = g.GetComponent<EnemyModel>();
                    g.GetComponent<Rigidbody2D>().velocity = new Vector2(g.transform.localScale.x * enemyModel.moveSpeed,0);
                }
            }
        }
    }
}
