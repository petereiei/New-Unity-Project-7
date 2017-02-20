using UnityEngine;
using System.Collections;


namespace MyGame
{
    namespace Controller
    {
        namespace Strategy
        {
            public abstract class IRunner : MonoBehaviour
            {

                public virtual void move(GameObject g)
                {

                }
            }
        }
    }
}
