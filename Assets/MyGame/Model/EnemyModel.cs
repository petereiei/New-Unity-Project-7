using UnityEngine;
using UnityEngine.Events;
using System;
using System.Collections;



namespace MyGame
{
    namespace Model
    {

        //[System.Serializable]
        //public class HealthChangedEnemyEvent : UnityEvent<int> { }

        [System.Serializable]
        public class EnemyModel : MonoBehaviour
        {
            [SerializeField]
            private int hp = 2;

            public float moveSpeed = 2f;
			public GameObject fx;


            public int HP
            {
                    get { return hp; }
                    set
                    {
                        hp = value;
                    if (hp > 2) hp = 2;
                    onHealthChangedEnemyEvents.Invoke(hp);
                    }
            }
                [SerializeField]
                public HealthChangedEvent onHealthChangedEnemyEvents;

            }
    }
}
