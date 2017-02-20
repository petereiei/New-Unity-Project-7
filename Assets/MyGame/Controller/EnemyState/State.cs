using UnityEngine;
using System.Collections;
using MyGame.Model;


namespace MyGame
{
    namespace Controller
    {
        namespace EnemyState
        {
            [System.Serializable]
            public abstract class State : MonoBehaviour
            {
                protected Animator anim;
                protected EnemyModel enemyModel;

                void Awake()
                {
                    init();
                }

                public virtual void init()
                {
                    anim = GetComponent<Animator>();
                    enemyModel = GetComponent<EnemyModel>();
                }

                public virtual void onEnter(Animator anim)
                {
                    if (this.anim == anim)
                        enabled = true;
                }

                public virtual void onExit(Animator anim)
                {
                    if (this.anim == anim)
                        enabled = false;
                }

                public virtual void onStateChanged(string from, string to)
                {
                    anim.ResetTrigger(from);
                    anim.SetTrigger(to);
                }
            }
        }
    }
}
