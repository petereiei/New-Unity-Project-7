using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using System;
using MyGame.Controller;


namespace MyGame
{
    namespace View
    {
        [System.Serializable]
        public class ColliderEnemyEvent : UnityEvent<Collider2D> { }

        [System.Serializable]
        public class MoveEnemyEvent : UnityEvent { }

        public class EnemyView : MonoBehaviour
        {

            [SerializeField]
            public ColliderEnemyEvent onColliderEnemyEvents;

            [SerializeField]
            public MoveEnemyEvent onMoveEnemyEvent;

            void Start()
            {
                
            }

            void FixedUpdate()
            {
                onMoveEnemyEvent.Invoke();
            }

            void OnTriggerEnter2D(Collider2D other)
            {
                onColliderEnemyEvents.Invoke(other);
            }

        }
    }
}
