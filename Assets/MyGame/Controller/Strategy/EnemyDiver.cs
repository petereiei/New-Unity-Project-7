using UnityEngine;
using System.Collections;
using MyGame.Model;


namespace MyGame
{
    namespace Controller
    {
        namespace Strategy
        {
            public class EnemyDiver : IRunner
            {

                public float jumpforce = 100;
                
                public override void move(GameObject g)
                {
                    EnemyModel enemyModel = g.GetComponent<EnemyModel>();
                    g.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpforce * -1));
                }
            }
        }
    }
}
