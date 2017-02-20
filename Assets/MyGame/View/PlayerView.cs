using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;


namespace MyGame
{
    namespace View
    {
        [System.Serializable]
        public class ColliderEvent : UnityEvent<Collider2D> { }

        [System.Serializable]
        public class InputPhysicsEvent : UnityEvent<float,float> { }


        public class PlayerView : MonoBehaviour
        {

            					
            [HideInInspector]
            public bool facingRight = true;			
                         

            [SerializeField]
            public ColliderEvent onColliderEvents;

            [SerializeField]
            public InputPhysicsEvent onHorizontalInputEvents;


            void FixedUpdate()
            {
               
                float h = CrossPlatformInputManager.GetAxis("Horizontal");
                float v = CrossPlatformInputManager.GetAxis("Vertical");

                onHorizontalInputEvents.Invoke(h,v);

               
            }


            void OnTriggerEnter2D(Collider2D other)
            {
                onColliderEvents.Invoke(other);
            }
        }
    }
}

